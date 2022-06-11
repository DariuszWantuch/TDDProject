using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDProject.Model
{
    public class Franc
    {
        private int amount;

        public Franc(int amount)
        {
            this.amount = amount;
        }

        public void Multiplication(int multiplier)
        {
            amount *= multiplier;
        }

        public override bool Equals(object? obj)
        {
            Franc franc = (Franc)obj;

            return amount == franc.amount;
        }

        public int GetAmount()
        {
            return amount;
        }
    }
}
