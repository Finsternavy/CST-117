using System;
using System.Text;


namespace GPU_Inventory
{
    public class Item
    {
        public Item()
        {

        }

        public Item(string manufacterer, string name, double msrp, int quantity)
        {
            this.manufacterer = manufacterer;
            this.name = name;
            this.msrp = msrp;
            this.quantity = quantity;
        }

        private string manufacterer = "";
        private string name = "";
        private double msrp = 0.00;
        private int quantity = 0;
        private bool selected = false;

        public string getManufacterer()
        {
            return this.manufacterer;
        }

        public void setManufacterer(string manufacterer)
        {
            this.manufacterer = manufacterer;
        }

        public string getName()
        {
            return this.name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public double getMSRP()
        {
            return this.msrp;
        }

        public void setMSRP(double msrp)
        {
            this.msrp = msrp;
        }

        public int getQuantity()
        {
            return this.quantity;
        }

        public void setQuantity(int quantity)
        {
            this.quantity = quantity;
        }

        public bool verifyQuantity(int toBeRemoved)
        {
            if(getQuantity() >= toBeRemoved)
            {
                return true;
            }

            return false;

        }

        public void decreaseQuantity(int toBeRemoved)
        {
            if (verifyQuantity(toBeRemoved))
            {
                this.quantity = getQuantity() - toBeRemoved;
                return;
            }

            Console.WriteLine("Not enough stock to fill order!");
        }

        public void increaseQuantity(int toBeAdded)
        {
            this.quantity = getQuantity() + toBeAdded;
        }

        public void toggleSelected()
        {
            if (!selected)
            {
                this.selected = true;
                return;
            }

            this.selected = false;
        }

        public bool getSelected()
        {
            return this.selected;
        }

        public void setSelected(bool selected)
        {
            this.selected = selected;
        }
        override
        public string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(getManufacterer() + "  ");
            sb.Append(getName() + "  ");
            sb.Append(getMSRP() + "  ");
            sb.Append(getQuantity() + "\r\n");

            return sb.ToString();
        }
    }
}
