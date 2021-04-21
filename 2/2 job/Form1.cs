using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_job
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            listBox1.Items.Clear();
            int n, n0 = 0, nmax = 0, index = 0;
            int[] ari = new int[20];
            for (int i = 0; i < 20; i++)
            {
                n = rnd.Next(10, 80);
                ari[i] = n;
                listBox1.Items.Add(n);
                listBox2.Items.Add(n);

            }
            nmax = ari.Max();
            textBox2.Text = ari[0].ToString();
            textBox3.Text = ari.Max().ToString();

            index = Array.IndexOf(ari, nmax);

            textBox4.Text = index.ToString();

            listBox2.Items[0] = nmax;
            listBox1.Items[index] = ari[0];
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
