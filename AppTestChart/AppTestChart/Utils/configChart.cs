using AppTestChart.ModeloBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using AppTestChart.Clases.Grafica;
using System.Drawing;

namespace AppTestChart.Utils
{
    class configChart
    {
        Chart grafica;
        Conn<_cMascota> db;
        public configChart(Chart Grafica)
        {
            this.grafica = Grafica;
            db = new Conn<_cMascota>();
        }
        public void Limpiar()
        {
            grafica.Series.Clear();
            grafica.Titles.Clear();
        }
        public void load(string title,string x, string sp, SeriesChartType d, double llinea)
        {
            Limpiar();
            grafica.Titles.Add(title);
            grafica.Palette = ChartColorPalette.EarthTones;
            grafica.DataBindTable(db.SelectToList(sp), x);
            grafica.Series[0].ChartType = d;
            if (llinea != 0) AgregarLinea(llinea);
            grafica.DataBind();
        }
        public void AgregarLinea(double llinea)
        {
            StripLine linea = new StripLine
            {
                Interval = 0,
                IntervalOffset = llinea, //Aqui va el limite del valor Y
                StripWidth = .2,
                BackColor = Color.Red
            };
            grafica.ChartAreas[0].AxisY.StripLines.Add(linea);
        }
    }
}
