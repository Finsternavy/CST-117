using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// still need to move search functionality and cell click methods in HomeForm over to here
/// </summary>
namespace GPU_Inventory
{
    public class FormLogic
    {
        public InventoryManager manager;
        public List<string> gpuAsList;
        public string[] row = new string[7];
        public List<int> searchResults = new List<int>();
        public string currentSearchFilter = "All";
        public string currentSearch = "";
        private string manufactererTest;
        private string nameTest;
        private double priceTest;
        private int coresTest;
        private int clockSpeedTest;
        private int memorySizeTest;
        private int quantityTest;
        private int count = 0;
        private int selectedIndex = 0;
        private bool isSearching = false;
        

        public FormLogic(InventoryManager manager, List<string> gpuAsList)
        {
            this.manager = manager;
            this.gpuAsList = gpuAsList;
        }

        public void addGPU()
        {
            GPU temp = textBoxesToItem();
            manager.gpuInventory.Add(temp);
        }

        public GPU textBoxesToItem()
        {
            GPU gpu = new GPU();

            gpu.setManufacterer(manufactererTest);
            gpu.setName(nameTest);
            gpu.setPrice(priceTest);
            gpu.setCores(coresTest);
            gpu.setClockSpeed(clockSpeedTest);
            gpu.setMemorySize(memorySizeTest);
            gpu.setQuantity(quantityTest);

            return gpu;
        }

        public bool validateTextBoxText(string[] textBoxesText)
        {
            if (!textBoxesText[0].Equals(null) & !"".Equals(textBoxesText[0]) & !textBoxesText[1].Equals(null) & !"".Equals(textBoxesText[1]) &
                double.TryParse(textBoxesText[2], out priceTest) & int.TryParse(textBoxesText[3], out coresTest) &
                int.TryParse(textBoxesText[4], out clockSpeedTest) & int.TryParse(textBoxesText[5], out memorySizeTest) &
                int.TryParse(textBoxesText[6], out quantityTest))
            {
                manufactererTest = textBoxesText[0];
                nameTest = textBoxesText[1];

                return true;
            }
            else
            {
                return false;
            }
        }

        public DataGridView updateInventoryView(DataGridView inventoryView)
        {
            // clear rows for redraw
            inventoryView.Rows.Clear();

            compileInventoryViewRows(inventoryView);

            // if user is searching for something
            if (isSearching == true)
            {
                searchResults = manager.displayInventory();
                // hide all rows in the dataGridView
                hideAllRows(inventoryView);

                // show only rows that match users search
                unhideResults(inventoryView);
            }

            // set searching state to false so all data can be displayed without omission 
            isSearching = false;
            return inventoryView;
        }

        public string[] compileRow(GPU gpu)
        {
            count = 0;

            row.SetValue(gpu.getManufacterer(), count);
            count++;
            row.SetValue(gpu.getName(), count);
            count++;
            row.SetValue(gpu.getPrice().ToString(), count);
            count++;
            row.SetValue(gpu.getCores().ToString(), count);
            count++;
            row.SetValue(gpu.getClockSpeed().ToString(), count);
            count++;
            row.SetValue(gpu.getMemorySize().ToString(), count);
            count++;
            row.SetValue(gpu.getQuantity().ToString(), count);

            return row;
        }

        public void compileInventoryViewRows(DataGridView inventoryView)
        {
            // Get column values for the new row and add them to the dataGridView.
            foreach (GPU gpu in manager.gpuInventory)
            {
                compileRow(gpu);

                inventoryView.Rows.Add(row);
            }
        }

        public void hideAllRows(DataGridView inventoryView)
        {
            foreach (DataGridViewRow row in inventoryView.Rows)
            {
                // hide all rows so only matching search results can be displayed
                row.Visible = false;
            }
        }

        public void unhideResults(DataGridView inventoryView)
        {
            // for each item that was returned by the search function
            foreach (int index in searchResults)
            {
                // make visible to the user in the dataGridView
                inventoryView.Rows[index].Visible = true;
            }
        }

        public string getManufactererTest()
        {
            return this.manufactererTest;
        }

        public string getNameTest()
        {
            return this.nameTest;
        }

        public double getPriceTest()
        {
            return this.priceTest;
        }

        public int getCoresTest()
        {
            return this.coresTest;
        }

        public int getClockSpeedTest()
        {
            return this.clockSpeedTest;
        }

        public int getMemorySizeTest()
        {
            return this.memorySizeTest;
        }

        public int getQuantityTest()
        {
            return this.quantityTest;
        }

        public void setIsSearchingFalse()
        {
            this.isSearching = false;
        }

        public void setIsSearchingTrue()
        {
            this.isSearching = true;
        }
    }
}
