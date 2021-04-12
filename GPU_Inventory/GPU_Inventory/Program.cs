using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPU_Inventory
{
    static class Program
    {
        private static List<GPU> gpuInventory = new List<GPU>();
        private static List<string> gpuAsList = new List<string>();
        private static InventoryManager manager = new InventoryManager(gpuInventory, gpuAsList);
        private static FormLogic formLogic = new FormLogic(manager, gpuInventory, gpuAsList);

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]


        static void Main()
        {
            // add instanciation of inventory manager class to here and pass to form1 (Change form 1 name)
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false); 
            Application.Run(new HomeForm(manager, gpuAsList, formLogic));
        }
    }
}
