using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TestAccesPdf.ModeloBd
{
    public class Conn<T> where T : class
    {

        public delegate T LoadEntity(string dt);
        private LoadEntity CreateItem;
        BDpdfSrcEntities1 Context;
        public Conn(LoadEntity loadMethod)
        {
            Context = new BDpdfSrcEntities1();
            CreateItem = loadMethod;
        }
        public Conn()
        {
            Context = new BDpdfSrcEntities1();
        }

        public IList<T> SelectToList(string SQLSelect)
        {
            return Context.Database.SqlQuery<T>(SQLSelect).ToList();
        }

        public T SelectFirst(string SQLSelect)
        {
            try{return Context.Database.SqlQuery<T>(SQLSelect).First();}
            catch{ return null; }
        }
    }
}