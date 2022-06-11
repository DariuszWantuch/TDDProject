using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDProject.Model
{
    public class Dollar
    {
        public int amount;

        public Dollar(int amount)
        {
            this.amount = amount;
        }

        public void Multiplication(int multiplier)
        {
            amount *= multiplier;
        }

        public override bool Equals(object? obj)
        {
            Dollar dollar = (Dollar) obj;

            return amount == dollar.amount;
        }
    }
}
