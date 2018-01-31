using AppTestChart.Utils;
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

namespace AppTestChart
{
    public partial class Banner : Form
    {
        public Banner()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            loadChart();
            LoadPdf();
            enableAnimation();
            confiTimer();
            TiempoBanner.Start();
        }
        public void enableAnimation()
        {
            anCambioPanel.setPanel(new List<Panel>() { panel1, panel3, panel2 });
        }
        public void loadChart()
        {
           new configChart(chart1).load("Mascotas","Mascota","sp_getMascotas", SeriesChartType.Column, 4);
           new configChart(chart2).load("Mascotas", "Mascota", "sp_getMascotas", SeriesChartType.Line, 4);
           new configChart(chart3).load("Mascotas", "Mascota", "sp_getMascotas", SeriesChartType.Pie, 4);
           new configChart(chart4).load("Mascotas", "Mascota", "sp_getMascotas", SeriesChartType.Area, 4);

           new configChart(chart5).load("Mascotas", "Mascota", "sp_getMascotas", SeriesChartType.Line, 4);
           new configChart(chart6).load("Mascotas", "Mascota", "sp_getMascotas", SeriesChartType.Column, 4);
           new configChart(chart7).load("Mascotas", "Mascota", "sp_getMascotas", SeriesChartType.Area, 4);
           new configChart(chart8).load("Mascotas", "Mascota", "sp_getMascotas", SeriesChartType.Pie, 4);
        }
        public void LoadPdf()
        {
            axAcroPDF1.src = configGeneral.getSrcpdf("pdfUno");
            axAcroPDF2.src = configGeneral.getSrcpdf("pdfDos");
            axAcroPDF3.src = configGeneral.getSrcpdf("pdfTres");
            axAcroPDF4.src = configGeneral.getSrcpdf("pdfCuatro");
        }
        public void confiTimer(){
            TiempoBanner.Interval = 1000 * 3 * configGeneral.timeView; //milesegundos, segundos, minutos
        }
        private void TiempoBanner_Tick(object sender, EventArgs e)
        {
           loadChart();
           anCambioPanel.NextPanel();
        }
    }
}
