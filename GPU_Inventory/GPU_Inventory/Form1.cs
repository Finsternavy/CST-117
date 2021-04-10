using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

// Author: Christopher Finster
// CST-117 Milestone 3.  Inventory Manager
// Last updated: 10 Apr 2021

namespace GPU_Inventory
{
    public partial class Form1 : Form
    {
        
        public InventoryManager manager;
        public Form1()
        {
            InitializeComponent();
            // initialize manager 
            manager = new InventoryManager(3);
            // update the data shown on the screen
            updateDataGridView();

            // set the default item in comboBox to "All"
            searchFilterComboBox.SelectedIndex = 0;
        }

        // used to store the value of the row index in dataGrideView1 for changing visibility states and updating current item in inventory
        int selectedIndex = 0;
        // hold the search string for searching through the inventory
        string currentSearch = "";

        string currentSearchFilter = "All";
        // holds the state to let updateDataGridView() know how to display the inventory
        bool isSearching = false;
        // hold searchResults to pass between inventoryManager and the form
        List<int> searchResults = new List<int>();
        // used for print functions
        StringBuilder stringBuilder = new StringBuilder();

        private void addButton_Click(object sender, EventArgs e)
        {
            // create new instance of GPU class
            GPU myGPU = new GPU();
            // set all properties based on user info provided in textboxes
            setGPUProperties(myGPU);
            // add myGPU to inventory
            manager.add(myGPU);
            // updates how the inventory is displayed to user
            updateDataGridView();
            // remove text from textboxes
            Console.WriteLine(printGPUList(manager.gpuInventory));
            // clear textboxes for next use
            clearForm();
        }

        // update data grid view with current contents of the GPU list
        public void updateDataGridView()
        {
            // clear rows for redraw
            dataGridView1.Rows.Clear();

            // Get column values for the new row and add them to the dataGridView.
            foreach(GPU gpu in manager.gpuInventory)
            {
                // format gpu instance to display in readable manner
                string[] row = new string[] { gpu.getManufacterer(), gpu.getName(), gpu.getPrice().ToString(),
                gpu.getCores().ToString(), gpu.getClockSpeed().ToString(), gpu.getMemorySize().ToString(), gpu.getQuantity().ToString()};
                
                dataGridView1.Rows.Add(row);
            }

            // if user is searching for something
            if (isSearching == true)
            {
                searchResults = manager.displayInventory();
                // iterate through all rows in the dataGridView
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    // hide all rows so only matching search results can be displayed
                    row.Visible = false;
                }

                // for each item that was returned by the search function
                foreach(int index in searchResults)
                {
                    // make visible to the user in the dataGridView
                    dataGridView1.Rows[index].Visible = true;
                }
            }

            // set searching state to false so all data can be displayed without omission 
            isSearching = false;
        }

        public void setGPUProperties(GPU gpu)
        {
            // check if user provided data. If not, set defaults
            if(manufactererTextBox.Text != "")
            {
                // set property based on user provided info
                gpu.setManufacterer(manufactererTextBox.Text);
            }
            else
            {
                // if no data provided by user, set default
                gpu.setManufacterer("Default");
            }

            if(nameTextBox.Text != "")
            {
                gpu.setName(nameTextBox.Text);
            }
            else
            {
                gpu.setName("Default");
            }

            if(priceTextBox.Text != "")
            {
                double msrp;
                // check to see if user provided appropriate data. If not set default value
                if(double.TryParse(priceTextBox.Text, out msrp)){
                    // set property based on user provided info if appropriate data provided
                    gpu.setPrice(msrp);
                } else
                {
                    // Set to default if data provided not the appropriate type. User can udpate later
                    gpu.setPrice(0.00);
                }

            }
            else
            {
                // If user did not provide data, set default
                gpu.setPrice(0.00);
            }

            if(coresTextBox.Text != "")
            {
                int cores;
                // check to see if user provided appropriate data. If not set default value
                if (int.TryParse(coresTextBox.Text, out cores))
                {
                    gpu.setCores(cores);
                }
                else
                {
                    gpu.setCores(0);
                }
            }
            else
            {
                gpu.setCores(0);
            }

            if(clockSpeedTextBox.Text != "")
            {
                int clockSpeed;
                // check to see if user provided appropriate data. If not set default value
                if (int.TryParse(clockSpeedTextBox.Text, out clockSpeed))
                {
                    gpu.setClockSpeed(clockSpeed);
                }
                else
                {
                    gpu.setClockSpeed(0);
                }
            }
            else
            {
                gpu.setClockSpeed(0);
            }

            if(memorySizeTextBox.Text != "")
            {
                int memorySize;
                // check to see if user provided appropriate data. If not set default value
                if (int.TryParse(memorySizeTextBox.Text, out memorySize))
                {
                    gpu.setMemorySize(memorySize);
                }
                else
                {
                    gpu.setMemorySize(0);
                }
            }
            else
            {
                gpu.setMemorySize(0);
            }

            if(inventoryTextBox.Text != "")
            {
                int quantity;
                if(int.TryParse(inventoryTextBox.Text, out quantity))
                {
                    gpu.setQuantity(quantity);
                }
                else
                {
                    gpu.setQuantity(0);
                }
            }
            else
            {
                gpu.setQuantity(0);
            }
        }

        // Reset textboxes 
        public void clearForm()
        {
            manufactererTextBox.Text = "";
            nameTextBox.Text = "";
            priceTextBox.Text = "";
            coresTextBox.Text = "";
            clockSpeedTextBox.Text = "";
            memorySizeTextBox.Text = "";
            inventoryTextBox.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // remove selected row in datagrid view and remove GPU instance from gpus list
        private void deleteSelected_Click(object sender, EventArgs e)
        {
            // if the inventory is not empty
            if(manager.gpuInventory.Length > 0)
            {
                // hold index of currently selected row in the dataGridView
                selectedIndex = dataGridView1.CurrentCell.RowIndex;

                // remove cooresponding item from inventory manager array
                manager.delete(selectedIndex);

                // Check to ensure appropriate instance is removed from the gpus List
                Console.WriteLine(printGPUList(manager.gpuInventory));

                updateDataGridView();
            }
        }

        // Print the GPU list to test delete, update, add functionality is working correctly.
        public string printGPUList(GPU[] gpuArray)
        {
            // empty the stringbuilder to avoid duplication 
            stringBuilder.Clear();

            // if the array is not empty
            if (gpuArray.Length > 0)
            {
                foreach (GPU gpu in gpuArray)
                {
                    // add the gpu to the string
                    stringBuilder.Append(gpu.ToString());
                }
            }

            // return the string representation of the stringBuilder
            return stringBuilder.ToString();
        }

        // Update a gpu that already exist in the inventory based on user input
        private void updateSelected_Click(object sender, EventArgs e)
        {
            // Get index of selected row (Corresponds to gpus index also)
            selectedIndex = dataGridView1.CurrentCell.RowIndex;

            // if the  inventory is not empty
            if (manager.gpuInventory.Length > 0)
            {
                // create temporary gpu for passing and updating in the inventory array
                GPU tempGPU = new GPU();
                // If user entered new information
                if (manufactererTextBox.Text != "")
                {
                    tempGPU.setManufacterer(manufactererTextBox.Text);
                }
                else
                {
                    // set tempt to whats currently heald in the inventory array so data is not lost 
                    tempGPU.setManufacterer(manager.gpuInventory[selectedIndex].getManufacterer());
                }

                if (nameTextBox.Text != "")
                {
                    tempGPU.setName(nameTextBox.Text);
                }
                else
                {
                    tempGPU.setName(manager.gpuInventory[selectedIndex].getName());
                }

                if (priceTextBox.Text != "")
                {
                    double price;

                    // make sure the user entered data is the type expected
                    if (double.TryParse(priceTextBox.Text, out price))
                    {
                        tempGPU.setPrice(price);
                    }

                }
                else
                {
                    // if not expected type or blank, use current data
                    tempGPU.setPrice(manager.gpuInventory[selectedIndex].getPrice());
                }

                if (coresTextBox.Text != "")
                {
                    int cores;

                    if (int.TryParse(coresTextBox.Text, out cores))
                    {
                        tempGPU.setCores(cores);
                    }

                }
                else
                {
                    tempGPU.setCores(manager.gpuInventory[selectedIndex].getCores());
                }

                if (clockSpeedTextBox.Text != "")
                {
                    int clockSpeed;

                    if (int.TryParse(clockSpeedTextBox.Text, out clockSpeed))
                    {
                        tempGPU.setClockSpeed(clockSpeed);
                    }

                }
                else
                {
                    tempGPU.setClockSpeed(manager.gpuInventory[selectedIndex].getClockSpeed());
                }

                if (memorySizeTextBox.Text != "")
                {
                    int memorySize;

                    if (int.TryParse(memorySizeTextBox.Text, out memorySize))
                    {
                        tempGPU.setMemorySize(memorySize);
                    }

                }
                else
                {
                    tempGPU.setMemorySize(manager.gpuInventory[selectedIndex].getMemorySize());
                }

                if (inventoryTextBox.Text != "")
                {
                    int quantity;

                    if (int.TryParse(inventoryTextBox.Text, out quantity))
                    {
                        tempGPU.setQuantity(quantity);
                    }

                }
                else
                {
                    tempGPU.setQuantity(manager.gpuInventory[selectedIndex].getQuantity());
                }

                // pass our temp gpu to replace data of the gpu instance currently stored at the current index
                manager.update(tempGPU, selectedIndex);
                // update the displayed data
                updateDataGridView();
                // clear textboxes 
                clearForm();
            }   
        }

        private void search_Click(object sender, EventArgs e)
        {
            // change searching state to true
            isSearching = true;
            // clear search results for later use
            searchResults.Clear();
            // set current search string to user provided search textbox tex
            currentSearch = searchTextBox1.Text;
           
            // set current seach filter string to the string of the item index of the combobox
            currentSearchFilter = searchFilterComboBox.SelectedItem.ToString();

            // switch the filter.  Search by filter selected by user or default to "All"
            switch (currentSearchFilter)
            {
                // for comments on each statement, see case "All".  They all do the same thing just change the search method used
                case "All":

                    // create list of items that contain what the user searched for
                    manager.search(currentSearch);
                    // update the inventory data displayed to the user
                    updateDataGridView();
                    // remove text user entered in the textboxes
                    clearForm();

                    break;

                case "Manufacterer":

                    manager.searchManufacterer(currentSearch);
                    updateDataGridView();
                    clearForm();
                    break;

                case "Name":

                    manager.searchName(currentSearch);
                    updateDataGridView();
                    clearForm();
                    break;

                case "Price":

                    manager.searchPrice(currentSearch);
                    updateDataGridView();
                    clearForm();
                    break;

                case "Cores":

                    manager.searchCores(currentSearch);
                    updateDataGridView();
                    clearForm();
                    break;

                case "Clock Speed":

                    manager.searchClockSpeed(currentSearch);
                    updateDataGridView();
                    clearForm();
                    break;

                case "Memory Size":

                    manager.searchMemorySize(currentSearch);
                    updateDataGridView();
                    clearForm();
                    break;

                case "# In Stock":

                    manager.searchQuantity(currentSearch);
                    updateDataGridView();
                    clearForm();
                    break;

                default:

                    // create list of items that contain what the user searched for
                    manager.search(currentSearch);
                    // update the inventory data displayed to the user
                    updateDataGridView();
                    // remove text user entered in the textboxes
                    clearForm();

                    break;
            }

        }

        private void loadAll_Click(object sender, EventArgs e)
        {
            isSearching = false;

            // reset the dataGridView to display all the inventory items
            updateDataGridView();
        }

        private void restockSelected_Click(object sender, EventArgs e)
        {
            // Get index of selected row (Corresponds to gpus index also)
            int selectedIndex = dataGridView1.CurrentCell.RowIndex;

            // set quantity value at the current index to the max allowed by Inventory Manager class
            manager.restockItem(selectedIndex);
            updateDataGridView();
        }

        private void restockAll_Click(object sender, EventArgs e)
        {
            // set quantity value of all items to  the max allowed by Inventory Manager class
            manager.restockAllItems();
            updateDataGridView();
        }
    }

}
