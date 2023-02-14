using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8ex1
{
    public class Tren
    {
        public string Nume { get; set; }

        private readonly Locomotiva Locomotiva;

        List<Vagon> ListaVagoane { get; set; } = new List<Vagon>();

        public Tren(Locomotiva locomotiva)
        {
            this.Locomotiva = locomotiva;
        }

        public void AdaugareVagon(Vagon vagon) 
        {
            ListaVagoane.Add(vagon);
        }
        public void PleacaDinGara()
        {
            foreach(var vagon in ListaVagoane)
            {
                if (vagon is VagonPersoane)
                {
                    var v = (VagonPersoane)vagon;
                    v.InchideUsile(); 
                }

                if (vagon is VagonClasaI)
                {
                    var v = (VagonClasaI)vagon;
                    v.InchideUsile();
                    v.PornireAerConditionat();
                }
            }

            Locomotiva.Pornire();
        }

        public void OpresteInGara()
        {
            foreach (var vagon in ListaVagoane)
            {
                if (vagon is VagonPersoane)
                {
                    var v = (VagonPersoane)vagon;
                    v.DeschideUsile(); 
                }

                if (vagon is VagonClasaI)
                {
                    var v = (VagonClasaI)vagon;
                    v.DeschideUsile();
                    v.OprireAerConditionat();
                }
            }

            Locomotiva.Oprire();
        }
    }
}
