﻿using PSULib.FileClasses.General;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSULib.FileClasses.Models
{
    public class XntFile : PsuFile
    {
        public class XntTextureEntry
        {
            /// <summary>
            /// If this value is set to 0x200 (512), it forces the minify/mipmap filter to 0 (minify point, mip nearest neighbor) and magnify filter to 0 (point).
            /// </summary>
            //public int disableFlag { get; set; }
            public string filename { get; set; }
            //public MinifyMipFilter minifyMipmapFilter { get; set; }
            //public MagnifyFilter magnifyFilter { get; set; }
            //public int unused1 { get; set; }
            //public int unused2 { get; set; }
        }

        public List<XntTextureEntry> fileEntries = new List<XntTextureEntry>();
        private int _testvar, _testvar1, _testvar2, _testvar3, _testvar4, _testvar5;

        public XntFile(string inFilename, List<string> names)
        {
            filename = inFilename;
            for (int i = 0; i < names.Count; i++)
            {
                XntTextureEntry entry = new XntTextureEntry();
                //entry.disableFlag = 0;
                entry.filename = names[i];
                //entry.minifyMipmapFilter = MinifyMipFilter.MIN_LINEAR_MIPMAP_POINT;
                //entry.magnifyFilter = MagnifyFilter.LINEAR;
                fileEntries.Add(entry);
            }
        }

        public XntFile(string inFilename, byte[] rawData, byte[] subHeader, int[] ptrs, int baseAddr)
        {
            header = subHeader;
            filename = inFilename;
            MemoryStream inStream = new MemoryStream(rawData);
            BinaryReader inReader = new BinaryReader(inStream);
            inStream.Seek(8, SeekOrigin.Begin);
            int topLevelLoc = inReader.ReadInt32();
            inStream.Seek(topLevelLoc, SeekOrigin.Begin);
            int stringCount = inReader.ReadInt32();
            int startLoc = inReader.ReadInt32() - baseAddr;

            inStream.Seek(startLoc, SeekOrigin.Begin);
            int[] stringLocs = new int[stringCount];
            for (int i = 0; i < stringCount; i++)
            {
                XntTextureEntry entry = new XntTextureEntry();
                _testvar1 = inReader.ReadInt32();
                stringLocs[i] = inReader.ReadInt32() - baseAddr;
                _testvar3 = (int)(MinifyMipFilter)inReader.ReadInt16();
                _testvar3 = (int)(MagnifyFilter)inReader.ReadInt16();
                _testvar1 = inReader.ReadInt32();
                _testvar1 = inReader.ReadInt32();
                fileEntries.Add(entry);
            }

            for (int i = 0; i < stringCount; i++)
            {
                inStream.Seek(stringLocs[i], SeekOrigin.Begin);
                List<byte> bytes = new List<byte>();
                byte currentChar = inReader.ReadByte();
                while (currentChar != 0)
                {
                    bytes.Add(currentChar);
                    currentChar = inReader.ReadByte();
                }
                fileEntries[i].filename = Encoding.GetEncoding("shift-jis").GetString(bytes.ToArray());
            }
        }

        public override byte[] ToRaw()
        {
            MemoryStream outStream = new MemoryStream();
            BinaryWriter outWriter = new BinaryWriter(outStream);
            List<int> ptrList = new List<int>();

            //Step 1: Write each string, keeping their offset.
            int[] textOffsets = new int[fileEntries.Count];
            int listLoc = 0x10;

            outStream.Seek(0x10 + 0x14 * textOffsets.Length + 0x8, SeekOrigin.Begin);
            for (int i = 0; i < textOffsets.Length; i++)
            {
                textOffsets[i] = (int)outStream.Position;
                outWriter.Write(Encoding.GetEncoding("shift-jis").GetBytes(fileEntries[i].filename));
                outWriter.Write(new byte[4 - outStream.Position % 4]);
            }

            outStream.Seek(listLoc, SeekOrigin.Begin);
            for (int i = 0; i < textOffsets.Length; i++)
            {
                //outWriter.Write(fileEntries[i].disableFlag);
                ptrList.Add((int)outStream.Position);
                outWriter.Write(textOffsets[i]);
                //outWriter.Write((short)fileEntries[i].minifyMipmapFilter);
                //outWriter.Write((short)fileEntries[i].magnifyFilter);
                //outWriter.Write(fileEntries[i].unused1);
                //outWriter.Write(fileEntries[i].unused2);
            }

            int headerLoc = (int)outStream.Position;
            outWriter.Write(textOffsets.Length);
            ptrList.Add((int)outStream.Position);
            outWriter.Write(listLoc);
            int fileEnd = (int)outStream.Position;

            outStream.Seek(0, SeekOrigin.Begin);
            outWriter.Write((uint)0x4C54584E);
            outWriter.Write(fileEnd);
            outWriter.Write(headerLoc);
            //outWriter.Write(0);

            calculatedPointers = ptrList.ToArray();

            //Build subheader
            header = new byte[0x20];
            MemoryStream headerStream = new MemoryStream(header);
            BinaryWriter headerWriter = new BinaryWriter(headerStream);
            headerWriter.Write(0x4649584E);
            headerWriter.Write(0x18);
            headerWriter.Write(1);
            headerWriter.Write(0x20);
            headerWriter.Write(fileEnd);
            headerWriter.Write(fileEnd + 0x20);
            headerWriter.Write((int)(calculatedPointers.Length * 4 + 0x1F & 0xFFFFFFE0));
            //headerWriter.Write(1);

            return outStream.ToArray();
        }
    }
}
