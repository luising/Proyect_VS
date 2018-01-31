using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTestChart.Utils
{
    class anCambioPanel
    {
        static List<Panel> ListaPanel;
        static int index;
        internal static void setPanel(List<Panel> pListaPanel)
        {
            ListaPanel = pListaPanel;
            ListaPanel[index].BringToFront();
        }

        internal static void NextPanel()
        {
            index = (index != ListaPanel.Count - 1)?index++:0;
            ListaPanel[index].BringToFront();
        }
    }
}
