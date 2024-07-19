using GMap.NET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CografiBilgiSystem
{
    internal class Arac
    {
        public static List<Arac> AracList = new List<Arac>();
        private string plaka;
        private string tip;
        private string from;
        private string to;
        private PointLatLng konum;

        public Arac(string plaka, string tip, string from, string to, PointLatLng konum)
        {

            this.Plaka = plaka;
            this.Tip = tip;
            this.From = from;
            this.To = to;
            this.Konum = konum;

        }
        public static void AddArac(Arac arac)
        {
            AracList.Add(arac);

        }

        public string Plaka { get => plaka; set => plaka = value; }
        public string Tip { get => tip; set => tip = value; }
        public string From { get => from; set => from = value; }
        public string To { get => to; set => to = value; }
        public PointLatLng Konum { get => konum; set => konum = value; }

        public override string ToString()
        {
            string str = "\n" + Plaka + "\n" + Tip + "\n" + From + "\n" + To;
            return str;
        }
    }
}
