using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Avtobus
    {
        public string ime { get; set; }
        public string registracija { get; set; }
        public bool lokalen { get; set; }
        public List<Destinacija> destinacii;

        public Avtobus() {
            destinacii = new List<Destinacija>();
        }

        public Avtobus(string ime, string registracija, bool lokalen) {
            this.ime = ime;
            this.registracija = registracija;
            this.lokalen = lokalen;
            destinacii = new List<Destinacija>();
        }

        public void addDestinacija(Destinacija dest) {
            destinacii.Add(dest);
        }

        public override string ToString()
        {
            string ll="";
            if (lokalen) ll = ", L";
            return string.Format("{0} - {1}{2}", ime, registracija, ll);
        }
    }
}
