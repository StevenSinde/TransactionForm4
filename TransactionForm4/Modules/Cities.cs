using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionForm4
{
    class Cities
    {
        public string City { get; set; }

        public string DisplayCity
        {
            get
            {
                return $"{City}";
            }
        }

    }
}
