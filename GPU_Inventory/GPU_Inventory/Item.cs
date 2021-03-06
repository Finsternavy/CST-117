using System;
using System.Text;

// Author: Christopher Finster
// CST-117 Milestone 3.  Inventory Manager
// Last updated: 10 Apr 2021

namespace GPU_Inventory
{
    public class Item
    {
        public Item()
        {

        }

        public Item(string manufacturer, string name, double price, int quantity)
        {
            this.manufacturer = manufacturer;
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        private string manufacturer = "";
        private string name = "";
        private double price = 0.00;
        private int quantity = 0;

        public string getManufacturer()
        {
            return this.manufacturer;
        }

        public void setManufacturer(string manufacterer)
        {
            this.manufacturer = manufacterer;
        }

        public string getName()
        {
            return this.name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public double getPrice()
        {
            return this.price;
        }

        public void setPrice(double price)
        {
            this.price = price;
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

        override
        public string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(getManufacturer() + "  ");
            sb.Append(getName() + "  ");
            sb.Append(getPrice() + "  ");
            sb.Append(getQuantity() + "\r\n");

            return sb.ToString();
        }
    }
}
