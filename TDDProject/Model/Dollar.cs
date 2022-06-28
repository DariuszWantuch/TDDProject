using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TDDProject.Model
{
    public class Dollar : Money
    {
        private int amount;
        private string currency;

        public Dollar(int amount, string currency = "")
        {
            this.amount = amount;
            this.currency = currency;
        }

        public override void Reduce(int reduceAmount)
        {
            this.amount -= reduceAmount;
        }

        public override string Currency()
        {
            return currency;
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

        public void Multiplication(int multiplier)
        {
            amount *= multiplier;
        }

        public override bool Equals(object? obj)
        {
            Dollar money = (Dollar)obj;

            return amount == money.amount;
        }


        public int GetAmount()
        {
            return amount;
        }

      
    }
}
