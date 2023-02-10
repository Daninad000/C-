using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
//using Fuvar;

namespace FuvarGUI
{
     
    public partial class Form1 : Form
    {
        private static List<Fuvar.Fuvar> fuvarok = new List<Fuvar.Fuvar>();
        private static int taxiId;
        public Form1()
        {
            InitializeComponent();
            fajlbeolvas();


            
        }

        // private static List<string> sorElemList = new List<string>();

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                taxiId = int.Parse(textBoxTaxiId.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Kérlek csak számot adj meg.");
                // MessageBox.Show(hiba.Message);
                // throw;
            }

            Fuvarok.Items.Clear();

            for (int i = 0; i < fuvarok.Count; i++)
            {
                if (taxiId == fuvarok[i].TaxiAzonosito)
                {
                    Fuvarok.Items.Add("Fuvar azonosítója: " + fuvarok[i].TaxiAzonosito.ToString());
                    Fuvarok.Items.Add("Indulás idő: " + fuvarok[i].IndulásIdo.ToString());
                    Fuvarok.Items.Add("Utazás idő: " + fuvarok[i].UtazasIdo.ToString());
                    Fuvarok.Items.Add("Megtett táv: " + fuvarok[i].MegtettTav.ToString());
                    Fuvarok.Items.Add("Viteldíj: " + fuvarok[i].VitelDij.ToString());
                    Fuvarok.Items.Add("Borravaló: " + fuvarok[i].Borravalo.ToString());
                    Fuvarok.Items.Add("Fizetés módja: " + fuvarok[i].FizetesMod.ToString());
                }
            }
        }



        private static void fajlbeolvas()
        {
            StreamReader beolvas = new StreamReader(@"fuvar.csv");
            var fejlec = beolvas.ReadLine();
            beolvas.ReadLine();
            while (!beolvas.EndOfStream)
            {
                string sor = beolvas.ReadLine();
                string[] sorElem = sor.Split(';');
                fuvarok.Add(new Fuvar.Fuvar(int.Parse(sorElem[0]), sorElem[1], int.Parse(sorElem[2]), double.Parse(sorElem[3]), double.Parse(sorElem[4]), double.Parse(sorElem[5]), sorElem[6]));
            }
        }

        private void textBoxTaxiId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    taxiId = int.Parse(textBoxTaxiId.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Kérlek csak számot adj meg.");
                    // MessageBox.Show(hiba.Message);
                    // throw;
                }

                Fuvarok.Items.Clear();

                for (int i = 0; i < fuvarok.Count; i++)
                {
                    if (taxiId == fuvarok[i].TaxiAzonosito)
                    {
                        Fuvarok.Items.Add("Fuvar azonosítója: " + fuvarok[i].TaxiAzonosito.ToString());
                        Fuvarok.Items.Add("Indulás idő: " + fuvarok[i].IndulásIdo.ToString());
                        Fuvarok.Items.Add("Utazás idő: " + fuvarok[i].UtazasIdo.ToString());
                        Fuvarok.Items.Add("Megtett táv: " + fuvarok[i].MegtettTav.ToString());
                        Fuvarok.Items.Add("Viteldíj: " + fuvarok[i].VitelDij.ToString());
                        Fuvarok.Items.Add("Borravaló: " + fuvarok[i].Borravalo.ToString());
                        Fuvarok.Items.Add("Fizetés módja: " + fuvarok[i].FizetesMod.ToString());
                    }
                }
            }
        }
    }
}
