using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace GPU_Inventory
{
    public partial class Form1 : Form
    {
        // List to hold GPU class instances
        public List<GPU> gpus { get; set; }

        public Form1()
        {
            gpus = new List<GPU>();
            InitializeComponent();
            initializeGPUList();
            updateDataGridView();
        }


        private void addButton_Click(object sender, EventArgs e)
        {
            GPU myGPU = new GPU();
            // set all properties based on user info provided in textboxes
            setGPUProperties(myGPU);
            gpus.Add(myGPU);
            // updates datagridview
            updateDataGridView();
            // remove text from textboxes
            clearForm();
        }

        // update data grid view with current contents of the GPU list
        public void updateDataGridView()
        {
            dataGridView1.Rows.Clear();

            // Get column values for the new row and add them to the dataGridView.
            foreach(GPU gpu in gpus)
            {
                string[] row = new string[] { gpu.getManufacterer(), gpu.getName(), gpu.getMSRP().ToString(),
                gpu.getCores().ToString(), gpu.getClockSpeed().ToString(), gpu.getMemorySize().ToString(), gpu.getQuantity().ToString()};
                dataGridView1.Rows.Add(row);
            }
        }

        // Initial data to work with at start
        public void initializeGPUList()
        {
            // Create instance of a GPU and add it to the GPU list
            gpus.Add(new GPU("ASUS", "RTX 2080ti", 999.99, 1500, 2500, 11, 10));
            gpus.Add(new GPU("MSI", "RTX 3080", 1599.99, 1800, 2700, 23, 1));
            gpus.Add(new GPU("Nvidia", "GTX 1080", 699.99, 1200, 1800, 6, 50));
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

            if(msrpTextBox.Text != "")
            {
                double msrp;
                // check to see if user provided appropriate data. If not set default value
                if(double.TryParse(msrpTextBox.Text, out msrp)){
                    // set property based on user provided info if appropriate data provided
                    gpu.setMSRP(msrp);
                } else
                {
                    // Set to default if data provided not the appropriate type. User can udpate later
                    gpu.setMSRP(0.00);
                }

            }
            else
            {
                // If user did not provide data, set default
                gpu.setMSRP(0.00);
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
            msrpTextBox.Text = "";
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
            int selectedIndex = dataGridView1.CurrentCell.RowIndex;

            gpus.RemoveAt(selectedIndex);

            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }

            Console.WriteLine(printGPUList());
        }

        // Print the GPU list to test delete, update, add functionality is working correctly.
        public string printGPUList()
        {
            StringBuilder sb = new StringBuilder();

            foreach(GPU gpu in gpus)
            {
                sb.Append(gpu.ToString());
            }

            return sb.ToString();
        }
    }
}
