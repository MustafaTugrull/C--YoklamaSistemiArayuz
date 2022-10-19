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
    public partial class DersSecim : Form
    {
        public DersSecim()
        {
            InitializeComponent();
        }
        DbOkulEntities1 db = new DbOkulEntities1();
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

        bool ogrenci_ders_sorgula(int DERSID,String OGRID)
        {
            var degerler = (from u in db.OGRDERS
                           select new
                           {
                               u.DERSID,
                               u.OGRID
                           }).Where(z => z.DERSID == DERSID && z.OGRID == OGRID);
            gridControl1.DataSource = degerler.ToList();
            int tekrar = degerler.ToList().Count;
            if (tekrar > 0)
                return true;
            else
                return false;
        }

        private void DersSecim_Load(object sender, EventArgs e)
        {
            Liste();
            lookUpEdit1.Properties.DataSource = (from x in db.DERSLER
                                                 select new
                                                 {
                                                     x.ID,
                                                     x.DERSADI
                                                 }).ToList();
            
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            OGRDERS k = new OGRDERS();
            k.OGRID = TxtNumara.Text;
            if (lookUpEdit1.Text == "DERS")
            {
                MessageBox.Show("Alanlar boş geçilemez.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                k.DERSID = byte.Parse(lookUpEdit1.EditValue.ToString());
                
                if (ogrenci_ders_sorgula(k.DERSID, k.OGRID) == false)
                {
                    db.OGRDERS.Add(k);
                    db.SaveChanges();
                    MessageBox.Show("ÖĞRENCİ DERS KAYDI YAPILDI.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("ÖĞRENCİNİN KAYDI ÖNCEDEN YAPILMIŞ!!.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

            Liste();

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                TxtNumara.Text = gridView1.GetFocusedRowCellValue("OGRID").ToString();
                
            }
            catch (Exception)
            {
                try
                {
                    TxtNumara.Text = gridView1.GetFocusedRowCellValue("NUMARA").ToString();
                }
                catch (Exception)
                {
                }
                
            }
        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
                                       
        }
    }
}
