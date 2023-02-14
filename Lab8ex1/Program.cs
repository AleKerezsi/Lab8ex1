using System;

namespace Lab8ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* • Un tren este compus din: o locomotiva si mai multe tipuri de vagoane.
                 Locomotiva va avea
                    - O metoda de pornire, la apelul careia, aceasta va confirma faptul ca a pornit printr-un mesaj afisat in consola, 
                    - O metoda de oprire, la apelul careia, aceasta va confirma faptul ca a oprit printr-un mesaj afisat in consola, 

                 Vagoanele vor avea masa si anul fabricatiei si vor fi de mai multe tipuri
                     - Vagoane de marfa, care vor avea
                     tipul marfii (cereale/carbuni/otel) precum si capacitatea in tone
                     - Vagoane pentru persoane, care vor avea
                     numar de locuri
                         O metoda care va inchide usile si va confirma in consola inchiderea usilor
                         O metoda care va deschide usile si va confirma in consola deschiderea usilor
                    - Vagoane clasa I, pentru persoane
                         O metoda de pornire a aerului conditionat care va afisa acest lucru pe ecran
                         O metoda de oprire a aerului conditionat care va afisa acest lucru pe ecran
                 Trenul va avea un nume precum si urmatoarele metode
                 Adauga vagon
                 Aceasta metoda va permite adaugarea vagoanelor la tren
                 Pleaca din gara
                 La aceasta comanda, trenul va inchide usile vagoanelor de persoane si va porni locomotiva
                 Opreste in gara
                 La aceasta comanda, trenul va opri locomotiva, va deschide usile vagoanelor de persoane si va opri aerul conditionat in vagoanele clasa 1
                Proiectati clasele, initializati un tren, adaugati-i vagoane si apelati metodele */

            Locomotiva locomotiva = new Locomotiva();

            Vagon vagon = new Vagon(5,1992);

            VagonMarfa vagonMarfa = new VagonMarfa(TipMarfa.Cereale,10,20,2013);
            VagonPersoane vagonPersoane = new VagonPersoane(80, 20, 2020);
            VagonClasaI vagonClasaI = new VagonClasaI(50,10,2007);

            Tren tren = new Tren(locomotiva);

            tren.AdaugareVagon(vagon);
            tren.AdaugareVagon(vagonMarfa);
            tren.AdaugareVagon(vagonPersoane);
            tren.AdaugareVagon(vagonClasaI);

            tren.PleacaDinGara();

            tren.OpresteInGara();



        }
    }
}
