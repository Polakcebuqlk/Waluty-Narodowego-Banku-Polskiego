using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Waluty
{

    public partial class Form1 : Form
    {
        static class plik
        {
            public static string nazwaPlik;
            public static string SciezkaXML;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Zrodlo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Zrodlo.LinkVisited = true;
            System.Diagnostics.Process.Start("https://nbp.pl/statystyka-i-sprawozdawczosc/kursy/instrukcja-pobierania-kursow-walut/");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            wybieraniewaluty.Items.Clear();
            int dzien = WybieranieDatyPliku.Value.Day;
            int miesiac = WybieranieDatyPliku.Value.Month;
            int rok = WybieranieDatyPliku.Value.Year;
            string CzlonPliku = "";

            if (dzien < 10 || miesiac < 10)
            {
                string ZDien = "";
                string ZMiesiac = "";
                if (dzien < 10)
                {
                    ZDien = Convert.ToString($"0{dzien}");
                }
                else
                {
                    ZDien = Convert.ToString($"{dzien}");
                }
                if (miesiac < 10)
                {
                    ZMiesiac = Convert.ToString($"0{miesiac}");
                }
                else
                {
                    ZMiesiac = Convert.ToString($"{miesiac}");
                }
                CzlonPliku = $"{rok - 2000}{ZMiesiac}{ZDien}";
            }
            else
            {
                CzlonPliku = $"{rok - 2000}{miesiac}{dzien}";
            }

            WebClient client = new WebClient();
            Stream stream = client.OpenRead("https://static.nbp.pl/dane/kursy/xml/dir.txt");
            StreamReader reader = new StreamReader(stream);

            string line;

            while ((line = reader.ReadLine()) != null)
            {
                if (line.Contains("c"))
                {
                    if (line.Contains($"{CzlonPliku}"))
                    {
                        plik.nazwaPlik = line;
                        plik.SciezkaXML = $"https://static.nbp.pl//dane/kursy/xml/{plik.nazwaPlik}.xml";

                        XmlDocument xmlDocument = new XmlDocument();
                        xmlDocument.Load(plik.SciezkaXML);
                        XmlNode root = xmlDocument.DocumentElement;

                        wybieraniewaluty.Items.Clear();

                        foreach (XmlNode pozycjaNode in root.SelectNodes("pozycja"))
                        {
                            string nazwaWaluty = pozycjaNode.SelectSingleNode("nazwa_waluty")?.InnerText;
                            wybieraniewaluty.Items.Add(nazwaWaluty);
                        }
                    }
                    else
                    {
                        NazwaText.Text = $"Nazwa waluty: ";
                        PrzelicznikText.Text = $"Przelicznik: ";
                        KodText.Text = $"Kod waluty: ";
                        KursKupText.Text = $"Kurs kupna: ";
                        KursSprzText.Text = $"Kurs sprzedaży: ";
                    }
                }
            }
        }

        void Informacje()
        {
            if (wybieraniewaluty.SelectedIndex >= 0)
            {
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(plik.SciezkaXML);
                XmlNode root = xmlDocument.DocumentElement;
                string nazwaWaluty = wybieraniewaluty.SelectedItem.ToString();

                foreach (XmlNode pozycjaNode in root.SelectNodes("pozycja"))
                {
                    string nazwa = pozycjaNode.SelectSingleNode("nazwa_waluty")?.InnerText;
                    if (nazwa == nazwaWaluty)
                    {
                        string przelicznik = pozycjaNode.SelectSingleNode("przelicznik")?.InnerText;
                        string kodWaluty = pozycjaNode.SelectSingleNode("kod_waluty")?.InnerText;
                        string kursKupna = pozycjaNode.SelectSingleNode("kurs_kupna")?.InnerText;
                        string kursSprzedazy = pozycjaNode.SelectSingleNode("kurs_sprzedazy")?.InnerText;

                        NazwaText.Text = $"Nazwa waluty: {nazwaWaluty}";
                        PrzelicznikText.Text = $"Przelicznik: {przelicznik}";
                        KodText.Text = $"Kod waluty: {kodWaluty}";
                        KursKupText.Text = $"Kurs kupna: {kursKupna}";
                        KursSprzText.Text = $"Kurs sprzedaży: {kursSprzedazy}";
                    }
                }
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void otwórzToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form NoweOkno = new Form1();
            NoweOkno.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ustawieniaToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
        }

        private void ustawieniaToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
        }

        public void wybieraniewaluty_SelectedIndexChanged(object sender, EventArgs e)
        {
            Informacje();
        }
    }
}
