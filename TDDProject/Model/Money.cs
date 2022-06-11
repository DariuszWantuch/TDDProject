using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDProject.Model
{
    public abstract class Money 
    {
        protected int amount;

        public override bool Equals(object? obj)
        {
            Money money = (Money)obj;

            return amount == money.amount;
        }

        public abstract string Currency();
    }
}


