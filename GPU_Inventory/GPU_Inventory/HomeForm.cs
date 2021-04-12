using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

// Author: Christopher Finster
// CST-117 Milestone 3.  Inventory Manager
// Last updated: 10 Apr 2021

namespace GPU_Inventory
{
    public partial class HomeForm : Form
    {
        private string manufactererTest;
        private string nameTest;
        private string currentSearchFilter = "All";
        private string currentSearch = "";
        private double priceTest;
        private int coresTest;
        private int clockSpeedTest;
        private int memorySizeTest;
        private int quantityTest;
        private int count = 0;
        private int selectedIndex = 0;
        private bool isSearching = false;
        private string[] row = new string[7];
        private List<int> searchResults = new List<int>();

        private List<string> gpuAsList;
        private InventoryManager manager;
        private FormLogic formLogic;

        public HomeForm(InventoryManager manager, List<string> gpuAsList, FormLogic formLogic)
        {
            InitializeComponent();

            this.manager = manager;
            this.gpuAsList = gpuAsList;
            this.formLogic = formLogic;

            // update the data shown on the screen
            updateInventoryView();

            // set the default item in comboBox to "All"
            searchFilterComboBox.SelectedIndex = 0;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (validateTextBoxText())
            {
                GPU temp = new GPU();
                textBoxesToItem(temp);
                manager.gpuInventory.Add(temp);
                updateInventoryView();
                // clear textboxes for next use
                clearForm();
            }
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

        // update data grid view with current contents of the GPU list
        public void updateInventoryView()
        {
            // clear rows for redraw
            inventoryView.Rows.Clear();

            compileInventoryViewRows();

            // if user is searching for something
            if (isSearching == true)
            {
                searchResults = manager.displayInventory();
                // hide all rows in the dataGridView
                hideAllRows();

                // show only rows that match users search
                unhideResults();
            }

            // set searching state to false so all data can be displayed without omission 
            isSearching = false;
        }

        private void compileInventoryViewRows()
        {
            // Get column values for the new row and add them to the dataGridView.
            foreach (GPU gpu in manager.gpuInventory)
            {
                compileRow(gpu);

                inventoryView.Rows.Add(row);
            }
        }

        private void hideAllRows()
        {
            foreach (DataGridViewRow row in inventoryView.Rows)
            {
                // hide all rows so only matching search results can be displayed
                row.Visible = false;
            }
        }

        public void unhideResults()
        {
            // for each item that was returned by the search function
            foreach (int index in searchResults)
            {
                // make visible to the user in the dataGridView
                inventoryView.Rows[index].Visible = true;
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
            if(manager.gpuInventory.Count > 0)
            {
                selectedIndex = inventoryView.CurrentCell.RowIndex;
                // remove cooresponding item from inventory manager array
                manager.delete(selectedIndex);
                updateInventoryView();
            }
        }

        // Update a gpu that already exist in the inventory based on user input
        private void updateSelected_Click(object sender, EventArgs e)
        {
            if (validateTextBoxText())
            {
                selectedIndex = inventoryView.CurrentCell.RowIndex;

                GPU temp = new GPU();
                textBoxesToItem(temp);
                manager.delete(selectedIndex);
                manager.add(temp);

                updateInventoryView();
                clearForm();
            }
            
        }

        private void updateForm()
        {
            // update the inventory data displayed to the user
            updateInventoryView();
            // remove text user entered in the textboxes
            clearForm();
        }

        private void search_Click(object sender, EventArgs e)
        {
            // change searching state to true
            isSearching = true;
            // clear search results for later use
            searchResults.Clear();
            // set current search string to user provided search textbox tex
            currentSearch = searchTextBox.Text;
            // set current seach filter string to the string of the item index of the combobox
            currentSearchFilter = searchFilterComboBox.SelectedItem.ToString();

            manager.search(currentSearch, currentSearchFilter);

            updateForm();
        }

        private void loadAll_Click(object sender, EventArgs e)
        {
            isSearching = false;

            // reset the dataGridView to display all the inventory items
            updateInventoryView();
        }

        private void restockSelected_Click(object sender, EventArgs e)
        {
            // Get index of selected row (Corresponds to gpus index also)
            int selectedIndex = inventoryView.CurrentCell.RowIndex;

            // set quantity value at the current index to the max allowed by Inventory Manager class
            manager.restockItem(selectedIndex);
            updateInventoryView();
        }

        private void restockAll_Click(object sender, EventArgs e)
        {
            // set quantity value of all items to  the max allowed by Inventory Manager class
            manager.restockAllItems();
            updateInventoryView();
        }

        private void itemToTextBoxes(List<string> gpuAsList)
        {
            int index = 0;
            manufactererTextBox.Text = gpuAsList[index];
            index++;
            nameTextBox.Text = gpuAsList[index];
            index++;
            priceTextBox.Text = gpuAsList[index];
            index++;
            coresTextBox.Text = gpuAsList[index];
            index++;
            clockSpeedTextBox.Text = gpuAsList[index];
            index++;
            memorySizeTextBox.Text = gpuAsList[index];
            index++;
            inventoryTextBox.Text = gpuAsList[index];
            
        }

        public void textBoxesToItem(GPU gpu)
        {
            gpu.setManufacterer(manufactererTest);
            gpu.setName(nameTest);
            gpu.setPrice(priceTest);
            gpu.setCores(coresTest);
            gpu.setClockSpeed(clockSpeedTest);
            gpu.setMemorySize(memorySizeTest);
            gpu.setQuantity(quantityTest);  
        }

        public bool validateTextBoxText()
        {
            if (double.TryParse(priceTextBox.Text, out priceTest) & int.TryParse(coresTextBox.Text, out coresTest) &
                int.TryParse(clockSpeedTextBox.Text, out clockSpeedTest) & int.TryParse(memorySizeTextBox.Text, out memorySizeTest) &
                int.TryParse(inventoryTextBox.Text, out quantityTest))
            {
                manufactererTest = manufactererTextBox.Text;
                nameTest = nameTextBox.Text;

                return true;
            }
            else
            {
                MessageBox.Show("Please check your inputs. Either you did not complete all fields or Price, Cores, Clock Speed, " +
                    "Memory Size, or Quantity was not entered as a number.  Please make corrections and try again.");
                return false;
            }
        }

        private void inventoryView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedIndex = inventoryView.CurrentCell.RowIndex;
            gpuAsList.Clear();
            gpuAsList = manager.gpuInventory[selectedIndex].gpuToList();

            itemToTextBoxes(gpuAsList);
        }

        private void clearForm_Click(object sender, EventArgs e)
        {
            clearForm();
            searchTextBox.Text = "";
        }
    }

}
