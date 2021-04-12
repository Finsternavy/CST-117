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
        private int count = 0;
        private int selectedIndex = 0;
        private FormLogic formLogic;
        private string[] textBoxesText = new string[7];
        private TextBox[] textBoxes = new TextBox[7];

        public HomeForm(FormLogic formLogic)
        {
            InitializeComponent();

            this.formLogic = formLogic;

            initializeTextBoxArray();
            // update the data shown on the screen
            updateInventoryView();

            // set the default item in comboBox to "All"
            searchFilterComboBox.SelectedIndex = 0;
        }

        
        private void addButton_Click(object sender, EventArgs e)
        {
            updateTextBoxTextList();

            if (formLogic.validateTextBoxText(textBoxesText))
            {
                
                formLogic.addGPU();
                updateInventoryView();
                return;
            }

            MessageBox.Show("Please check your inputs. Either you did not complete all fields or Price, Cores, Clock Speed, " +
                    "Memory Size, or Quantity was not entered as a number.  Please make corrections and try again.");
        }

        private void initializeTextBoxArray()
        {
            count = 0;
            textBoxes.SetValue(manufactererTextBox, count);
            count++;
            textBoxes.SetValue(nameTextBox, count);
            count++;
            textBoxes.SetValue(priceTextBox, count);
            count++;
            textBoxes.SetValue(coresTextBox, count);
            count++;
            textBoxes.SetValue(clockSpeedTextBox, count);
            count++;
            textBoxes.SetValue(memorySizeTextBox, count);
            count++;
            textBoxes.SetValue(inventoryTextBox, count);
        }

        private void updateTextBoxes()
        {
            for(int i = 0; i < textBoxes.Length; i++)
            {
                textBoxes[i].Text = textBoxesText[i];
            }
        }

        // update data grid view with current contents of the GPU list
        private void updateInventoryView()
        {
            inventoryView = formLogic.updateInventoryView(inventoryView);
        }

        // Reset textboxes 
        private void clearForm()
        {
            for(int i = 0; i < textBoxesText.Length; i++)
            {
                textBoxesText[i] = "";
                textBoxes[i].Text = "";
            }

            //updateInventoryView();
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // remove selected row in datagrid view and remove GPU instance from gpus list
        private void deleteSelected_Click(object sender, EventArgs e)
        {
            
            // if the inventory is not empty
            if(formLogic.manager.gpuInventory.Count > 0)
            {
                selectedIndex = inventoryView.CurrentCell.RowIndex;
                // remove cooresponding item from inventory manager array
                formLogic.manager.delete(selectedIndex);
                updateInventoryView();
            }
        }

        // Update a gpu that already exist in the inventory based on user input
        private void updateSelected_Click(object sender, EventArgs e)
        {
            updateTextBoxTextList();

            if (formLogic.validateTextBoxText(textBoxesText))
            {
                selectedIndex = inventoryView.CurrentCell.RowIndex;

                formLogic.addGPU();
                formLogic.manager.delete(selectedIndex);

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
            formLogic.setIsSearchingTrue();
            // clear search results for later use
            formLogic.searchResults.Clear();
            // set current search string to user provided search textbox tex
            formLogic.currentSearch = searchTextBox.Text;
            // set current seach filter string to the string of the item index of the combobox
            formLogic.currentSearchFilter = searchFilterComboBox.SelectedItem.ToString();

            formLogic.manager.search(formLogic.currentSearch, formLogic.currentSearchFilter);

            updateForm();
        }

        private void loadAll_Click(object sender, EventArgs e)
        {
            formLogic.setIsSearchingFalse();

            // reset the dataGridView to display all the inventory items
            updateInventoryView();
        }

        private void restockSelected_Click(object sender, EventArgs e)
        {
            // Get index of selected row (Corresponds to gpus index also)
            int selectedIndex = inventoryView.CurrentCell.RowIndex;

            // set quantity value at the current index to the max allowed by Inventory Manager class
            formLogic.manager.restockItem(selectedIndex);
            updateInventoryView();
        }

        private void restockAll_Click(object sender, EventArgs e)
        {
            // set quantity value of all items to  the max allowed by Inventory Manager class
            formLogic.manager.restockAllItems();
            updateInventoryView();
        }

        // keep here
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

            updateTextBoxTextList();
            
        }

        // keep
        private void updateTextBoxTextList()
        {
            count = 0;

            textBoxesText.SetValue(manufactererTextBox.Text, count);
            count++;
            textBoxesText.SetValue(nameTextBox.Text, count);
            count++;
            textBoxesText.SetValue(priceTextBox.Text, count);
            count++;
            textBoxesText.SetValue(coresTextBox.Text, count);
            count++;
            textBoxesText.SetValue(clockSpeedTextBox.Text, count);
            count++;
            textBoxesText.SetValue(memorySizeTextBox.Text, count);
            count++;
            textBoxesText.SetValue(inventoryTextBox.Text, count);

            updateTextBoxes();

        }


        private void inventoryView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            updateTextBoxTextList();
            selectedIndex = inventoryView.CurrentCell.RowIndex;
            formLogic.gpuAsList.Clear();
            formLogic.gpuAsList = formLogic.manager.gpuInventory[selectedIndex].gpuToList();

            itemToTextBoxes(formLogic.gpuAsList);
        }

        private void clearForm_Click(object sender, EventArgs e)
        {
            clearForm();
            searchTextBox.Text = "";
        }
    }

}
