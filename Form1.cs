using CografiBilgiSystem;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CografiBilgiSystem
{
    public partial class Form1 : Form
    {
        private static int Count = 0;
        List<Arac> list;
        private GMapOverlay katman1;
        public Form1()
        {
            InitializeComponent();
            initializeMap();
            aracListesiniOlustur();
        }
        private void aracListesiniOlustur()
        {
            // list = new List<Arac>();           
            Arac.AddArac(new Arac("31Hatay", "Truck", "Hatay", "Izmir", new PointLatLng(36.20, 36.15)));
            Arac.AddArac(new Arac("06Ankara", "Kamyon", "Ankara", "Istanbul", new PointLatLng(39.9334, 32.8597)));
            Arac.AddArac(new Arac("38Kayseri", "Hafif Ticari", "Kayseri", "Istanbul", new PointLatLng(38.7322, 35.4853)));
            Arac.AddArac(new Arac("34Istanbul", "Kamyon", "Istanbul", "Hatay", new PointLatLng(41.0082, 28.9784)));
            Arac.AddArac(new Arac("01Adana", "Truck", "Adana", "Ankara", new PointLatLng(37.0000, 35.3213)));
        }
        private void initializeMap()
        {
            map.DragButton = MouseButtons.Left;
            map.MapProvider = GMapProviders.GoogleMap;
            map.Position = new GMap.NET.PointLatLng(39.9242, 32.8613);
            map.Zoom = 4;
            map.MinZoom = 3;
            map.MaxZoom = 100;
            katman1 = new GMapOverlay();
            map.Overlays.Add(katman1);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            PointLatLng lok1 = new PointLatLng(Convert.ToDouble(textBoxEnlem.Text),
                                             Convert.ToDouble(textBoxBoylam.Text));
            GMarkerGoogle marker = new GMarkerGoogle(lok1, GMarkerGoogleType.red_pushpin);
            marker.Tag = Count;
            marker.ToolTipText = "Lokasyon" + (++Count);
            marker.ToolTip.Fill = Brushes.Black;
            marker.ToolTip.Foreground = Brushes.White;
            marker.ToolTip.Stroke = Pens.Black;
            marker.ToolTip.TextPadding = new Size(10, 10);
            katman1.Markers.Add(marker);
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            map.Dispose();
            Application.Exit();
        }
        private void map_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            string selectionCar = (string)item.Tag;
            foreach (Arac arac in Arac.AracList)
            {
                if (selectionCar.Equals(arac.Plaka))
                {
                    textBox1.Text = selectionCar;
                    textBox2.Text = arac.Tip;
                    textBox3.Text = arac.From;
                    textBox4.Text = arac.To;
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Arac arac in Arac.AracList)
            {
                GMarkerGoogle markerTemp = new GMarkerGoogle(arac.Konum, GMarkerGoogleType.orange_dot);
                markerTemp.Tag = arac.Plaka;
                markerTemp.ToolTipText = arac.ToString();
                katman1.Markers.Add(markerTemp);
                markerTemp.ToolTip.Fill = Brushes.Black;
                markerTemp.ToolTip.Foreground = Brushes.White;
                markerTemp.ToolTip.Stroke = Pens.Black;
                markerTemp.ToolTip.TextPadding = new Size(10, 10);
                markerTemp.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            string plaka = addPlaka.Text;
            string type = addType.Text;
            string from = addFrom.Text;
            string to = addTo.Text;
            string enlem = addEnlem.Text;
            string boylam = addBoylam.Text;           
            if (float.TryParse(enlem, out float Enlem) && float.TryParse(boylam, out float Boylam))
            {               
                Arac.AddArac(new Arac(plaka, type, from, to, new PointLatLng(Enlem, Boylam)));
                addPlaka.Text = "";
                addType.Text = "";
                addFrom.Text = "";
                addTo.Text = "";
                addEnlem.Text = "";
                addBoylam.Text = "";
            }
            else
            {               
                MessageBox.Show("Please enter valid numeric values for Enlem and Boylam.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}