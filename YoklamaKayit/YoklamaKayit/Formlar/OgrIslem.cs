using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace YoklamaKayit.Formlar
{
    public partial class OgrIslem : Form
    {
        public OgrIslem()
        {
            InitializeComponent();
        }
        DbOkulEntities1 db = new DbOkulEntities1();
        int secilen;
        void Liste()
        {
            var degerler = from u in db.OGRENCI
                           select new
                           {
                               u.NUMARA,
                               u.AD,
                               u.FAKULTE,
                               u.BOLUM
                           };
            gridControl1.DataSource = degerler.ToList();
        }
        private void OgrIslem_Load(object sender, EventArgs e)
        {
            Liste();
            lookUpEdit1.Properties.DataSource = (from x in db.FAKULTELER
                                                 select new
                                                 {
                                                     x.id,
                                                     x.FAKULTE
                                                 }).ToList();
           
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            string id = TxtNumara.Text;
            var deger = db.OGRENCI.Find(id);
            string fileName = @"C:\Users\Mustafa Tugrul\opensavc\images\" + TxtNumara.Text + ".jpg";
            File.Delete(fileName);
            db.OGRENCI.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Öğrenci başarıyla silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            Liste();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            string id = TxtNumara.Text;
            var deger = db.OGRENCI.Find(id);
            if (string.IsNullOrEmpty(TxtAd.Text) || lookUpEdit1.Text == "FAKÜLTE" || lookUpEdit2.Text == "BÖLÜM")
            {
                MessageBox.Show("Alanlar boş geçilemez.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                
                deger.AD = TxtAd.Text;
                deger.FAKULTE = lookUpEdit1.Text;
                deger.BOLUM = lookUpEdit2.Text;
                db.SaveChanges();
                MessageBox.Show("Öğrenci başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Liste();
            }
        }
        

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                TxtNumara.Text = gridView1.GetFocusedRowCellValue("NUMARA").ToString();
                TxtAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
                lookUpEdit1.Text = gridView1.GetFocusedRowCellValue("FAKULTE").ToString();
                lookUpEdit2.Text = gridView1.GetFocusedRowCellValue("BOLUM").ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Hata");
            }
        }

        private void TxtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            secilen = int.Parse(lookUpEdit1.EditValue.ToString());
            lookUpEdit2.Properties.DataSource = (from y in db.BOLUMLER
                                                 select new
                                                 {
                                                     y.id,
                                                     y.BOLUM,
                                                     y.FAKULTE
                                                 }).Where(z => z.FAKULTE == secilen).ToList();
        }
    }
}
