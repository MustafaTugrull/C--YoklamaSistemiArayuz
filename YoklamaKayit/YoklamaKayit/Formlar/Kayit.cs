using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace YoklamaKayit.Formlar
{
    public partial class Kayit : Form
    {
        public Kayit()
        {
            InitializeComponent();
        }
        VideoCaptureDevice videoCapture;
        FilterInfoCollection filterInfo;

        void StartCamera()
        {
            try
            {
                filterInfo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                videoCapture = new VideoCaptureDevice(filterInfo[0].MonikerString);
                videoCapture.NewFrame += new NewFrameEventHandler(Camera_on);
                videoCapture.Start();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void Camera_on(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image=(Bitmap)eventArgs.Frame.Clone();
        }

        DbOkulEntities1 db = new DbOkulEntities1();
        int secilen;
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            OGRENCI t = new OGRENCI();
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtNumara.Text) || lookUpEdit1.Text=="FAKÜLTE" || lookUpEdit2.Text=="BÖLÜM")
            {
                MessageBox.Show("Alanlar boş geçilemez.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                t.AD = TxtAd.Text.ToUpper();
                t.FAKULTE = lookUpEdit1.Text;
                t.BOLUM = lookUpEdit2.Text;
                t.NUMARA = TxtNumara.Text;
                bool dogrulama = TcDogrula(TxtNumara.Text);
                if (dogrulama == false)
                {
                    MessageBox.Show("Öğrenci numarası geçerli değildir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    
                    pictureBox2.Image = pictureBox1.Image;
                    string fileName = @"C:\Users\Mustafa Tugrul\opensavc\images\" + TxtNumara.Text + ".jpg";
                    var bitmap = new Bitmap(pictureBox2.Width, pictureBox2.Height);
                    pictureBox2.DrawToBitmap(bitmap, pictureBox2.ClientRectangle);
                    System.Drawing.Imaging.ImageFormat imageFormat = null;
                    imageFormat = System.Drawing.Imaging.ImageFormat.Jpeg;
                    bitmap.Save(fileName, imageFormat);
                    db.OGRENCI.Add(t);
                    db.SaveChanges();
                    MessageBox.Show("ÖĞRENCİ KAYDI YAPILDI.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
        }

        private void Kayit_Load(object sender, EventArgs e)
        {
            StartCamera();
            lookUpEdit1.Properties.DataSource = (from x in db.FAKULTELER
                                                 select new
                                                 {
                                                     x.id,
                                                     x.FAKULTE
                                                 }).ToList();

      
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void Kayit_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                videoCapture.Stop();
            }
            catch
            {
                return;
            }
        }

        private void TxtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void TxtAd_Click(object sender, EventArgs e)
        {
            TxtAd.Text = "";
        }


        private bool TcDogrula(string tcNo)
        {
            bool durum = false;
            try
            {
                if (tcNo != "")
                {
                    if (tcNo.Length == 11)
                    {
                        char[] rakamlar = tcNo.ToCharArray();
                        int kural1 = 0, hane11 = rakamlar[10], hane10 = rakamlar[9];
                        for (int i = 0; i < 10; i++)
                        {
                            kural1 += Convert.ToInt32(rakamlar[i].ToString());
                        }
                        char[] birlerbasamagikural1 = kural1.ToString().ToCharArray();

                        int kural2tek = 0, kural2cift = 0;
                        for (int i = 0; i < 10; i += 2)
                        {
                            kural2tek += Convert.ToInt32(rakamlar[i].ToString());
                        }
                        for (int i = 1; i < 9; i += 2)
                        {
                            kural2cift += Convert.ToInt32(rakamlar[i].ToString());
                        }
                        char[] birlerbasamagikural2 = ((7 * kural2tek) + (9 * kural2cift)).ToString().ToCharArray();

                        int kural3 = 0;
                        for (int i = 0; i < 10; i += 2)
                        {
                            kural3 += Convert.ToInt32(rakamlar[i].ToString());
                        }
                        char[] birlerbasamagikural3 = (8 * kural3).ToString().ToCharArray();

                        if ((birlerbasamagikural1[birlerbasamagikural1.Length - 1] == hane11) && (birlerbasamagikural2[birlerbasamagikural2.Length - 1] == hane10) && (birlerbasamagikural3[birlerbasamagikural3.Length - 1] == hane11))
                        {
                            durum = true;
                        }
                        else
                        {
                            durum = false;
                        }
                        TxtNumara.Refresh();
                        TxtNumara.Focus();
                    }
                    else
                    {
                        durum = false;
                    }
                }
                else
                {
                    durum = false;
                }
            }
            catch (Exception)
            {
                durum = false;
            }
            return durum;
        }

    }
}
