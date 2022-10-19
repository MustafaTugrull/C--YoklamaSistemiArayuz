using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoklamaKayit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DbOkulEntities1 db = new DbOkulEntities1();

        private void BtnKayit_Click(object sender, EventArgs e)
        {
            Formlar.Kayit fr = new Formlar.Kayit();
            fr.Show();
        }
        String secilen;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DERSLER k = new DERSLER();

            if (lookUpEdit1.Text == "DERS" )
            {
                MessageBox.Show("Alanlar boş geçilemez.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                secilen = '"'+ lookUpEdit1.Text + '"';

                System.Diagnostics.Process.Start("C://run_app.bat", secilen);
            }
            
        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            Formlar.Admin fr = new Formlar.Admin();
            fr.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Formlar.OgrIslem fr = new Formlar.OgrIslem();
            fr.Show();
        }

        private void BtnDersSecim_Click(object sender, EventArgs e)
        {
            Formlar.DersSecim fr = new Formlar.DersSecim();
            fr.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lookUpEdit1.Properties.DataSource = (from x in db.DERSLER
                                                 select new
                                                 {
                                                     x.ID,
                                                     x.DERSADI
                                                 }).ToList();
        }
    }
}
