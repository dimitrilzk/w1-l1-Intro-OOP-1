using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w1_l1_Intro_OOP_1
{
    internal class CV
    {
        public InformazioniPersonali InfoPersonali { get; set; }
        public List<Studi> StudiEffetuati { get; set; }
        public List<Impiego> Impieghi { get; set; }
        public void StampaCvCandidato(CV cv1)
        {
            Console.WriteLine($"CV di {cv1.InfoPersonali.Cognome} {cv1.InfoPersonali.Nome}");
            Console.WriteLine("");
            Console.WriteLine("++++ INIZIO Informazioni Personali: ++++");
            Console.WriteLine($"Nome: {cv1.InfoPersonali.Nome}");
            Console.WriteLine($"Cognome: {cv1.InfoPersonali.Cognome}");
            Console.WriteLine($"Email: {cv1.InfoPersonali.Email}");
            Console.WriteLine($"Telefono: {cv1.InfoPersonali.Telefono}");
            Console.WriteLine("++++ FINE Informazioni Personali: ++++");
            Console.WriteLine("");

            Console.WriteLine("++++ INIZIO Studi e Formazione: ++++");
            foreach (Studi studio in cv1.StudiEffetuati)
            {
                Console.WriteLine($"Istituto: {studio.Istituto}");
                Console.WriteLine($"Qualifica: {studio.Qualifica}");
                Console.WriteLine($"Tipo: {studio.Tipo}");
                Console.WriteLine($"Dal {studio.Dal} al {studio.Al}");
                Console.WriteLine("");
            }
            Console.WriteLine("++++ FINE Studi e Formazione: ++++");
            Console.WriteLine("");

            Console.WriteLine("++++ INIZIO Esperienze professionali: ++++");
            foreach (Impiego impiego in cv1.Impieghi)
            {
                Console.WriteLine($"Presso: {impiego.EsperienzeLavorative.Azienda}");
                Console.WriteLine($"Tipo di lavoro: {impiego.EsperienzeLavorative.JobTitle}");
                Console.WriteLine($"Compito: {impiego.EsperienzeLavorative.Compiti}");
                Console.WriteLine($"Dal: {impiego.EsperienzeLavorative.Dal} al {impiego.EsperienzeLavorative.Al}");
                Console.WriteLine("");
            }
            Console.WriteLine("++++ FINE Esperienze professionali: ++++");
            Console.WriteLine("");



            Console.ReadLine();
        }

    }
    internal class InformazioniPersonali
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

    }
    internal class Studi
    {
        public string Qualifica { get; set; }
        public string Istituto { get; set; }
        public string Tipo { get; set; }
        public DateTime Dal { get; set; }
        public DateTime Al { get; set; }
    }
    internal class Esperienza
    {
        public string Azienda { get; set; }
        public string JobTitle { get; set; }
        public DateTime Dal { get; set; }
        public DateTime Al { get; set; }
        public string Descrizione { get; set; }
        public string Compiti { get; set; }

    }
    internal class Impiego
    {
        public Esperienza EsperienzeLavorative;
    }
}

    
