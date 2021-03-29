﻿using System.Text;

namespace GPU_Inventory 
{
    public class GPU : Item
    {
        public GPU()
        {

        }

        public GPU(string manufacterer, string name, double msrp, int cores, double clockSpeed, int memorySize, int quantity)
        {
            this.setManufacterer(manufacterer);
            this.setName(name);
            this.setMSRP(msrp);
            this.cores = cores;
            this.clockSpeed = clockSpeed;
            this.memorySize = memorySize;
            this.setQuantity(quantity);
        }

        private int cores = 0;
        private double clockSpeed = 0.00;
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

        public void setClockSpeed(double clockSpeed)
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

        override
        public string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(getManufacterer() + "  ");
            sb.Append(getName() + "  ");
            sb.Append(getMSRP() + "  ");
            sb.Append(getCores() + "  ");
            sb.Append(getClockSpeed() + "  ");
            sb.Append(getMemorySize() + "  ");
            sb.Append(getQuantity() + "\r\n");

            return sb.ToString();
        }
    }
}
