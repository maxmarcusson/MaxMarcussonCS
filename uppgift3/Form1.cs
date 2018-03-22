using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace uppgift3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

    
        /* ADRIANS KOMMENTARER: 
         * Klasserna fungerar bra med konstuktors, metoder och getter/setters.
         * Hade gärna sett att Class1 hade döpts till "City" för att underlätta orientering.
         * I SELECT satsen där du hämtar data så skulle jag föredra att hämta in allt med Select *. Om det ändras eller läggs till i tabellerna så skulle det underlätta. 
         * Skulle kunna skapa en metod som hämtar looparna för charts istället för att skriva egna kodblock för varje stad för att dra ner på antalet rader kod.
         * LINQ används inte i alls i koden men det var inte heller ett krav på uppgiften.
         * Samtliga parametrar som ska vara med för uppgiften finns på plats och fungerar, mina kommentarer är mest förbättrningsförslag.
        */

    private void button1_Click(object sender, EventArgs e)
        {
            this.chart1.Series["Series1"].Points.Clear();
            this.chart2.Series["Series1"].Points.Clear();
            City boston = new City("boston", 300000, 1000, 200000000);
            boston = Program.FetchData(boston);

            List<double> xaxel = new List<double>();
            for (int x = 0; x < 30; x++)
            {
                xaxel.Add(0);
            }

            foreach (Accommodation element in boston.Accomodations)
            {
                if (element.Room_type == "Private room")
                {
                    for (int x = 0; x < 30; x++)
                    {
                        if (element.Price < x * 15)
                        {
                            xaxel[x]++;
                            break;
                        }
                    }
                }
                if (element.Overall_satisfaction < 4.5 && element.Overall_satisfaction != 0)
                {
                    this.chart1.Series["Series1"].Points.AddXY(element.Overall_satisfaction, element.Price);
                }
            }
            for (int x = 0; x < 30; x++)
            {
                this.chart2.Series["Series1"].Points.AddXY(x * 15, xaxel[x]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.chart1.Series["Series1"].Points.Clear();
            this.chart2.Series["Series1"].Points.Clear();
            City barcelona = new City("barcelona", 300000, 1000, 200000000);
            barcelona = Program.FetchData(barcelona);

            List<double> xaxel = new List<double>();
            for (int x = 0; x < 30; x++)
            {
                xaxel.Add(0);
            }

            foreach (Accommodation element in barcelona.Accomodations)
            {
                if (element.Room_type == "Private room")
                {
                    for (int x = 0; x < 30; x++)
                    {
                        if (element.Price < x * 15)
                        {
                            xaxel[x]++;
                            break;
                        }
                    }
                }
                if (element.Overall_satisfaction < 4.5 && element.Overall_satisfaction != 0)
                {
                    this.chart1.Series["Series1"].Points.AddXY(element.Overall_satisfaction, element.Price);
                }
            }
            for (int x = 0; x < 30; x++)
            {
                this.chart2.Series["Series1"].Points.AddXY(x * 15, xaxel[x]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.chart1.Series["Series1"].Points.Clear();
            this.chart2.Series["Series1"].Points.Clear();
            City amsterdam = new City("amsterdam", 300000, 1000, 200000000);
            amsterdam = Program.FetchData(amsterdam);

            List<double> xaxel = new List<double>();
            for(int x = 0; x < 30; x++)
                {
                    xaxel.Add(0);
                }


            foreach (Accommodation element in amsterdam.Accomodations)
            {
                if (element.Room_type == "Private room")
                {
                    for (int x = 0; x < 30; x++)
                    {
                        if (element.Price < x * 15)
                        {
                            xaxel[x]++;
                            break;
                        }
                    }
                }
                //this.chart2.Series["Series1"].Points.AddY(element.Price);
                if (element.Overall_satisfaction < 4.5 && element.Overall_satisfaction != 0)
                {
                    
                    double xx = element.Overall_satisfaction;
                    double yy = element.Price;
                    this.chart1.Series["Series1"].Points.AddXY(xx, yy);
                }
            }
            for (int x = 0; x < 30; x++)
            {
                this.chart2.Series["Series1"].Points.AddXY(x*15,xaxel[x]);
            }
        }
    }
}
