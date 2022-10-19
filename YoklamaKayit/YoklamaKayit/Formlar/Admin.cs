using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoklamaKayit.Formlar
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        DbOkulEntities1 db = new DbOkulEntities1();

        void Liste()
        {
            var degerler = from u in db.ADMIN
                           select new
                           {
                               u.ID,
                               u.KULLANICIAD,
                               u.SIFRE
                           };
            gridControl1.DataSource = degerler.ToList();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            Liste();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            ADMIN t = new ADMIN();

            if (TxtAd.Text.Length <= 50 && TxtAd.Text != "" && TxtSifre.Text.Length >= 1)
            {
                t.KULLANICIAD = TxtAd.Text;
                t.SIFRE = TxtSifre.Text;
                db.ADMIN.Add(t);
                db.SaveChanges();
                MessageBox.Show("Kullanıcı Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Liste();
            }
            else
            {
                MessageBox.Show("Kayıt Yapılamadı!!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtID.Text);
            var deger = db.ADMIN.Find(id);
            db.ADMIN.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Kullanıcı başarıyla silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            Liste();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtID.Text);
            var deger = db.ADMIN.Find(id);
            deger.KULLANICIAD = TxtAd.Text;
            deger.SIFRE = TxtSifre.Text;
            db.SaveChanges();
            MessageBox.Show("Kullanıcı başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Liste();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtAd.Text = gridView1.GetFocusedRowCellValue("KULLANICIAD").ToString();
            TxtSifre.Text = gridView1.GetFocusedRowCellValue("SIFRE").ToString();
        }
    }
}
