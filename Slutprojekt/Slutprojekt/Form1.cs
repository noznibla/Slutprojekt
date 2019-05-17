using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slutprojekt
{
    public partial class Form1 : Form
    {
        List<Panel> listPanel = new List<Panel>(); /*Skapar en lista till de olika panelerna*/
        int index;

        int poäng = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) /*Gömmer första sidan*/
        {
            Frågesport.Hide();
            index++;
        }

        private void Form1_Load(object sender, EventArgs e) /*Lägger till alla sidor (alla paneler)*/
        {
            listPanel.Add(Frågesport);
            listPanel.Add(Fråga1);
            listPanel.Add(Fråga2);
            listPanel.Add(Fråga3);
            listPanel.Add(Fråga4);
            listPanel.Add(Fråga5);
            listPanel.Add(Resultat);
            listPanel[index].BringToFront();
        }

        private void Nästa_Click(object sender, EventArgs e) /*Byter till nästa sida och checkar av om rätt svar är i tryckt vilket ger ett poäng*/
        {
            if(index == 1 && Kinesiska.Checked)
            {
                poäng++;
            }

            if (index == 2 && nio.Checked)
            {
                poäng++;
            }

            if (index == 3 && Trettiotvå.Checked)
            {
                poäng++;
            }

            if (index == 4 && Ankara.Checked)
            {
                poäng++;
            }

            if (index == 5 && Ram1.Checked)
            {
                poäng++;
            }

            if (index < listPanel.Count - 1)
                listPanel[++index].BringToFront();

        }

        private void Tidigare_Click(object sender, EventArgs e) /*Byter till föregående sida*/
        {
            if (index > 0)
                listPanel[--index].BringToFront();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e) /*Skriver ut resultatet till en txt fil*/
        {
            StreamWriter sw = new StreamWriter("Resultat.txt", true);
            sw.WriteLine("Du fick " + poäng + " rätt av fem möjliga");
            sw.Close();
        }

        private void Kinesiska_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
