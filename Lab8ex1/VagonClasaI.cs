using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8ex1
{
    public class VagonClasaI : VagonPersoane
    {
        public VagonClasaI(int numarDeLocuri, int masa, int anulFabricatiei) : base( numarDeLocuri,  masa,  anulFabricatiei)
        {

        }

        public void PornireAerConditionat()
        {
            Console.WriteLine("Aerul conditionat s-a pornit");
        }

        public void OprireAerConditionat()
        {
            Console.WriteLine("Aerul conditionat s-a oprit");
        }
    }
}
