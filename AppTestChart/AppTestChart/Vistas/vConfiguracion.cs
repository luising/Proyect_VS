using AppTestChart.Clases;
using AppTestChart.ModeloBD;
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

namespace AppTestChart
{
    public partial class vConfiguracion : Form
    {
        List<cPDF> Listsrc = new List<cPDF>(); 
        public vConfiguracion()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData(){
            tb_timeView.Text = configGeneral.timeView.ToString();
        }
        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            String TimeView = tb_timeView.Text;
            int fTimeView;
            bool rs = int.TryParse(TimeView,out fTimeView);
            if (rs)
            {
                configGeneral.timeView = fTimeView;
                configGeneral.listpdf = Listsrc;
                new Conn().setConfiguracion();
                new Banner().Show();
                this.Close();
            }
            else MessageBox.Show("Datos Incorrectos Verifique los Datos");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofile = new OpenFileDialog();
            try
            {
                if (ofile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    
                    Listsrc.Add(new cPDF(ofile.FileName, "PdfUno"));
                }
            }
            catch
            {
                MessageBox.Show("Documento incorrecto");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofile = new OpenFileDialog();
            try
            {
                if (ofile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Listsrc.Add(new cPDF(ofile.FileName, "PdfDos"));
                }
            }
            catch
            {
                MessageBox.Show("Documento incorrecto");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofile = new OpenFileDialog();
            try
            {
                if (ofile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Listsrc.Add(new cPDF(ofile.FileName, "PdfTres"));
                }
            }
            catch
            {
                MessageBox.Show("Documento incorrecto");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofile = new OpenFileDialog();
            try
            {
                if (ofile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Listsrc.Add(new cPDF(ofile.FileName, "PdfCuatro"));
                }
            }
            catch
            {
                MessageBox.Show("Documento incorrecto");
            }
        }
    }
}
