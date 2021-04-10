using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

// Author: Christopher Finster
// CST-117 Milestone 3.  Inventory Manager
// Orginal date: 6 Apr 2021
// Last updated: 10 Apr 2021

namespace GPU_Inventory
{
    public class InventoryManager
    {
        public InventoryManager(int maxItems)
        {
            gpuInventory = new GPU[maxItems];
            initializeGPUInventory();
        }

        public InventoryManager()
        {
            gpuInventory = new GPU[0];
        }

        public GPU[] gpuInventory;
        public List<int> currentSearchIndexes = new List<int>();
        int maxStock = 50;

        int count = 0;
        int newIndex = 0;
        private void initializeGPUInventory()
        {
            gpuInventory.SetValue(new GPU("ASUS", "RTX 2080 ti", 999.99, 1500, 2500, 11, 10), 0);
            gpuInventory.SetValue(new GPU("MSI", "RTX 3080", 1599.99, 1800, 2700, 23, 1), 1);
            gpuInventory.SetValue(new GPU("Nvidia", "GTX 1080", 699.99, 1200, 1800, 6, 50), 2);
        }

        public void delete(int index)
        {
            newIndex = 0;
            count = this.gpuInventory.Length - 1;
            GPU[] temp;

            if (count >= 0)
            {
                temp = new GPU[count];
            }
            else
            {
                Console.WriteLine("GPU Inventory array is empty");
                return;
            }
            
            this.gpuInventory[index].setName("delete");

            for(int i = 0; i < this.gpuInventory.Length; i++)
            {
                if (!this.gpuInventory[i].getName().Equals("delete"))
                {
                    temp.SetValue(this.gpuInventory[i], newIndex);
                    newIndex++;
                }
            }

            this.gpuInventory = temp;
        }

        public void add(GPU gpu)
        {
            count = this.gpuInventory.Length + 1;
            GPU[] temp = new GPU[count];
            Array.Copy(this.gpuInventory, temp, this.gpuInventory.Length);
            temp.SetValue(gpu, temp.Length - 1);
            this.gpuInventory = temp;
            Console.WriteLine(this.ToString());
        }

        public void update(GPU gpu, int index)
        {
            this.gpuInventory.SetValue(gpu, index);
        }
        
        public string toString(GPU[] arrayToPrint)
        {
            StringBuilder sb = new StringBuilder();

            foreach (GPU gpu in arrayToPrint)
            {
                sb.Append(gpu.ToString());
            }

            return sb.ToString();
        }

        public void searchManufacterer(string manufacturer)
        {
            currentSearchIndexes.Clear();

            for(int i = 0; i < this.gpuInventory.Length; i++)
            {
                if (this.gpuInventory[i].getManufacterer().ToLower().Equals(manufacturer.ToLower()))
                {
                    currentSearchIndexes.Add(i);
                }
            }
        }

        public void searchName(string name)
        {
            currentSearchIndexes.Clear();

            for (int i = 0; i < this.gpuInventory.Length; i++)
            {
                if (this.gpuInventory[i].getName().ToLower().Equals(name.ToLower()))
                {
                    currentSearchIndexes.Add(i);
                }
            }
        }

        public void searchPrice(string price)
        {
            currentSearchIndexes.Clear();

            for (int i = 0; i < this.gpuInventory.Length; i++)
            {
                if (this.gpuInventory[i].getPrice().ToString().Equals(price))
                {
                    currentSearchIndexes.Add(i);
                }
            }
        }

        public void searchCores(string cores)
        {
            currentSearchIndexes.Clear();

            for (int i = 0; i < this.gpuInventory.Length; i++)
            {
                if (this.gpuInventory[i].getCores().ToString().Equals(cores))
                {
                    currentSearchIndexes.Add(i);
                }
            }
        }

        public void searchClockSpeed(string clockSpeed)
        {
            currentSearchIndexes.Clear();

            for (int i = 0; i < this.gpuInventory.Length; i++)
            {
                if (this.gpuInventory[i].getClockSpeed().ToString().Equals(clockSpeed))
                {
                    currentSearchIndexes.Add(i);
                }
            }
        }

        public void searchMemorySize(string memorySize)
        {
            currentSearchIndexes.Clear();

            for (int i = 0; i < this.gpuInventory.Length; i++)
            {
                if (this.gpuInventory[i].getMemorySize().ToString().Equals(memorySize))
                {
                    currentSearchIndexes.Add(i);
                }
            }
        }

        public void searchQuantity(string quantity)
        {
            currentSearchIndexes.Clear();

            for (int i = 0; i < this.gpuInventory.Length; i++)
            {
                if (this.gpuInventory[i].getQuantity().ToString().Equals(quantity))
                {
                    currentSearchIndexes.Add(i);
                }
            }
        }

        public void search(string search)
        {
            currentSearchIndexes.Clear();

            for(int i = 0; i < this.gpuInventory.Length; i++)
            {
                if (this.gpuInventory[i].getManufacterer().ToLower().Equals(search.ToLower()) ||
                    this.gpuInventory[i].getName().ToLower().Equals(search.ToLower()) ||
                    this.gpuInventory[i].getPrice().ToString().Equals(search) ||
                    this.gpuInventory[i].getCores().ToString().Equals(search) ||
                    this.gpuInventory[i].getClockSpeed().ToString().Equals(search) ||
                    this.gpuInventory[i].getMemorySize().ToString().Equals(search) ||
                    this.gpuInventory[i].getQuantity().ToString().Equals(search))
                {
                    currentSearchIndexes.Add(i);
                }
            }
        }

        public void restockItem(int index)
        {
            this.gpuInventory[index].setQuantity(maxStock);
        }

        public void restockAllItems()
        {
            foreach(GPU gpu in this.gpuInventory)
            {
                gpu.setQuantity(maxStock);
            }
        }

        public List<int> displayInventory()
        {

            return currentSearchIndexes;
        }
    }
}
