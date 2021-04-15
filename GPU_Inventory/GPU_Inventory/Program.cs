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
        // dependency injection of gpuInventory and gpuAsList into Manager class
        private static InventoryManager manager = new InventoryManager(gpuInventory, gpuAsList);
        // dependency injection of manager and gpuAsList into FormLogic class
        private static FormLogic formLogic = new FormLogic(manager, gpuAsList);

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]


        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false); 
            // dependency injection of formLogic into HomeForm
            Application.Run(new HomeForm(formLogic));
        }
    }
}
