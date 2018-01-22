using AppTestChart.ModeloBD;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //loadGrafica();
            loadData();
        }

        public void loadGrafica()
        {
            this.chart1.Series.Clear();

            // Data arrays
            string[] seriesArray = { "Cat", "Dog", "Bird", "Monkey" };
            int[] pointsArray = { 2, 1, 7, 5 };

            // Set palette
            this.chart1.Palette = ChartColorPalette.EarthTones;

            // Set title
            this.chart1.Titles.Add("Animals");

            // Add series.
            for (int i = 0; i < seriesArray.Length; i++)
            {
                Series series = this.chart1.Series.Add(seriesArray[i]);
                series.Points.Add(pointsArray[i]);
            }
        }

        public void loadData()
        {
            // Set palette
            this.chart1.Palette = ChartColorPalette.EarthTones;

            // Set title
            this.chart1.Titles.Add("Animals");
            ConexionBd spQuery = new ConexionBd("Mascotasd");
            spQuery.setCommand("dbo.pb_getMascotas");
            DataTable Data = spQuery.Cargar_Data();
            chart1.DataSource = Data;
            Console.Write(Data);
            chart1.DataBind();

        }

        
    }
}
