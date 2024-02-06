using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gişe___96
{
    public partial class Form1 : Form
    {
        Queue<string> musteri = new Queue<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void musteriCagir(Label lbl)
        {
            try
            {
                //hatalı olabilecek kod(lar) burada olur.
                lbl.Text = musteri.Dequeue();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message); 
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            musteri.Enqueue("Nursevim");
            musteri.Enqueue("Hilal");
            musteri.Enqueue("Yezda");
            musteri.Enqueue("Ravza");
            musteri.Enqueue("İlay");
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            musteri.Enqueue(txtAd.Text);
        }

        private void btnGetir1_Click(object sender, EventArgs e)
        {
            musteriCagir(lblGise1);
        }

        private void btnGetir2_Click(object sender, EventArgs e)
        {
            musteriCagir(lblGise2);
        }

        private void btnGetir3_Click(object sender, EventArgs e)
        {
            musteriCagir(lblGise3);
        }
    }
}
