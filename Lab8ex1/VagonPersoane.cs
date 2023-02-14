using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8ex1
{
   public class VagonPersoane : Vagon
    {
        private int NumarDeLocuri { get; set; }
        public VagonPersoane(int numarDeLocuri ,int masa, int anulFabricatiei): base(masa, anulFabricatiei)
        {
            this.NumarDeLocuri = numarDeLocuri;
        }

        public int GetNumarLocuri() 
        {
            return NumarDeLocuri;
        }

        public void InchideUsile()
        {
            Console.WriteLine("Usile s-au inchis");
        }

        public void DeschideUsile()
        {
            Console.WriteLine("Usile s-au deschis");
        }
    }
}
