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
        List<Panel> listPanel = new List<Panel>();
        int index;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frågesport.Hide();
            if (index < listPanel.Count - 1)
                listPanel[++index].BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listPanel.Add(Frågesport);
            listPanel.Add(Fråga1);
            listPanel.Add(Fråga2);
            listPanel[index].BringToFront();
        }

        private void Nästa_Click(object sender, EventArgs e)
        {
            if (index < listPanel.Count - 1)
                listPanel[++index].BringToFront();
        }

        private void Tidigare_Click(object sender, EventArgs e)
        {
            if (index > 0)
                listPanel[--index].BringToFront();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
