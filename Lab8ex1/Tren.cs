using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8ex1
{
    public class Tren
    {
        public string Nume { get; set; }

        private readonly Locomotiva Locomotiva;

        public int NrLocuri { get; private set; }

        private List<Vagon> ListaVagoane { get; set; } = new List<Vagon>();

        public Tren(Locomotiva locomotiva)
        {
            this.Locomotiva = locomotiva;
        }

        public void AdaugareVagon(Vagon vagon) 
        {
            ListaVagoane.Add(vagon);

            if (vagon is VagonClasaI)
            {
                var v = (VagonClasaI)vagon;

                NrLocuri = NrLocuri + v.GetNumarLocuri();

                return;
            }

            if (vagon is VagonPersoane) 
            {
                var v = (VagonPersoane)vagon;

                NrLocuri = NrLocuri + v.GetNumarLocuri();
            }

           
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

        public List<InfoMarfa> ObtineInformatiiMarfa() 
        {
            List<InfoMarfa> informatiiMarfa = new List<InfoMarfa>();

            int totalCapacitateCereale = 0;
            int totalCapacitateCarbuni = 0;
            int totalCapacitateOtel = 0;

            foreach (var vagon in ListaVagoane) 
            {
                if (vagon is VagonMarfa)
                {
                    var v = (VagonMarfa)vagon;

                    switch (v.TipulMarfii)
                    {
                        case TipMarfa.Cereale:
                            totalCapacitateCereale = totalCapacitateCereale + v.GetCapacitateInTone();
                            break;
                        case TipMarfa.Carbuni:
                            totalCapacitateCarbuni = totalCapacitateCarbuni + v.GetCapacitateInTone();
                            break;
                        case TipMarfa.Otel:
                            totalCapacitateOtel = totalCapacitateOtel + v.GetCapacitateInTone();
                            break;
                    }

                }
            }

            InfoMarfa infoCereale = new InfoMarfa() { TipMarfa = TipMarfa.Cereale, CapacitateTotala = totalCapacitateCereale};
            InfoMarfa infoCarbuni = new InfoMarfa() { TipMarfa = TipMarfa.Carbuni, CapacitateTotala = totalCapacitateCarbuni };
            InfoMarfa infoOtel  = new InfoMarfa() { TipMarfa = TipMarfa.Otel, CapacitateTotala = totalCapacitateOtel };

            informatiiMarfa.Add(infoCereale);
            informatiiMarfa.Add(infoCarbuni);
            informatiiMarfa.Add(infoOtel);

            return informatiiMarfa;
        }
    }
}
