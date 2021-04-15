using System;
using System.Collections.Generic;
using System.Windows.Forms;

// Author: Christopher Finster
// CST-117 Milestone 4 and 5.  Inventory Manager
// Last updated: 14 Apr 2021

namespace GPU_Inventory
{
    public partial class HomeForm : Form
    {
        private FormLogic formLogic;
        // hold the text value of textboxes used for creating and editing GPUs
        private string[] textBoxesText = new string[7];
        // holds the actual texBoxes in an array for iteration in various methods
        private TextBox[] textBoxes = new TextBox[7];
        // readonly ints for meaningful readability in code
        private readonly int INDEX_MANUFACTURER = 0;
        private readonly int INDEX_NAME = 1;
        private readonly int INDEX_PRICE = 2;
        private readonly int INDEX_CORES = 3;
        private readonly int INDEX_CLOCKSPEED = 4;
        private readonly int INDEX_MEMORYSIZE = 5;
        private readonly int INDEX_QUANTITY = 6;
        // used to check the current state of the control panel
        private bool controlPanelHidden = true;

        public HomeForm(FormLogic formLogic)
        {
            InitializeComponent();
            // dependency injection of formLogic class
            this.formLogic = formLogic;

            // put all textboxes used for creation and udpating of GPUs into an iterable array
            initializeTextBoxArray();
            // update the data shown on the screen in the DataGridView object
            updateInventoryView();

            // set the default item in comboBox to "All"
            searchFilterComboBox.SelectedIndex = 0;
        }

        
        private void addButton_Click(object sender, EventArgs e)
        {
            // update textBoxText array with current string values in the textbox objects
            updateTextBoxTextList();

            // insure user entered correct data types and data can be parsed appropriately
            if (formLogic.validateInput(textBoxesText))
            {
                // add new GPU to the manager.gpuInventory list based on user supplied data or currently selected GPU
                formLogic.addGPU(textBoxesText);
                // update what the user sees in the DataGridView object.  Will stop commenting this method.
                updateInventoryView();
                // exit method if data entered was valid to prevent error message from being displayed
                return;
            }

            // if user supplied invalid data, explain to user how to enter data
            MessageBox.Show("Please check your inputs. Manufacterer and Name must be at least 2 characters long and Price, Cores" +
                ", Clock Speed, Memory Size, and Quantity must be a number.  Please make corrections and try again.");
        }

        // set values of the textBoxArray to point to our associated textboxes
        private void initializeTextBoxArray()
        {
            textBoxes.SetValue(manufactererTextBox, INDEX_MANUFACTURER);
            textBoxes.SetValue(nameTextBox, INDEX_NAME);
            textBoxes.SetValue(priceTextBox, INDEX_PRICE);
            textBoxes.SetValue(coresTextBox, INDEX_CORES);
            textBoxes.SetValue(clockSpeedTextBox, INDEX_CLOCKSPEED);
            textBoxes.SetValue(memorySizeTextBox, INDEX_MEMORYSIZE);
            textBoxes.SetValue(inventoryTextBox, INDEX_QUANTITY);
        }

        // update update the text properties of each textBox in the textBoxesArray based on user entered data or currently selected GPU
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
            // sync DataGridView between the logic class and form class
            inventoryView = formLogic.updateInventoryView(inventoryView);
        }

        // Reset textboxes 
        private void clearForm()
        {
            for(int i = 0; i < textBoxesText.Length; i++)
            {
                clearTextBoxText(i);
            }
        }

        private void clearTextBoxText(int index)
        {
            textBoxesText[index] = "";
            textBoxes[index].Text = "";
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
                // get index of current row selected in the data grid view (inventoryView)
                int selectedIndex = inventoryView.CurrentCell.RowIndex;
                // remove cooresponding item from inventory manager array
                formLogic.manager.delete(selectedIndex);
                updateInventoryView();
            }
        }

        // Update a gpu that already exist in the inventory based on user input
        private void updateSelected_Click(object sender, EventArgs e)
        {
            // update text array reprenting each textbox used in creating or updating a gpu.  This is done so we can pass strings vice
            // passing entire textBox objects
            updateTextBoxTextList();

            // if user supplied correct parsable data.  will stop commenting this line
            if (formLogic.validateInput(textBoxesText))
            {
                // get the index of data grid view user has selected.  Will stop commenting this line
                int selectedIndex = inventoryView.CurrentCell.RowIndex;

                // create new GPU using data from currently selected GPU implementing changes the user provided in the textBoxes
                formLogic.addGPU(textBoxesText);
                // remove the old version of the GPU we are replacing
                formLogic.manager.delete(selectedIndex);

                // update the screen to reflect the changes
                updateForm();
                return;
            }

            // if user supplied invalid data, explain to user how to enter data
            MessageBox.Show("Please check your inputs. Manufacterer and Name must be at least 2 characters long and Price, Cores" +
                ", Clock Speed, Memory Size, and Quantity must be a number.  Please make corrections and try again.");
        }

        // update the screen to reflect the changes
        private void updateForm()
        {
            updateInventoryView();
            // remove text user entered in the textboxes
            clearForm();
        }

        // search through the gpu and their properties based on user entered data and currently selected filter
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
            // search through current GPUs and their proporties based on user entered data and current filter
            formLogic.manager.search(formLogic.currentSearch, formLogic.currentSearchFilter);

            updateForm();
        }

        // load all GPU's 
        private void loadAll_Click(object sender, EventArgs e)
        {
            // set search state to false
            formLogic.setIsSearchingFalse();

            // reset the dataGridView to display all the inventory items
            updateInventoryView();
        }

        // set quantity of currently selected GPU to the max value
        private void restockSelected_Click(object sender, EventArgs e)
        {
            // if there is at least 1 gpu in the inventory
            if(formLogic.manager.gpuInventory.Count > 0)
            {
                // Get index of selected row (Corresponds to gpus index also)
                int selectedIndex = inventoryView.CurrentCell.RowIndex;

                // set quantity value at the current index to the max allowed by Inventory Manager class
                formLogic.manager.restockItem(selectedIndex);
                updateInventoryView();
            }
        }

        // set quantity of all GPU's to max value
        private void restockAll_Click(object sender, EventArgs e)
        {
            // if there is at least 1 GPU in the inventory. Will stop commenting this line
            if(formLogic.manager.gpuInventory.Count > 0)
            {
                // set quantity value of all items to  the max allowed by Inventory Manager class
                formLogic.manager.restockAllItems();
                updateInventoryView();
            }
            
        }

        // set all textboxes text based on currently selected gpu property values utilizing gpuToList() of the GPU class
        private void itemToTextBoxes(List<string> gpuAsList)
        {
            manufactererTextBox.Text = gpuAsList[INDEX_MANUFACTURER];
            nameTextBox.Text = gpuAsList[INDEX_NAME];
            priceTextBox.Text = gpuAsList[INDEX_PRICE];
            coresTextBox.Text = gpuAsList[INDEX_CORES];
            clockSpeedTextBox.Text = gpuAsList[INDEX_CLOCKSPEED];
            memorySizeTextBox.Text = gpuAsList[INDEX_MEMORYSIZE];
            inventoryTextBox.Text = gpuAsList[INDEX_QUANTITY];

            updateTextBoxTextList();
        }

        // update textbox text array values based off current text entered in each textbox
        private void updateTextBoxTextList()
        {
            textBoxesText.SetValue(manufactererTextBox.Text, INDEX_MANUFACTURER);
            textBoxesText.SetValue(nameTextBox.Text, INDEX_NAME);
            textBoxesText.SetValue(priceTextBox.Text, INDEX_PRICE);
            textBoxesText.SetValue(coresTextBox.Text, INDEX_CORES);
            textBoxesText.SetValue(clockSpeedTextBox.Text, INDEX_CLOCKSPEED);
            textBoxesText.SetValue(memorySizeTextBox.Text, INDEX_MEMORYSIZE);
            textBoxesText.SetValue(inventoryTextBox.Text, INDEX_QUANTITY);

            updateTextBoxes();
        }

        // if user clicks on a cell/row if the DataGridView inventoryView
        private void inventoryView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            updateTextBoxTextList();
            int selectedIndex = inventoryView.CurrentCell.RowIndex;
            // empty the values of gpuAsList list
            formLogic.gpuAsList.Clear();
            // set the values of the gpuAsList list based on currently selected gpu in the DataGridView inventoryView
            formLogic.gpuAsList = formLogic.manager.gpuInventory[selectedIndex].gpuToList();

            // set the text values of the textboxes based on select GPU's properties
            itemToTextBoxes(formLogic.gpuAsList);
        }

        // remove all user provided text from textboxes and the search box
        private void clearForm_Click(object sender, EventArgs e)
        {
            clearForm();
            searchTextBox.Text = "";
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // if control panel is hidden, unhide.  If not, hide
        private void toggleControlPanelButton_Click(object sender, EventArgs e)
        {
            toggleControlPanel();
        }

        // if control panel is hidden, unhide.  If not, hide
        public void toggleControlPanel()
        {
            // if it is visible
            if(controlPanelHidden == false)
            {
                // set value of state control to true
                controlPanelHidden = true;
                // show transparency panel to "hide" the control panel. Background color of this panel is set to the same color as the forms
                // transparency key color.  This causes a masking effect so the part of the form behind the transparency panel is not drawn
                // The reason for this approach vice just hiding and showing the actual control panel is so when the control panel is visible,
                // the entire form will appear in the center of the screen vice appearing shifted to the left
                transparencyPanel.Show();
                
                return;
            }

            // set value of state control to false if control panel was not visible
            controlPanelHidden = false;
            // hide transparency panel to allow user to see the control panel. Removes mask effect
            transparencyPanel.Hide();
            
        }
    }
}
