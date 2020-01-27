namespace clrmdapp
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.filename = new System.Windows.Forms.TextBox();
            this.Path = new System.Windows.Forms.Label();
            this.filepath = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.resultobox = new System.Windows.Forms.TextBox();
            this.memscen = new System.Windows.Forms.Button();
            this.cpuanalyze = new System.Windows.Forms.Button();
            this.dacloc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "UploadDump";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(352, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filename";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // filename
            // 
            this.filename.Location = new System.Drawing.Point(447, 34);
            this.filename.Name = "filename";
            this.filename.Size = new System.Drawing.Size(117, 20);
            this.filename.TabIndex = 2;
            // 
            // Path
            // 
            this.Path.Location = new System.Drawing.Point(60, 87);
            this.Path.Name = "Path";
            this.Path.Size = new System.Drawing.Size(100, 20);
            this.Path.TabIndex = 3;
            this.Path.Text = "Path";
            // 
            // filepath
            // 
            this.filepath.ForeColor = System.Drawing.SystemColors.Highlight;
            this.filepath.Location = new System.Drawing.Point(114, 87);
            this.filepath.Name = "filepath";
            this.filepath.Size = new System.Drawing.Size(153, 20);
            this.filepath.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(114, 138);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "SaveResults";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(361, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Results";
            // 
            // resultobox
            // 
            this.resultobox.AllowDrop = true;
            this.resultobox.Location = new System.Drawing.Point(12, 189);
            this.resultobox.Multiline = true;
            this.resultobox.Name = "resultobox";
            this.resultobox.ReadOnly = true;
            this.resultobox.Size = new System.Drawing.Size(776, 249);
            this.resultobox.TabIndex = 8;
            this.resultobox.WordWrap = false;
            this.resultobox.TextChanged += new System.EventHandler(this.resultobox_TextChanged);
            // 
            // memscen
            // 
            this.memscen.Location = new System.Drawing.Point(594, 31);
            this.memscen.Name = "memscen";
            this.memscen.Size = new System.Drawing.Size(194, 23);
            this.memscen.TabIndex = 9;
            this.memscen.Text = "Analyze memory-scenario";
            this.memscen.UseVisualStyleBackColor = true;
            this.memscen.Click += new System.EventHandler(this.memscen_Click);
            // 
            // cpuanalyze
            // 
            this.cpuanalyze.Location = new System.Drawing.Point(594, 99);
            this.cpuanalyze.Name = "cpuanalyze";
            this.cpuanalyze.Size = new System.Drawing.Size(194, 23);
            this.cpuanalyze.TabIndex = 10;
            this.cpuanalyze.Text = "Analyze cpu-scenario";
            this.cpuanalyze.UseVisualStyleBackColor = true;
            this.cpuanalyze.Click += new System.EventHandler(this.button2_Click);
            // 
            // dacloc
            // 
            this.dacloc.Location = new System.Drawing.Point(447, 99);
            this.dacloc.Name = "dacloc";
            this.dacloc.Size = new System.Drawing.Size(117, 23);
            this.dacloc.TabIndex = 11;
            this.dacloc.Text = "Daclocation";
            this.dacloc.UseVisualStyleBackColor = true;
            this.dacloc.Click += new System.EventHandler(this.dacloc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dacloc);
            this.Controls.Add(this.cpuanalyze);
            this.Controls.Add(this.memscen);
            this.Controls.Add(this.resultobox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.filepath);
            this.Controls.Add(this.Path);
            this.Controls.Add(this.filename);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filename;
        private System.Windows.Forms.Label Path;
        private System.Windows.Forms.TextBox filepath;
        
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox resultobox;
        private System.Windows.Forms.Button memscen;
        private System.Windows.Forms.Button cpuanalyze;
        private System.Windows.Forms.Button dacloc;
    }
}

