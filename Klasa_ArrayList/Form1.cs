using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klasa_ArrayList
{
    public partial class Form1 : Form
    {
        ArrayList listaAutomobila = new ArrayList();
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonUnesi_Click(object sender, EventArgs e)
        {
            Automobil a = new Automobil(textBoxNovi.Text);
            listaAutomobila.Add(a);

            richTextBox1.AppendText(listaAutomobila.IndexOf(a) + 1 + ". " + a.DajMarku() + "\n");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
         
        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            listaAutomobila.Clear();
            richTextBox1.Clear();
        }
    }
}
