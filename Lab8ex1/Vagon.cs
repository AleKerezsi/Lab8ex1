using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8ex1
{
    public class Vagon
    {
        private int Masa { get; set; }
        private int AnulFabricatiei { get; set; }

        public Vagon (int masa, int anulFabricatiei)
        {
            this.Masa = masa;
            this.AnulFabricatiei = anulFabricatiei;
        }
    }
}
