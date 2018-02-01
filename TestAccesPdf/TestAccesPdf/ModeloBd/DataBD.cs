using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAccesPdf.ModeloBd
{
    public class DataBD
    {
        private DataBD(){}

        public static Users getUser(string User, string pass)
        {
            return new Conn<Users>()
                .SelectFirst("sp_getUser @pUser = " + User + ", @pPassword = " + pass);
        }
    }
}
