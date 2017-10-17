using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lab2
{
    public partial class FormHistogram : Form
    {
        private string RGBChannel;
        CalculationClass somePicture;
        delegate Series FillSeries(Series series, Channel channel);
        public FormHistogram()
        {
            InitializeComponent();
        }

        public FormHistogram(Form f,string channel,CalculationClass source) : this()
        {
            f.Hide();
            RGBChannel = channel;
            somePicture = source;
            this.chartColor.Size = new Size(500, 500);
            chartColor.Dock = DockStyle.Fill;
            //добавляем в Chart область для рисования графиков, их может быть
            //много, поэтому даем ей имя.
            chartColor.ChartAreas.Add(new ChartArea("RGB"));
            
            //Создаем и настраиваем набор точек для рисования графика, в том
            //не забыв указать имя области на которой хотим отобразить этот
            //набор точек.
            Series SeriesOfColor = new Series(channel);
            SeriesOfColor.ChartType = SeriesChartType.Line;
            SeriesOfColor.ChartArea = "RGB";

            FillSeries del= FillRedSeries;
            Channel colorChannel= Channel.Red;
            switch (channel)
            {
                case "Green":
                    {
                        del = FillGreenSeries;
                        colorChannel = Channel.Green;
                        break;
                    }
                case "Blue":
                    {
                        del = FillBlueSeries;
                        colorChannel = Channel.Blue;
                        break;
                    }
            }
            SeriesOfColor = del.Invoke(SeriesOfColor,colorChannel);
            //SeriesOfRed=FillSeries(SeriesOfRed, Channel.Red);
            //Добавляем созданный набор точек в Chart
            chartColor.Series.Add(SeriesOfColor);//обязательно увеличить размеры области графика, менять цвет в зависимости от канала, сделать линию жирнее
        }
    
        private Series FillRedSeries(Series series, Channel channel)
        {
            for (int i = 0; i < 256; i++)
            {
                series.Points.AddXY(i+1, somePicture.RedData[i]);
            }
            return series;
        }

        private Series FillGreenSeries(Series series, Channel channel)
        {
            for (int i = 0; i < 256; i++)
            {
                series.Points.AddXY(i+1, somePicture.GreenData[i]);
            }
            return series;
        }

        private Series FillBlueSeries(Series series, Channel channel)
        {
            for (int i = 0; i < 256; i++)
            {
                series.Points.AddXY(i+1, somePicture.BlueData[i]);
            }
            return series;
        }

        private void FormHistogram_Load(object sender, EventArgs e)
        {

        }
    }
}
