using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8ex1
{
    public class VagonMarfa : Vagon
    {
        public TipMarfa TipulMarfii { get; set; }

        private int CapacitateInTone { get; set; }

        public VagonMarfa(TipMarfa tipulMarfii, int capacitateInTone, int masa, int anulFabricatiei): base( masa,  anulFabricatiei)
        {
            this.TipulMarfii = tipulMarfii;
            this.CapacitateInTone = capacitateInTone;
        }

    }
}
