namespace psu_generic_parser.Forms.FileViewers
{
	partial class PaletteTexFileViewer
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.btn_ImportTexture = new System.Windows.Forms.Button();
            this.btn_ImportPalette = new System.Windows.Forms.Button();
            this.btn_ExportPalette = new System.Windows.Forms.Button();
            this.btn_ExportTexture = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.picBoxPalette = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picBoxMain = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPalette)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ImportTexture
            // 
            this.btn_ImportTexture.Location = new System.Drawing.Point(6, 580);
            this.btn_ImportTexture.Name = "btn_ImportTexture";
            this.btn_ImportTexture.Size = new System.Drawing.Size(120, 23);
            this.btn_ImportTexture.TabIndex = 2;
            this.btn_ImportTexture.Text = "Import Texture";
            this.btn_ImportTexture.UseVisualStyleBackColor = true;
            this.btn_ImportTexture.Click += new System.EventHandler(this.btn_ImportTexture_Click);
            // 
            // btn_ImportPalette
            // 
            this.btn_ImportPalette.Location = new System.Drawing.Point(132, 580);
            this.btn_ImportPalette.Name = "btn_ImportPalette";
            this.btn_ImportPalette.Size = new System.Drawing.Size(104, 23);
            this.btn_ImportPalette.TabIndex = 3;
            this.btn_ImportPalette.Text = "Import Palette";
            this.btn_ImportPalette.UseVisualStyleBackColor = true;
            this.btn_ImportPalette.Click += new System.EventHandler(this.btn_ImportPalette_Click);
            // 
            // btn_ExportPalette
            // 
            this.btn_ExportPalette.Location = new System.Drawing.Point(132, 547);
            this.btn_ExportPalette.Name = "btn_ExportPalette";
            this.btn_ExportPalette.Size = new System.Drawing.Size(104, 23);
            this.btn_ExportPalette.TabIndex = 5;
            this.btn_ExportPalette.Text = "Export Palette";
            this.btn_ExportPalette.UseVisualStyleBackColor = true;
            this.btn_ExportPalette.Click += new System.EventHandler(this.btn_ExportPalette_Click);
            // 
            // btn_ExportTexture
            // 
            this.btn_ExportTexture.Location = new System.Drawing.Point(6, 547);
            this.btn_ExportTexture.Name = "btn_ExportTexture";
            this.btn_ExportTexture.Size = new System.Drawing.Size(120, 23);
            this.btn_ExportTexture.TabIndex = 4;
            this.btn_ExportTexture.Text = "Export Texture";
            this.btn_ExportTexture.UseVisualStyleBackColor = true;
            this.btn_ExportTexture.Click += new System.EventHandler(this.btn_ExportTexture_Click);
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            // 
            // picBoxPalette
            // 
            this.picBoxPalette.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.picBoxPalette.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxPalette.Location = new System.Drawing.Point(3, 19);
            this.picBoxPalette.Name = "picBoxPalette";
            this.picBoxPalette.Size = new System.Drawing.Size(256, 256);
            this.picBoxPalette.TabIndex = 6;
            this.picBoxPalette.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picBoxMain);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 541);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Texture";
            // 
            // picBoxMain
            // 
            this.picBoxMain.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.picBoxMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxMain.Location = new System.Drawing.Point(6, 19);
            this.picBoxMain.Name = "picBoxMain";
            this.picBoxMain.Size = new System.Drawing.Size(512, 512);
            this.picBoxMain.TabIndex = 0;
            this.picBoxMain.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(1161, 541);
            this.splitContainer1.SplitterDistance = 493;
            this.splitContainer1.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox2.Controls.Add(this.picBoxPalette);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(664, 541);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Color Palette";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // PaletteTexFileViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_ExportPalette);
            this.Controls.Add(this.btn_ExportTexture);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.btn_ImportTexture);
            this.Controls.Add(this.btn_ImportPalette);
            this.Name = "PaletteTexFileViewer";
            this.Size = new System.Drawing.Size(1296, 603);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPalette)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMain)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button btn_ImportTexture;
		private System.Windows.Forms.Button btn_ImportPalette;
		private System.Windows.Forms.Button btn_ExportPalette;
		private System.Windows.Forms.Button btn_ExportTexture;
		private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox picBoxPalette;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picBoxMain;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
