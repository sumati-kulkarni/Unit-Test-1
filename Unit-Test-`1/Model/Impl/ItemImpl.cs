using System;
using System.Collections.Generic;
using System.Text;
using Unit_Test__1.Model;

namespace Unit_Test__1.Model.Impl
{
    public class ItemImpl : Item
    {
        #region Fields
        /// <summary>
        /// 
        /// </summary>
        public int IdNumber
        {
            get => idNumber;
            set => idNumber = value;
        }
        private int idNumber;

        /// <summary>
        /// 
        /// </summary>
        public string Description
        {
            get => description;
            set => description = value;
        }
        private string description;

        /// <summary>
        /// 
        /// </summary>
        public UnitOfMeasure Uom
        {
            get => uom;
            set => uom = value;
        }
        private UnitOfMeasure uom;

        /// <summary>
        /// 
        /// </summary>
        public int Weight
        {
            get => weight;
            set => weight = value;
        }
        private int weight;
        #endregion

        #region methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_idNumber"></param>
        /// <param name="_description"></param>
        /// <param name="_uom"></param>
        /// <param name="_weight"></param>
        public ItemImpl(
            int _idNumber, 
            string _description, 
            UnitOfMeasure _uom, 
            int _weight)
        {
            idNumber = _idNumber;
            description = _description;
            uom = _uom;
            weight = _weight;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(description);
            sb.Append("(" + idNumber + "): ");
            sb.Append(weight + " " + uom);
            if ((uom == UnitOfMeasure.POUND || uom == UnitOfMeasure.GALLON)
                && weight > 1)
            {
                sb.Append("S");
            }
            return sb.ToString();
        }
        #endregion
    }
}
