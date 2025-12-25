using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    public class Clothing : Product
    {
        public string Size { get; set; }
        public string Material { get; set; }

        public Clothing(string name, decimal price, string size, string material) : base(name, price)
        {
            Size = size;
            Material = material;
        }

        public override string GetProductDetails()
        {
            return $"Clothing Product : {Name}, Price : {Price}, Size : {Size}, Material : {Material}";
        }
    }
}
