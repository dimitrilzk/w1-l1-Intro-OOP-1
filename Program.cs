using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w1_l1_Intro_OOP_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CV cv1 = new CV();
            InformazioniPersonali InfoPersonali = new InformazioniPersonali()
            {
                Nome = "Mario",
                Cognome = "Rossi",
                Telefono = "3471536456",
                Email = "example@ex.com"
            };
            cv1.InfoPersonali = InfoPersonali;

            List<Studi> ListaDegliStudi = new List<Studi>();
            Studi Universita = new Studi()
            {
                Istituto = "Bocconi",
                Qualifica = "Sviluppatore",
                Dal = new DateTime(2015, 09, 01),
                Al = new DateTime(2020, 06, 05),
            };
            Studi Corso = new Studi()
            {
                Istituto = "Epicode School",
                Qualifica = "Full-stack Web Developer",
                Dal = new DateTime(2022, 09, 30),
                Al = new DateTime(2023, 02, 15),
            };
            ListaDegliStudi.Add(Universita);
            ListaDegliStudi.Add(Corso);
            cv1.StudiEffetuati = ListaDegliStudi;

            List<Impiego> EsperienzeLavorative = new List<Impiego>();
            Impiego Commerciale = new Impiego()
            {
                EsperienzeLavorative = new Esperienza()
                {
                    Azienda = "ABTG",
                    JobTitle = "Sales Manager",
                    Dal = new DateTime(2020, 02, 15),
                    Al = new DateTime(2021, 08, 10),
                    Descrizione = "Vendita corsi di formazione",
                    Compiti = "Raggiungimento di obiettivi minimi di fatturato annuo",
                }
            };
            Impiego Developer = new Impiego()
            {
                EsperienzeLavorative = new Esperienza()
                {
                    Azienda = "Microsoft",
                    JobTitle = "Back-end Developer",
                    Dal = new DateTime(2022, 02, 15),
                    Al = new DateTime(2025, 08, 10),
                    Descrizione = "Programmazione di oggetti",
                    Compiti = "Far andare avanti la Microsoft",
                }
            };
            EsperienzeLavorative.Add(Commerciale);
            EsperienzeLavorative.Add(Developer);
            cv1.Impieghi = EsperienzeLavorative;
            cv1.StampaCvCandidato(cv1);



        }
    }
}
