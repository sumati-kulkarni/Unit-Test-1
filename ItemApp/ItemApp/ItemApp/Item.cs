using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemApp
{
    public class Item
    {
        private int itemNo;
        private string description;
        private string unitOfMeasure;
        private double weight;

        public Item(int itemNo, string description, string unitOfMeasure, double weight)
        {
            this.itemNo = itemNo;
            this.description = description;
            this.unitOfMeasure = unitOfMeasure;
            this.weight = weight;
        }

        public int GetItemNo()
        {
            return itemNo;
        }

        public string GetDescription()
        {
            return description;
        }

        public string GetUnitOfMEasure()
        {
            return unitOfMeasure;
        }

        public double GetWeight()
        {
            return weight;
        }

        public void setItemNo(int itemNo)
        {
            this.itemNo = itemNo;
        }

        public void setDescription(string description)
        {
            this.description = description;
        }

        public void setUnitOfMeasure(string unitOfMeasure)
        {
            this.unitOfMeasure = unitOfMeasure;
        }
        public void setWeight(double weight)
        {
            this.weight = weight;
        }

    }
}
