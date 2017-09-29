using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class PictureEditorForm : Form
    {
        public PictureEditorForm()
        {
            InitializeComponent();
            openFileDialogPalette.Filter = "BMP files(*.bmp)|*.bmp|All files(*.*)|*.*";
            openFileDialogOrigin.Filter = "BMP files(*.bmp)|*.bmp|All files(*.*)|*.*";
        }

        private void buttonGetPicture_Click(object sender, EventArgs e)
        {
            if (openFileDialogPalette.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            // получаем выбранный файл
            string filename = openFileDialogPalette.FileName;
            pictureBoxPalette.Image = Image.FromFile(filename);
            pictureBoxPalette.SizeMode=PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            pictureBoxOrigin.Image = Image.FromFile(openFileDialogPalette.FileName);
            pictureBoxPalette.Image = Image.FromFile(openFileDialogOrigin.FileName);
        }

        private void buttonGetOrigin_Click(object sender, EventArgs e)
        {
            if (openFileDialogOrigin.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            // получаем выбранный файл
            string filename = openFileDialogOrigin.FileName;
            pictureBoxOrigin.Image = Image.FromFile(filename);
            pictureBoxOrigin.SizeMode = PictureBoxSizeMode.StretchImage;
            if (openFileDialogOrigin.FileName!="" && openFileDialogPalette.FileName!=null)
            {
                Label labelSum = new Label();
                labelSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
                labelSum.Location = new System.Drawing.Point(375, 239);
                labelSum.Name = "labelSum";
                labelSum.Size = new System.Drawing.Size(25, 32);
                labelSum.TabIndex = 5;
                labelSum.Text = "+";
                this.Controls.Add(labelSum);

                Button buttonChange = new Button();
                buttonChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
                buttonChange.Location = new System.Drawing.Point(380, 104);
                buttonChange.Name = "buttonChange";
                buttonChange.Size = new System.Drawing.Size(25, 57);
                buttonChange.TabIndex = 5;
                buttonChange.Text = "←→\r\n";
                buttonChange.UseVisualStyleBackColor = true;
                buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
                this.Controls.Add(buttonChange);
            }
        }

        private void PictureEditorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Controls.Remove(labelSum);
            this.Controls.Remove(buttonChange);
        }
    }
}
