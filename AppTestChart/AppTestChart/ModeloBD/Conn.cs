using AppTestChart.Clases;
using AppTestChart.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTestChart.ModeloBD
{
    #region class return result
    public class Conn<T> where T : class
    {
        public delegate T LoadEntity(string dt);
        private LoadEntity CreateItem;
        TestDataEntities Context;
        public Conn(LoadEntity loadMethod)
        {
            Context = new TestDataEntities();
            CreateItem = loadMethod;
        }
        public Conn()
        {
            Context = new TestDataEntities();
        }

        public IList<T> SelectToList(string SQLSelect)
        {
            return Context.Database.SqlQuery<T>(SQLSelect).ToList();
        }
        public T SelectFirst(string SQLSelect)
        {
            return Context.Database.SqlQuery<T>(SQLSelect).First();
        }

    }

    #endregion
    #region class set data
    class Conn
    {
        TestDataEntities Context;
        public Conn()
        {
            Context = new TestDataEntities();
        }

        public void setConfiguracion()
        {
            Context.sp_setTime(configGeneral.timeView);
            foreach (cPDF oPDF in configGeneral.listpdf)
            {
                Context.sp_setPdf(oPDF.Nombre, oPDF.srcPdf);
            }
        }
    }
    #endregion

}
