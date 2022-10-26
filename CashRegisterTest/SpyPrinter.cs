using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CashRegister;

namespace CashRegisterTest
{
    public class SpyPrinter : Printer
    {
        public bool HasPrintered { get; set; }

        public override void Print(string content)
        {
            base.Print(content);
            HasPrintered = true;
        }
    }
}
