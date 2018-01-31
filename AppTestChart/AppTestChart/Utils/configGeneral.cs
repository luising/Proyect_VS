using AppTestChart.Clases;
using AppTestChart.ModeloBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTestChart.Utils
{
    class configGeneral
    {
        static Configuracion c = new Conn<Configuracion>().SelectFirst("sp_GetConfig");
        public static int timeView = c.TimeWait;
        public static List<cPDF> listpdf;
        private configGeneral(){}

        internal static String getSrcpdf(String nombre)
        {
            return new Conn<String>().SelectFirst("sp_getPdf @namePdf = " + nombre);
        }

    }
}
