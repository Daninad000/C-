using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuvar
{
    public class Fuvar
    {
        int taxiAzonosito;
        string indulásIdo;
        int utazasIdo;
        double megtettTav;
        double vitelDij;
        double borravalo;
        string fizetesMod;

        public Fuvar(int taxiAzonosito, string indulásIdo, int utazasIdo, double megtettTav, double vitelDij, double borravalo, string fizetesMod)
        {
            this.TaxiAzonosito = taxiAzonosito;
            this.IndulásIdo = indulásIdo;
            this.UtazasIdo = utazasIdo;
            this.MegtettTav = megtettTav;
            this.VitelDij = vitelDij;
            this.Borravalo = borravalo;
            this.FizetesMod = fizetesMod;
        }

        public int TaxiAzonosito { get => taxiAzonosito; set => taxiAzonosito = value; }
        public string IndulásIdo { get => indulásIdo; set => indulásIdo = value; }
        public int UtazasIdo { get => utazasIdo; set => utazasIdo = value; }
        public double MegtettTav { get => megtettTav; set => megtettTav = value; }
        public double VitelDij { get => vitelDij; set => vitelDij = value; }
        public double Borravalo { get => borravalo; set => borravalo = value; }
        public string FizetesMod { get => fizetesMod; set => fizetesMod = value; }
    }
}
