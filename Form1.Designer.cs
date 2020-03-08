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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savetxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savebinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stringsListBox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.msgDataLabel = new System.Windows.Forms.Label();
            this.txtArrayListBox = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(496, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.savetxtToolStripMenuItem,
            this.savebinToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // savetxtToolStripMenuItem
            // 
            this.savetxtToolStripMenuItem.Name = "savetxtToolStripMenuItem";
            this.savetxtToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.savetxtToolStripMenuItem.Text = "Save .txt";
            this.savetxtToolStripMenuItem.Click += new System.EventHandler(this.SavetxtToolStripMenuItem_Click);
            // 
            // savebinToolStripMenuItem
            // 
            this.savebinToolStripMenuItem.Name = "savebinToolStripMenuItem";
            this.savebinToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.savebinToolStripMenuItem.Text = "Save .bin";
            this.savebinToolStripMenuItem.Click += new System.EventHandler(this.savebinToolStripMenuItem_Click);
            // 
            // stringsListBox
            // 
            this.stringsListBox.FormattingEnabled = true;
            this.stringsListBox.Location = new System.Drawing.Point(12, 27);
            this.stringsListBox.Name = "stringsListBox";
            this.stringsListBox.Size = new System.Drawing.Size(120, 316);
            this.stringsListBox.TabIndex = 1;
            this.stringsListBox.SelectedIndexChanged += new System.EventHandler(this.StringsListBox_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.msgDataLabel, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(138, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 256F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(346, 256);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // msgDataLabel
            // 
            this.msgDataLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.msgDataLabel.AutoSize = true;
            this.msgDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.msgDataLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.msgDataLabel.Location = new System.Drawing.Point(164, 0);
            this.msgDataLabel.Name = "msgDataLabel";
            this.msgDataLabel.Size = new System.Drawing.Size(17, 25);
            this.msgDataLabel.TabIndex = 0;
            this.msgDataLabel.Text = " ";
            this.msgDataLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtArrayListBox
            // 
            this.txtArrayListBox.FormattingEnabled = true;
            this.txtArrayListBox.Location = new System.Drawing.Point(12, 27);
            this.txtArrayListBox.Name = "txtArrayListBox";
            this.txtArrayListBox.Size = new System.Drawing.Size(120, 316);
            this.txtArrayListBox.TabIndex = 3;
            this.txtArrayListBox.SelectedIndexChanged += new System.EventHandler(this.TxtArrayListBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 351);
            this.Controls.Add(this.txtArrayListBox);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.stringsListBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "P5 msgData";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savetxtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savebinToolStripMenuItem;
        private System.Windows.Forms.ListBox stringsListBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label msgDataLabel;
        private System.Windows.Forms.ListBox txtArrayListBox;
    }
}

