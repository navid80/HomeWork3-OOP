using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    public class Electronic : Product, IDiscountable
    {
        public int WarrantyPeriod { get; set; }
        public decimal Discount { get; set; }

        public Electronic(string name, decimal price, int warrantyPeriod) : base(name, price)
        {
            WarrantyPeriod = warrantyPeriod;    
        }

        public void ApplyDiscount(decimal discountPercent)
        {
            Discount = discountPercent;
        }

        public override string GetProductDetails()
        {
            return $"Electronic Product : {Name}, Price : {Price}, FinalPrice : {Price * (100 - Discount) / 100}, Discount : {Discount}%, WarrantyPeriod : {WarrantyPeriod} Month";
        }
    }
}
