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
        private string currency;

        public Franc(int amount, string currency)
        {
            this.amount = amount;
            this.currency = currency;
        }

        public void Multiplication(int multiplier)
        {
            amount *= multiplier;
        }

        public int GetAmount()
        {
            return amount;
        }

        public override string Currency()
        {
            return currency;
        }
    }
}
