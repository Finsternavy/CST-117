using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Author: Christopher Finster
// CST-117 Milestone 4 and 5.  Inventory Manager
// Last updated: 14 Apr 2021

namespace GPU_Inventory
{
    public class FormLogic
    {
        public InventoryManager manager;
        public List<string> gpuAsList;
        // holds properties of gpu for input into DataGridView
        public string[] row = new string[7];
        public List<int> searchResults = new List<int>();
        // default search filter to "All"
        public string currentSearchFilter = "All";
        public string currentSearch = "";
        private bool isSearching = false;
        // readonly int values for meaningful readability in code
        private readonly int INDEX_MANUFACTURER = 0;
        private readonly int INDEX_NAME = 1;
        private readonly int INDEX_PRICE = 2;
        private readonly int INDEX_CORES = 3;
        private readonly int INDEX_CLOCKSPEED = 4;
        private readonly int INDEX_MEMORYSIZE = 5;
        private readonly int INDEX_QUANTITY = 6;
        

        public FormLogic(InventoryManager manager, List<string> gpuAsList)
        {
            // dependency injections
            this.manager = manager;
            this.gpuAsList = gpuAsList;
        }

        // convert text value of textboxes to appropraite data types to create a new gpu and id it to the inventory
        public void addGPU(string[] textboxes)
        {
            // creates a new instance of GPU class based on parsed text values of forms textboxes
            GPU temp = convertTextBoxesTextToItem(textboxes);
            // add the new gpu to the inventory
            manager.gpuInventory.Add(temp);
        }

        private GPU convertTextBoxesTextToItem(string[] textBoxes)
        {
            // create new GPU to hold the values
            GPU temp = new GPU();
            // set the values of the new, temporary GPU
            temp.setManufacturer(textBoxes[INDEX_MANUFACTURER]);
            temp.setName(textBoxes[INDEX_NAME]);
            temp.setPrice(tryParseDouble(textBoxes[INDEX_PRICE]));
            temp.setCores(tryParseInt(textBoxes[INDEX_CORES]));
            temp.setClockSpeed(tryParseInt(textBoxes[INDEX_CLOCKSPEED]));
            temp.setMemorySize(tryParseInt(textBoxes[INDEX_MEMORYSIZE]));
            temp.setQuantity(tryParseInt(textBoxes[INDEX_QUANTITY]));

            // return the GPU 
            return temp;
        }

        // attempt to convert text from priceTextBox to a double.  If not, set default value to zero
        private double tryParseDouble(string priceTest)
        {
            double price;

            // try to parse the string, if successful set value of price to parsed double value
            if (double.TryParse(priceTest, out price))
            {
                // return the parsed value
                return price;
            }

            // if parse failed, set default value
            price = 0.00;
            // return the default value
            return price;
        }

        // did user enter the expected data types
        public bool validateInput(string[] textBoxesText)
        {
            // if user entered the expected data types needed to create an instance of the GPU class
            if(stringNotEmpty(textBoxesText[INDEX_MANUFACTURER]) & stringNotEmpty(textBoxesText[INDEX_NAME]) &
                canParseToDouble(textBoxesText[INDEX_PRICE]) & canParseIntArray(textBoxesText)){

                return true;
            }

            return false;
        }

        // if the user provided data. disallow single letter entry
        private bool stringNotEmpty(string testString)
        {
            // if the string is not null and has at least 2 characters
            if (!testString.Equals(null) && testString.Length > 1)
            {
                return true;
            }

            return false;
        }

        // can the string be converted to an int?
        private bool canParseToInt(string testString)
        {
            // if string can successfully be parsed to an int. "_" discards out result
            if(int.TryParse(testString, out _))
            {
                return true;
            }

            return false;
        }

        //if try parse fails, return default value.  Should never return default unless data validation fails
        private int tryParseInt(string testString)
        {
            int number;

            // try to parse string to int
            if(int.TryParse(testString, out number))
            {
                // if successful return the int value
                return number;
            }

            // if not successful, set to default value
            number = 0;

            // return default value
            return number;
        }

        // if all elements of the array can successfully be parsed
        private bool canParseIntArray(string[] strings)
        {
            // skip the first three indexes that do not contain int values
            for(int i = INDEX_CORES; i < strings.Length; i++)
            {
                // if any index cannot be parsed, return false. Do not allow udpate or creation of GPU object
                if (!this.canParseToInt(strings[i])) return false;
            }
            // if all pass, data is valid, proceed
            return true;
        }

        // can the string can successfully be parsed to a double?
        private bool canParseToDouble(string testString)
        {
            // try to parse string to double
            if(double.TryParse(testString, out _))
            {
                // if successful, return true
                return true;
            }

            // if not successful return false
            return false;
        }

        // update data grid view to reflect any change
        public DataGridView updateInventoryView(DataGridView inventoryView)
        {
            // clear rows for redraw
            inventoryView.Rows.Clear();

            // redraw based on current gpuInventory
            compileInventoryViewRows(inventoryView);

            // if user is searching for something
            if (isSearching == true)
            {
                // return all instances that have properties that match search criteria
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

        // put all properties of the gpu into row array for transfer to data grid view
        public string[] compileRow(GPU gpu)
        {
            row.SetValue(gpu.getManufacturer(), INDEX_MANUFACTURER);
            row.SetValue(gpu.getName(), INDEX_NAME);
            row.SetValue(gpu.getPrice().ToString(), INDEX_PRICE);
            row.SetValue(gpu.getCores().ToString(), INDEX_CORES);
            row.SetValue(gpu.getClockSpeed().ToString(), INDEX_CLOCKSPEED);
            row.SetValue(gpu.getMemorySize().ToString(), INDEX_MEMORYSIZE);
            row.SetValue(gpu.getQuantity().ToString(), INDEX_QUANTITY);

            return row;
        }

        // convert all instances of GPU into rows to be added to DataGridView
        public void compileInventoryViewRows(DataGridView inventoryView)
        {
            // Get column values for the new row and add them to the dataGridView.
            foreach (GPU gpu in manager.gpuInventory)
            {
                // build a row based on this GPU
                compileRow(gpu);

                // add this row to the data grid view
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

        // set state of searching to false
        public void setIsSearchingFalse()
        {
            this.isSearching = false;
        }

        // set state of searching to true
        public void setIsSearchingTrue()
        {
            this.isSearching = true;
        }
    }
}
