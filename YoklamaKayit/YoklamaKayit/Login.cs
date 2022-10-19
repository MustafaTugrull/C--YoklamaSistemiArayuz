using DevExpress.XtraEditors;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        DbOkulEntities1 db = new DbOkulEntities1();
        private void BtnGiris_Click(object sender, EventArgs e)
        {
            var sorgu = from x in db.ADMIN where x.KULLANICIAD == textBox1.Text & x.SIFRE == textBox2.Text select x;
            if (sorgu.Any())
            {
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
