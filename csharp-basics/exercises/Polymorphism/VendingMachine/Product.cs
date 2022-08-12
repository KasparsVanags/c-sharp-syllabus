using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public struct Product
    {
        ///<summary>Gets or sets the available amount of product.</summary>
        public int Available { get; set; }
        ///<summary>Gets or sets the product price.</summary>
        public Money Price { get; set; }
        ///<summary>Gets or sets the product name.</summary>
        public string Name { get; set; }

        public Product(string name, Money price, int count)
        {
            Name = name;
            Price = price;
            Available = count;
        }

        public override string ToString()
        {
            return $"{Name} - {Price} | {Available} left";
        }
    }
}
