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
            this.buttonGetPalette = new System.Windows.Forms.Button();
            this.pictureBoxOrigin = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.openFileDialogOrigin = new System.Windows.Forms.OpenFileDialog();
            this.buttonGetOrigin = new System.Windows.Forms.Button();
            //this.buttonChange = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPalette)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrigin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPalette
            // 
            this.pictureBoxPalette.Location = new System.Drawing.Point(12, 65);
            this.pictureBoxPalette.Name = "pictureBoxPalette";
            this.pictureBoxPalette.Size = new System.Drawing.Size(362, 440);
            this.pictureBoxPalette.TabIndex = 0;
            this.pictureBoxPalette.TabStop = false;
            // 
            // openFileDialogPalette
            // 
            this.openFileDialogPalette.FileName = "openFileDialogPalette";
            // 
            // buttonGetPalette
            // 
            this.buttonGetPalette.Location = new System.Drawing.Point(12, 12);
            this.buttonGetPalette.Name = "buttonGetPalette";
            this.buttonGetPalette.Size = new System.Drawing.Size(362, 25);
            this.buttonGetPalette.TabIndex = 1;
            this.buttonGetPalette.Text = "Open the file *.bmp for picture-palette";
            this.buttonGetPalette.UseVisualStyleBackColor = true;
            this.buttonGetPalette.Click += new System.EventHandler(this.buttonGetPicture_Click);
            // 
            // pictureBoxOrigin
            // 
            this.pictureBoxOrigin.Location = new System.Drawing.Point(411, 65);
            this.pictureBoxOrigin.Name = "pictureBoxOrigin";
            this.pictureBoxOrigin.Size = new System.Drawing.Size(361, 440);
            this.pictureBoxOrigin.TabIndex = 2;
            this.pictureBoxOrigin.TabStop = false;
            this.pictureBoxOrigin.Click += new System.EventHandler(this.pictureBox1_Click);
            //
            //
            //
            
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(809, 65);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(319, 440);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // openFileDialogOrigin
            // 
            this.openFileDialogOrigin.FileName = "openFileDialogOrigin";
            // 
            // buttonGetOrigin
            // 
            this.buttonGetOrigin.Location = new System.Drawing.Point(411, 13);
            this.buttonGetOrigin.Name = "buttonGetOrigin";
            this.buttonGetOrigin.Size = new System.Drawing.Size(361, 24);
            this.buttonGetOrigin.TabIndex = 4;
            this.buttonGetOrigin.Text = "Open the file *.bmp for picture-origin ";
            this.buttonGetOrigin.UseVisualStyleBackColor = true;
            this.buttonGetOrigin.Click += new System.EventHandler(this.buttonGetOrigin_Click);
            // 
            // PictureEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 530);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonGetOrigin);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBoxOrigin);
            this.Controls.Add(this.buttonGetPalette);
            this.Controls.Add(this.pictureBoxPalette);
            this.Name = "PictureEditorForm";
            this.Text = "PictureEditor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PictureEditorForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPalette)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrigin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPalette;
        private System.Windows.Forms.OpenFileDialog openFileDialogPalette;
        private System.Windows.Forms.Button buttonGetPalette;
        private System.Windows.Forms.PictureBox pictureBoxOrigin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialogOrigin;
        private System.Windows.Forms.Button buttonGetOrigin;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.Button buttonChange;
    }
}

