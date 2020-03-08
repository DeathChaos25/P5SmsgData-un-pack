namespace P5SmsgData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.FilePathTxtBox = new System.Windows.Forms.TextBox();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.displayTXTBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(14, 14);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 20);
            this.btnOpenFile.TabIndex = 1;
            this.btnOpenFile.Text = "Open";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // FilePathTxtBox
            // 
            this.FilePathTxtBox.Location = new System.Drawing.Point(92, 14);
            this.FilePathTxtBox.Name = "FilePathTxtBox";
            this.FilePathTxtBox.ReadOnly = true;
            this.FilePathTxtBox.Size = new System.Drawing.Size(254, 20);
            this.FilePathTxtBox.TabIndex = 2;
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(352, 14);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(75, 20);
            this.btnLoadFile.TabIndex = 3;
            this.btnLoadFile.Text = "Convert";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // displayTXTBox
            // 
            this.displayTXTBox.AllowDrop = true;
            this.displayTXTBox.Location = new System.Drawing.Point(12, 40);
            this.displayTXTBox.Multiline = true;
            this.displayTXTBox.Name = "displayTXTBox";
            this.displayTXTBox.ReadOnly = true;
            this.displayTXTBox.Size = new System.Drawing.Size(415, 264);
            this.displayTXTBox.TabIndex = 4;
            this.displayTXTBox.Text = "Drag and Drop either a P5S text binary (0.bin) or a converted text file to conver" +
    "t!\r\nClick on this box to clear text.\r\n";
            this.displayTXTBox.Click += new System.EventHandler(this.displayTXTBox_Click);
            this.displayTXTBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.displayTXTBox_DragDrop);
            this.displayTXTBox.DragOver += new System.Windows.Forms.DragEventHandler(this.displayTXTBox_DragOver);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 316);
            this.Controls.Add(this.displayTXTBox);
            this.Controls.Add(this.btnLoadFile);
            this.Controls.Add(this.FilePathTxtBox);
            this.Controls.Add(this.btnOpenFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "P5S msgData unpacker/repacker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.TextBox FilePathTxtBox;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.TextBox displayTXTBox;
    }
}

