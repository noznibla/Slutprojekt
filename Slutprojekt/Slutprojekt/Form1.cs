using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) /*Gömmer första sidan*/
        {
            Frågesport.Hide();
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

        private void Nästa_Click(object sender, EventArgs e) /*Byter till nästa sida*/
        {
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

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
