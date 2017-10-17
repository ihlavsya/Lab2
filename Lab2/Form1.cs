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
      //  private string ColorChannel = "";
        ComboBox comboBoxPalette;
        ComboBox comboBoxOrigin;
        ComboBox comboBoxResult;

        ComboBox comboBoxGetResult;

        ComboBox comboBoxPaletteGetChannel;
        ComboBox comboBoxGetOriginChannel;

        private CalculationClass Palette;
        private CalculationClass Origin;
        private CalculationClass Result;
        public PictureEditorForm()
        {
            InitializeComponent();

            openFileDialogPalette.Filter = "BMP files(*.bmp)|*.bmp|All files(*.*)|*.*";
            openFileDialogOrigin.Filter = "BMP files(*.bmp)|*.bmp|All files(*.*)|*.*";

            comboBoxPalette = new ComboBox();
            comboBoxOrigin = new ComboBox();
            comboBoxResult = new ComboBox();

            ToolStripMenuItem fileItem = new ToolStripMenuItem("File");

            ToolStripMenuItem fileItemOpen = new ToolStripMenuItem("Open");
            fileItem.DropDownItems.Add(fileItemOpen);
            fileItemOpen.Click += fileItemOpen_Click;

            string path = @"C:\Users\Maria\Documents\Visual Studio 2017\Projects\Компьютерная графика\Лабы\Lab2\for lab 2\heh.bmp";
            Image newImage = Image.FromFile(path);
            ToolStripButton paletteButton=new ToolStripButton("Palette", newImage, paletteButton_Click);
            paletteButton.Size = new System.Drawing.Size(100, 100);
            fileItemOpen.DropDownItems.Add(paletteButton);

            ToolStripButton originButton = new ToolStripButton("Composition", newImage, originButton_Click);
            originButton.Size = new System.Drawing.Size(100, 100);
            fileItemOpen.DropDownItems.Add(originButton);

            menuStrip1.Items.Add(fileItem);
        }

        private void paletteButton_Click(object sender, EventArgs e)
        {
            if (openFileDialogPalette.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            // получаем выбранный файл
            string filename = openFileDialogPalette.FileName;
            pictureBoxPalette.Image = Image.FromFile(filename);
            Palette = new CalculationClass (pictureBoxPalette.Image);
            pictureBoxPalette.SizeMode = PictureBoxSizeMode.Normal;

            comboBoxPalette.FormattingEnabled = true;
            comboBoxPalette.Items.AddRange
            (new object[] { "Red", "Green", "Blue" });
            comboBoxPalette.Location = new System.Drawing.Point(12, 515);
            comboBoxPalette.Name = "comboBoxPalette";
            comboBoxPalette.Size = new System.Drawing.Size(335, 21);
            comboBoxPalette.TabIndex = 5;
            comboBoxPalette.Text = "Get the Diagram";
            comboBoxPalette.SelectedIndexChanged += new System.EventHandler(this.comboBoxPalette_SelectedIndexChanged);
            this.Controls.Add(comboBoxPalette);

            comboBoxPaletteGetChannel = new ComboBox();
            comboBoxPaletteGetChannel.FormattingEnabled = true;
            comboBoxPaletteGetChannel.Items.AddRange(new object[] {"Red","Green","Blue"});
            comboBoxPaletteGetChannel.Location = new System.Drawing.Point(12, 38);
            comboBoxPaletteGetChannel.Name = "comboBoxPaletteGetChannel";
            comboBoxPaletteGetChannel.Size = new System.Drawing.Size(335, 21);
            comboBoxPaletteGetChannel.TabIndex = 5;
            comboBoxPaletteGetChannel.Text = "Get the picture in needed channel";
            comboBoxPaletteGetChannel.SelectedIndexChanged += new System.EventHandler(this.comboBoxPaletteGetChannel_SelectedIndexChanged);
            this.Controls.Add(comboBoxPaletteGetChannel);
        }

        private void originButton_Click(object sender, EventArgs e)
        {
            if (openFileDialogOrigin.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            // получаем выбранный файл
            string filename = openFileDialogOrigin.FileName;
            pictureBoxOrigin.Image = Image.FromFile(filename);
            Origin = new CalculationClass(pictureBoxOrigin.Image);
            pictureBoxOrigin.SizeMode = PictureBoxSizeMode.Normal;

            comboBoxOrigin.FormattingEnabled = true;
            comboBoxOrigin.Location = new System.Drawing.Point(395, 517);
            comboBoxOrigin.Name = "comboBoxOrigin";
            comboBoxOrigin.Size = new System.Drawing.Size(358, 21);
            comboBoxOrigin.TabIndex = 5;
            comboBoxOrigin.Text = "Get the Diagram";
            comboBoxOrigin.SelectedIndexChanged += new System.EventHandler(this.comboBoxOrigin_SelectedIndexChanged);
            this.Controls.Add(comboBoxOrigin);

            if (openFileDialogOrigin.FileName != null && openFileDialogPalette.FileName != null)
            {
                Label labelSum = new Label();
                labelSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
                labelSum.Location = new System.Drawing.Point(355, 239);
                labelSum.Name = "labelSum";
                labelSum.Size = new System.Drawing.Size(25, 32);
                labelSum.TabIndex = 5;
                labelSum.Text = "+";
                this.Controls.Add(labelSum);

                Button buttonChange = new Button();
                buttonChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
                buttonChange.Location = new System.Drawing.Point(360, 104);
                buttonChange.Name = "buttonChange";
                buttonChange.Size = new System.Drawing.Size(25, 57);
                buttonChange.TabIndex = 5;
                buttonChange.Text = "←→\r\n";
                buttonChange.UseVisualStyleBackColor = true;
                buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
                this.Controls.Add(buttonChange);

                //new comboox"=" then invoke needed method or function, then invoke OnPaint by update or smth like that for the picture box
                comboBoxGetResult = new ComboBox();
                comboBoxGetResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                comboBoxGetResult.FormattingEnabled = true;
                comboBoxGetResult.Items.AddRange(new object[] {"Lab","HSL","HSV"});
                comboBoxGetResult.Location = new System.Drawing.Point(756, 260);
                comboBoxGetResult.Name = "comboBoxGetResult";
                comboBoxGetResult.Size = new System.Drawing.Size(34, 33);
                comboBoxGetResult.TabIndex = 5;
                comboBoxGetResult.Text = "=";
                this.Controls.Add(comboBoxGetResult);

                comboBoxGetOriginChannel = new ComboBox();
                comboBoxGetOriginChannel.FormattingEnabled = true;
                comboBoxGetOriginChannel.Items.AddRange(new object[] {"Red","Green","Blue"});
                comboBoxGetOriginChannel.Location = new System.Drawing.Point(403, 38);
                comboBoxGetOriginChannel.Name = "comboBoxGetOriginChannel";
                comboBoxGetOriginChannel.Size = new System.Drawing.Size(335, 21);
                comboBoxGetOriginChannel.TabIndex = 5;
                this.Controls.Add(comboBoxGetOriginChannel);
            }
        }

        private void PictureBoxResult_Paint(object sender, PaintEventArgs e)// по люой причине вызываешься?
        {
            if (Palette != null) //&& (sender== pictureBoxPalette)) sender.PropertyName будет находиться PictureBoxPelette
            {
                Bitmap a = Palette.GetBitmapInRed(Channel.Red);
                // e.Graphics.DrawEllipse(new Pen(Color.Red), pictureBoxResult.Width - 10, pictureBoxResult.Width - 10, 20, 20);
                e.Graphics.DrawImage(a, 0, 0, a.Width, a.Height);
            }
        }

        private void PictureBoxOrigin_Paint(object sender, PaintEventArgs e)// ты по люой причине вызываешься?
        {
         //   if (Origin != null && (sender == pictureBoxOrigin))
           // {
            //    Bitmap a = Origin.GetBitmapInRed(Channel.Red);
            //    // e.Graphics.DrawEllipse(new Pen(Color.Red), pictureBoxResult.Width - 10, pictureBoxResult.Width - 10, 20, 20);
            //    e.Graphics.DrawImage(a, 0, 0, a.Width, a.Height);
            //}
        }

        private void fileItemOpen_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBoxOrigin_Click(object sender, EventArgs e)
        {

        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            CalculationClass a = Palette;
            Palette = Origin;
            Origin = Palette;
            Image b = pictureBoxPalette.Image;
            pictureBoxPalette.Image = pictureBoxOrigin.Image;
            pictureBoxOrigin.Image = b;
        }

        private void PictureEditorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Controls.Remove(labelSum);
            this.Controls.Remove(buttonChange);
        }

        private void comboBoxPalette_SelectedIndexChanged(object sender, EventArgs e)
        {
            string channel= comboBoxPalette.SelectedItem.ToString();
            FormHistogram newForm = new FormHistogram(this,channel,Palette);
            newForm.Show();
        }

        private void comboBoxOrigin_SelectedIndexChanged(object sender, EventArgs e)
        {
            string channel = comboBoxOrigin.SelectedItem.ToString();
            FormHistogram newForm = new FormHistogram(this, channel, Origin);
            newForm.Show();
        }

        private void comboBoxPaletteGetChannel_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBoxResult.Invalidate();
        }

        private void comboBoxGetOriginChannel_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBoxOrigin.Invalidate();
        }

        private void PictureEditorForm_Load(object sender, EventArgs e)
        {

        }
    }
} 
