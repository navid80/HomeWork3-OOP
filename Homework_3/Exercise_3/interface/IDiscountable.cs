using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    public interface IDiscountable
    {
        abstract decimal Discount { get; set; }
        public void ApplyDiscount(decimal discountPercent);
    }
}
