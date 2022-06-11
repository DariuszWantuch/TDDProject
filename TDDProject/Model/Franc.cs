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

        public Franc(int amount, string currency = "")
        {
            this.amount = amount;
            this.currency = currency;
        }

        public override string Currency()
        {
            return currency;
        }

        public void Multiplication(int multiplier)
        {
            amount *= multiplier;
        }

        public override int Plus(int amountAdd)
        {
            this.amount += amountAdd;

            return this.amount;
        }

        public override string ToString()
        {
            return this.amount + " " + this.currency;
        }

        public int GetAmount()
        {
            return amount;
        }

        
    }
}
