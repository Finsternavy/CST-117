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
        private bool isSearching = false;
        private readonly int INDEX_MANUFACTURER = 0;
        private readonly int INDEX_NAME = 1;
        private readonly int INDEX_PRICE = 2;
        private readonly int INDEX_CORES = 3;
        private readonly int INDEX_CLOCKSPEED = 4;
        private readonly int INDEX_MEMORYSIZE = 5;
        private readonly int INDEX_QUANTITY = 6;
        

        public FormLogic(InventoryManager manager, List<string> gpuAsList)
        {
            this.manager = manager;
            this.gpuAsList = gpuAsList;
        }

        public void addGPU(string[] textboxes)
        {
            GPU temp = convertTextBoxesTextToItem(textboxes);
            manager.gpuInventory.Add(temp);
        }

        private GPU convertTextBoxesTextToItem(string[] textBoxes)
        {
            GPU temp = new GPU();
            temp.setManufacterer(textBoxes[INDEX_MANUFACTURER]);
            temp.setName(textBoxes[INDEX_NAME]);
            temp.setPrice(tryParseDouble(textBoxes[INDEX_PRICE]));
            temp.setCores(tryParseInt(textBoxes[INDEX_CORES]));
            temp.setClockSpeed(tryParseInt(textBoxes[INDEX_CLOCKSPEED]));
            temp.setMemorySize(tryParseInt(textBoxes[INDEX_MEMORYSIZE]));
            temp.setQuantity(tryParseInt(textBoxes[INDEX_QUANTITY]));

            return temp;
        }

        private double tryParseDouble(string priceTest)
        {
            double price;
            if (double.TryParse(priceTest, out price))
            {
                return price;
            }

            price = 0.00;
            return price;
        }

        public bool validateInput(string[] textBoxesText)
        {

            if(stringNotEmpty(textBoxesText[INDEX_MANUFACTURER]) & stringNotEmpty(textBoxesText[INDEX_NAME]) & 
                doubleTryParse(textBoxesText[INDEX_PRICE]) & intTryParseArray(textBoxesText)){

                return true;
            }

            return false;
        }

        private bool stringNotEmpty(string testString)
        {
            if (!testString.Equals(null) && testString.Length > 1)
            {
                return true;
            }

            return false;
        }

        private bool intTryParse(string testString)
        {
            int number;
            bool success = Int32.TryParse(testString, out number);

            return success;
        }

        private int tryParseInt(string testString)
        {
            int number;
            if(int.TryParse(testString, out number))
            {
                return number;
            }

            number = 0;
            return number;
        }

        private bool intTryParseArray(string[] strings)
        {
            foreach(string testString in strings)
            {
                if (this.isTrue(testString)) return true;
            }

            return false;
        }

        private bool isTrue(string testString)
        {
            if (intTryParse(testString))
            {
                return true;
            }

            return false;
        }

        private bool doubleTryParse(string testString)
        {
            double number;
            bool success = double.TryParse(testString, out number);

            return success;
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
            row.SetValue(gpu.getManufacterer(), INDEX_MANUFACTURER);
            row.SetValue(gpu.getName(), INDEX_NAME);
            row.SetValue(gpu.getPrice().ToString(), INDEX_PRICE);
            row.SetValue(gpu.getCores().ToString(), INDEX_CORES);
            row.SetValue(gpu.getClockSpeed().ToString(), INDEX_CLOCKSPEED);
            row.SetValue(gpu.getMemorySize().ToString(), INDEX_MEMORYSIZE);
            row.SetValue(gpu.getQuantity().ToString(), INDEX_QUANTITY);

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
