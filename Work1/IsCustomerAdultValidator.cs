using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work1
{
    public class IsCustomerAdultValidator : ICustomerValidator
    {
        private const int AdultAge = 18;
        public bool Validate(ICustomer customer)
        {
            if (customer == null) throw new ArgumentNullException();

            bool isAdult = customer.GetAge() >= AdultAge;

            return isAdult;
        }
    }
}
