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
        public List<GPU> gpuInventory;
        public List<string> gpuAsList;
        public List<int> currentSearchIndexes = new List<int>();

        private int maxStock = 50;

        public InventoryManager(List<GPU> gpuArray, List<string> gpuAsList)
        {
            gpuInventory = gpuArray;
            this.gpuAsList = gpuAsList;
            initializeGPUInventory();
        }

        private void initializeGPUInventory()
        {
            gpuInventory.Add(new GPU("ASUS", "RTX 2080 ti", 999.99, 1500, 2500, 11, 10));
            gpuInventory.Add(new GPU("MSI", "RTX 3080", 1599.99, 1800, 2700, 23, 1));
            gpuInventory.Add(new GPU("Nvidia", "GTX 1080", 699.99, 1200, 1800, 6, 50));
        }

        public void delete(int index)
        {
            this.gpuInventory.RemoveAt(index);
        }

        public void add(GPU gpu)
        {
            this.gpuInventory.Add(gpu);
        }

        public void update(GPU gpu)
        {
            this.gpuInventory.Remove(gpu);
            this.gpuInventory.Add(gpu);
        }

        public void restockItem(int index)
        {
            this.gpuInventory[index].setQuantity(maxStock);
        }

        public void restockAllItems()
        {
            foreach (GPU gpu in this.gpuInventory)
            {
                gpu.setQuantity(maxStock);
            }
        }

        public List<int> displayInventory()
        {
            return currentSearchIndexes;
        }

        public void search(string search, string filter)
        {
            currentSearchIndexes.Clear();

            // switch the filter.  Search by filter selected by user or default to "All"
            switch (filter)
            {
                // for comments on each statement, see case "All".  They all do the same thing just change the search method used
                case "All":

                    searchAll(search);
                    break;

                case "Manufacterer":

                    searchManufacterer(search);
                    break;

                case "Name":

                    searchName(search);
                    break;

                case "Price":

                    searchPrice(search);
                    break;

                case "Cores":

                    searchCores(search);
                    break;

                case "Clock Speed":

                    searchClockSpeed(search);
                    break;

                case "Memory Size":

                    searchMemorySize(search);
                    break;

                case "# In Stock":

                    searchQuantity(search);
                    break;

                default:

                    // create list of items that contain what the user searched for
                    searchAll(search);
                    break;
            }
        }

        private void searchManufacterer(string manufacturer)
        {
            currentSearchIndexes.Clear();

            for(int i = 0; i < this.gpuInventory.Count; i++)
            {
                manufacterEquals(i, manufacturer);
            }
        }

        private void manufacterEquals(int index, string manufacterer)
        {
            if (manufacterer.ToLower().Equals(this.gpuInventory[index].getManufacturer().ToLower()))
                currentSearchIndexes.Add(index);
        }

        private void searchName(string name)
        {
            currentSearchIndexes.Clear();

            for (int i = 0; i < this.gpuInventory.Count; i++)
            {
                nameEquals(i, name);
            }
        }

        private void nameEquals(int index, string name)
        {
            if (name.Equals(this.gpuInventory[index].getName().ToLower()))
            
                currentSearchIndexes.Add(index);
        }

        private void searchPrice(string price)
        {
            currentSearchIndexes.Clear();

            for (int i = 0; i < this.gpuInventory.Count; i++)
            {
                priceEquals(i, price);
            }
        }

        private void priceEquals(int index, string price)
        {
            
            if (price.ToString().Equals(this.gpuInventory[index].getPrice().ToString()))
            {
                currentSearchIndexes.Add(index);
            }
        }

        private void searchCores(string cores)
        {
            currentSearchIndexes.Clear();

            for (int i = 0; i < this.gpuInventory.Count; i++)
            {
                coresEquals(i, cores);
            }
        }

        private void coresEquals(int index, string cores)
        {
            
            if (cores.ToString().Equals(this.gpuInventory[index].getCores().ToString()))
            {
                currentSearchIndexes.Add(index);
            }
        }

        private void searchClockSpeed(string clockSpeed)
        {
            currentSearchIndexes.Clear();

            for (int i = 0; i < this.gpuInventory.Count; i++)
            {
                clockSpeedEquals(i, clockSpeed);
            }
        }

        private void clockSpeedEquals(int index, string clockSpeed)
        {
            
            if (clockSpeed.ToString().Equals(this.gpuInventory[index].getClockSpeed().ToString()))
            {
                currentSearchIndexes.Add(index);
            }
        }

        private void searchMemorySize(string memorySize)
        {
            currentSearchIndexes.Clear();

            for (int i = 0; i < this.gpuInventory.Count; i++)
            {
                memorySizeEquals(i, memorySize);
            }
        }

        private void memorySizeEquals(int index, string memorySize)
        {
            if (memorySize.ToString().Equals(this.gpuInventory[index].getMemorySize().ToString()))
            {
                currentSearchIndexes.Add(index);
            }
        }

        private void searchQuantity(string quantity)
        {
            currentSearchIndexes.Clear();

            for (int i = 0; i < this.gpuInventory.Count; i++)
            {
                quantityEquals(i, quantity);
            }
        }

        private void quantityEquals(int index, string quantity)
        {
            if (quantity.ToString().Equals(this.gpuInventory[index].getQuantity().ToString()))
            {
                currentSearchIndexes.Add(index);
            }
        }

        private void searchAll(string search)
        {
            // create list of items that contain what the user searched for
            for (int i = 0; i < this.gpuInventory.Count; i++)
            {
                checkThisInstance(i, search);
            }
        }

        private void checkThisInstance(int index, string search)
        {
            if (search.ToLower().Equals(this.gpuInventory[index].getManufacturer().ToLower()) ||
                search.ToLower().Equals(this.gpuInventory[index].getName().ToLower()) ||
                search.ToLower().Equals(this.gpuInventory[index].getPrice().ToString()) ||
                search.ToLower().Equals(this.gpuInventory[index].getCores().ToString()) ||
                search.ToLower().Equals(this.gpuInventory[index].getClockSpeed().ToString()) ||
                search.ToLower().Equals(this.gpuInventory[index].getMemorySize().ToString()) ||
                search.ToLower().Equals(this.gpuInventory[index].getQuantity().ToString()))
            {
                currentSearchIndexes.Add(index);
            }
        }
    }
}
