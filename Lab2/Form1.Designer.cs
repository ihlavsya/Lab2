namespace Lab2
{
    partial class PictureEditorForm
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
            this.pictureBoxPalette = new System.Windows.Forms.PictureBox();
            this.openFileDialogPalette = new System.Windows.Forms.OpenFileDialog();
            this.pictureBoxOrigin = new System.Windows.Forms.PictureBox();
            this.pictureBoxResult = new System.Windows.Forms.PictureBox();
            this.openFileDialogOrigin = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            //this.comboBoxGetOriginChannel = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPalette)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrigin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPalette
            // 
            this.pictureBoxPalette.Location = new System.Drawing.Point(12, 65);
            this.pictureBoxPalette.Name = "pictureBoxPalette";
            this.pictureBoxPalette.Size = new System.Drawing.Size(336, 440);
            this.pictureBoxPalette.TabIndex = 0;
            this.pictureBoxPalette.TabStop = false;
            // 
            // openFileDialogPalette
            // 
            this.openFileDialogPalette.FileName = "openFileDialogPalette";
            // 
            // pictureBoxOrigin
            // 
            this.pictureBoxOrigin.Location = new System.Drawing.Point(403, 65);
            this.pictureBoxOrigin.Name = "pictureBoxOrigin";
            this.pictureBoxOrigin.Size = new System.Drawing.Size(347, 440);
            this.pictureBoxOrigin.TabIndex = 2;
            this.pictureBoxOrigin.TabStop = false;
            this.pictureBoxOrigin.Click += new System.EventHandler(this.pictureBoxOrigin_Click);
            this.pictureBoxOrigin.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBoxOrigin_Paint);
            // 
            // pictureBoxResult
            // 
            this.pictureBoxResult.Location = new System.Drawing.Point(801, 65);
            this.pictureBoxResult.Name = "pictureBoxResult";
            this.pictureBoxResult.Size = new System.Drawing.Size(327, 440);
            this.pictureBoxResult.TabIndex = 3;
            this.pictureBoxResult.TabStop = false;
            this.pictureBoxResult.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBoxResult_Paint);
            // 
            // openFileDialogOrigin
            // 
            this.openFileDialogOrigin.FileName = "openFileDialogOrigin";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1140, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // PictureEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 569);
            this.Controls.Add(this.pictureBoxResult);
            this.Controls.Add(this.pictureBoxOrigin);
            this.Controls.Add(this.pictureBoxPalette);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PictureEditorForm";
            this.Text = "PictureEditor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PictureEditorForm_FormClosing);
            this.Load += new System.EventHandler(this.PictureEditorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPalette)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrigin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPalette;
        private System.Windows.Forms.OpenFileDialog openFileDialogPalette;
        private System.Windows.Forms.PictureBox pictureBoxOrigin;
        private System.Windows.Forms.PictureBox pictureBoxResult;
        private System.Windows.Forms.OpenFileDialog openFileDialogOrigin;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.MenuStrip menuStrip1;
        //private System.Windows.Forms.ComboBox comboBoxGetOriginChannel;
        // private System.Windows.Forms.ToolStripComboBox toolStripComboBoxChoice;
    }
}

