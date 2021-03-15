using System;
using System.Drawing;
using System.Windows.Forms;

namespace Programming_Project_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        
        //instance of the EmployeeManager class to hold multiple instance of employees
        public EmployeeManager myEmployeeManager = new EmployeeManager();

        //Allow user to upload a picture
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Open dialog box to allow user to select a file from their computer
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Assign user selected picture to the pictureBox in the form
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void joinTeamButton_Click(object sender, EventArgs e)
        {
            //Used for error handling if the age is not a number.  Requires validation to ensure employee instance does not fail when created
            int age;

            //Ensure a number was entered for age
            if (int.TryParse(ageTextBox.Text, out age))
            {
                // Create instance of employee based on the user entered data on the form
                Employee employee = new Employee(firstNameTextBox.Text, lastNameTextBox.Text, emailTextBox.Text, phoneTextBox.Text, int.Parse(ageTextBox.Text));

                // select logic based on user selection
                switch (teamListBox.SelectedIndex)
                {
                    case 0: 
                        
                        employee.setPreferredTeam("Red Team");
                        break;

                    case 1: 
                        
                        employee.setPreferredTeam("Blue Team");
                        break;

                    case 2: 
                        
                        employee.setPreferredTeam("Green Team");
                        break;

                    default:

                        employee.setPreferredTeam("Red Team");
                        break;
                }

                // If statements to select data user wishes to be made visible in their profile
                if (maleRadioButton.Checked)
                {
                    employee.setSex("Male");
                }
                if (femaleRadioButton.Checked)
                {
                    employee.setSex("Female");
                }

                if (firstNameCheckBox.Checked)
                {
                    employee.visibleData.Add(employee.getFirstName());
                }
                if (lastNameCheckBox.Checked)
                {
                    employee.visibleData.Add(employee.getLastName());
                }
                if (emailCheckBox.Checked)
                {
                    employee.visibleData.Add(employee.getEmail());
                }
                if (phoneCheckBox.Checked)
                {
                    employee.visibleData.Add(employee.getPhone());
                }
                if (ageCheckBox.Checked)
                {
                    employee.visibleData.Add(employee.getAge().ToString());
                }
                if (sexCheckBox.Checked)
                {
                    employee.visibleData.Add(employee.getSex());
                }
                if (teamCheckBox.Checked)
                {
                    employee.visibleData.Add(employee.getPreferredTeam());
                }

                // add the instance of employee to the employees list.  This is to allow you to change your check box selection and see only the selected information is made visible for that instance of employee
                myEmployeeManager.employees.Add(employee);

                // Update employee list
                employeesListLabel.Text = myEmployeeManager.employeesToString().ToString();

                previewLabel.Text = employee.employeeToString().ToString();

                // Reset age text box text if previously entered incorrectly
                ageTextBox.ForeColor = Color.Black;
            }
            else
            {
                // Visible representation of user input error
                ageTextBox.ForeColor = Color.Red;
                ageTextBox.Text = "INVALID. Enter a Number";
            }
            
        }



        private void clearButton_Click(object sender, EventArgs e)
        {
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            emailTextBox.Text = "";
            phoneTextBox.Text = "";
            ageTextBox.Text = "";
            firstNameCheckBox.Checked = false;
            lastNameCheckBox.Checked = false;
            emailCheckBox.Checked = false;
            phoneCheckBox.Checked = false;
            ageCheckBox.Checked = false;
            pictureBox1.Image = null;

            if (maleRadioButton.Checked)
            {
                maleRadioButton.Checked = false;
            }

            if (femaleRadioButton.Checked)
            {
                femaleRadioButton.Checked = false;
            }

            teamListBox.ClearSelected();
        }

        private void teamListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maleRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
