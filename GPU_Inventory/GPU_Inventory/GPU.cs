using System.Collections.Generic;
using System.Text;

// Author: Christopher Finster
// CST-117 Milestone 3.  Inventory Manager
// Last updated: 10 Apr 2021

namespace GPU_Inventory 
{
    public class GPU : Item
    {
        public GPU()
        {
            this.setManufacterer("Default");
            this.setName("Default");
            this.setPrice(0.00);
            this.setCores(0);
            this.setClockSpeed(0);
            this.setMemorySize(0);
            this.setQuantity(0);
            gpuAsList = new List<string>();
        }

        public GPU(string manufacterer, string name, double price, int cores, int clockSpeed, int memorySize, int quantity )
        {
            this.setManufacterer(manufacterer);
            this.setName(name);
            this.setPrice(price);
            this.cores = cores;
            this.clockSpeed = clockSpeed;
            this.memorySize = memorySize;
            this.setQuantity(quantity);
            gpuAsList = new List<string>();

        }

        List<string> gpuAsList ;
        private int cores = 0;
        private int clockSpeed = 0;
        private int memorySize = 0;

        public int getCores()
        {
            return this.cores;
        }

        public void setCores(int cores)
        {
            this.cores = cores;
        }

        public double getClockSpeed()
        {
            return this.clockSpeed;
        }

        public void setClockSpeed(int clockSpeed)
        {
            this.clockSpeed = clockSpeed;
        }

        public int getMemorySize()
        {
            return this.memorySize;
        }

        public void setMemorySize(int memorySize)
        {
            this.memorySize = memorySize;
        }

        public List<string> gpuToList()
        {
            gpuAsList.Add(this.getManufacterer());
            gpuAsList.Add(this.getName());
            gpuAsList.Add(this.getPrice().ToString());
            gpuAsList.Add(this.getCores().ToString());
            gpuAsList.Add(this.getClockSpeed().ToString());
            gpuAsList.Add(this.getMemorySize().ToString());
            gpuAsList.Add(this.getQuantity().ToString());
            return gpuAsList;
        }

        override
        public string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(getManufacterer() + "  ");
            sb.Append(getName() + "  ");
            sb.Append(getPrice() + "  ");
            sb.Append(getCores() + "  ");
            sb.Append(getClockSpeed() + "  ");
            sb.Append(getMemorySize() + "  ");
            sb.Append(getQuantity() + "\r\n");

            return sb.ToString();
        }
    }
}
