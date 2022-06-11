using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDProject.Model
{
    public class Franc : Money
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

        public int GetAmount()
        {
            return amount;
        }
    }
}
