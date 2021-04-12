using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPU_Inventory
{
    public class FormLogic
    {
        InventoryManager manager;
        private List<GPU> gpuInventory;
        private List<string> gpuAsList;

        public FormLogic(InventoryManager manager, List<GPU> gpuInventory, List<string> gpuAsList)
        {
            this.manager = manager;
            this.gpuInventory = gpuInventory;
            this.gpuAsList = gpuAsList;
        }

        public void addGPU(HomeForm form)
        {
            if (form.validateTextBoxText())
            {
                GPU temp = new GPU();
                form.textBoxesToItem(temp);
                manager.gpuInventory.Add(temp);
                form.updateInventoryView();
                // clear textboxes for next use
                form.clearForm();
            }
        }


    }
}
