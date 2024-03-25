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
        public int nrActivitate { get; set; } 


        public Activitate(string nume, string descriere, string tip, DateTime dataOra) //Constructor cu parametri
        {
            Nume = nume;
            Descriere = descriere;
            Tip = tip;
            DataOra = dataOra;
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
