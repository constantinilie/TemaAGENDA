using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    internal class Activitate   // Am creeat clasa- TEMA LAB 2
    {
        public string Nume { get; set; } // Numele activitatii
        public string Descriere { get; set; } // Descrierea activitatii
        public string Tip { get; set; } // Tipul activitatii (ex: Scoala, munca, recreere)
        public DateTime DataOra { get; set; } // data si ora
        public string[] Optiuni { get; set; }// Optiuni (ex: Notificari, Repetare, Alarme)

        public int nrActivitate { get; set; } 


        public enum TipActivitate // TEMA LAB 5 1.a
        {
                Scoala=1,
                Facultate=2,
                Serviciu=3,
                Recreere=4,
                Reminder=5
        };

        [Flags]
        public enum OptiuniActivitate // TEMA LAB 5 1.b
        {
            Fara = 0,
            Notificari = 1,
            Repetare = 2,
            Alarme = 4
            
        };
        public Activitate(string nume, string descriere, string tip, DateTime dataOra, string[] optiuni) //Constructor cu parametri
        {
            Nume = nume;
            Descriere = descriere;
            Tip = tip;
            DataOra = dataOra;
            Optiuni = optiuni;
        }
        public Activitate() //Constructor fara parametri
        {
            Nume = Descriere = Tip = string.Empty;
            
        }

        public string InfoActivitate()
        {
            string info = $"Nume:{Nume ?? "NECUNOSCUT"}\nDescriere:{Descriere ?? "NECUNOSCUT"}\nTip:{Tip ?? "NECUNOSCUT"}\nData si ora:{DataOra}\n";
            return info;
        }
        


    }
}
