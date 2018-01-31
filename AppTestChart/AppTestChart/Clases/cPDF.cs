using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTestChart.Clases
{
    class cPDF
    {
        public string srcPdf { set; get; }
        public string Nombre { set; get; }
        public cPDF(string srcPdf, string namePdf)
        {
            this.Nombre = namePdf;
            this.srcPdf = srcPdf;
        }

    }
}
