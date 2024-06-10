using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Product
    {
        private int _price;
        public int Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Value must be greater than or equal to 0.");
                }
                _price = value;
            }
        }

        public int Stock { get; private set; }

    }
}
