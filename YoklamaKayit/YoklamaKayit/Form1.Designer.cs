
namespace YoklamaKayit
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnKayit = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit7 = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit7 = new DevExpress.XtraEditors.PictureEdit();
            this.BtnAdmin = new DevExpress.XtraEditors.SimpleButton();
            this.BtnOgrIslem = new DevExpress.XtraEditors.SimpleButton();
            this.BtnDersSecim = new DevExpress.XtraEditors.SimpleButton();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnKayit
            // 
            this.BtnKayit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKayit.ImageOptions.Image")));
            this.BtnKayit.Location = new System.Drawing.Point(12, 309);
            this.BtnKayit.Name = "BtnKayit";
            this.BtnKayit.Size = new System.Drawing.Size(150, 43);
            this.BtnKayit.TabIndex = 1;
            this.BtnKayit.Text = "KAYIT";
            this.BtnKayit.Click += new System.EventHandler(this.BtnKayit_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(83, 442);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(150, 43);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "TARA";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // textEdit7
            // 
            this.textEdit7.EditValue = "YOKLAMA SİSTEMİ";
            this.textEdit7.Location = new System.Drawing.Point(83, 27);
            this.textEdit7.Name = "textEdit7";
            this.textEdit7.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textEdit7.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEdit7.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.textEdit7.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit7.Properties.Appearance.Options.UseFont = true;
            this.textEdit7.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit7.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textEdit7.Size = new System.Drawing.Size(169, 26);
            this.textEdit7.TabIndex = 83;
            // 
            // pictureEdit7
            // 
            this.pictureEdit7.EditValue = ((object)(resources.GetObject("pictureEdit7.EditValue")));
            this.pictureEdit7.Location = new System.Drawing.Point(39, 69);
            this.pictureEdit7.Name = "pictureEdit7";
            this.pictureEdit7.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit7.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit7.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit7.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit7.Size = new System.Drawing.Size(251, 181);
            this.pictureEdit7.TabIndex = 84;
            // 
            // BtnAdmin
            // 
            this.BtnAdmin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAdmin.ImageOptions.Image")));
            this.BtnAdmin.Location = new System.Drawing.Point(12, 376);
            this.BtnAdmin.Name = "BtnAdmin";
            this.BtnAdmin.Size = new System.Drawing.Size(150, 43);
            this.BtnAdmin.TabIndex = 3;
            this.BtnAdmin.Text = "KULLANICI İŞLEMLERİ";
            this.BtnAdmin.Click += new System.EventHandler(this.BtnAdmin_Click);
            // 
            // BtnOgrIslem
            // 
            this.BtnOgrIslem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnOgrIslem.ImageOptions.Image")));
            this.BtnOgrIslem.Location = new System.Drawing.Point(172, 376);
            this.BtnOgrIslem.Name = "BtnOgrIslem";
            this.BtnOgrIslem.Size = new System.Drawing.Size(150, 43);
            this.BtnOgrIslem.TabIndex = 4;
            this.BtnOgrIslem.Text = "ÖĞRENCİ İŞLEMLERİ";
            this.BtnOgrIslem.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // BtnDersSecim
            // 
            this.BtnDersSecim.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnDersSecim.ImageOptions.Image")));
            this.BtnDersSecim.Location = new System.Drawing.Point(172, 309);
            this.BtnDersSecim.Name = "BtnDersSecim";
            this.BtnDersSecim.Size = new System.Drawing.Size(150, 43);
            this.BtnDersSecim.TabIndex = 85;
            this.BtnDersSecim.Text = "DERS SEÇİMİ";
            this.BtnDersSecim.Click += new System.EventHandler(this.BtnDersSecim_Click);
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(58, 265);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.lookUpEdit1.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lookUpEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lookUpEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.lookUpEdit1.Properties.Appearance.Options.UseFont = true;
            this.lookUpEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.DisplayMember = "DERSADI";
            this.lookUpEdit1.Properties.NullText = "DERS";
            this.lookUpEdit1.Properties.ValueMember = "ID";
            this.lookUpEdit1.Size = new System.Drawing.Size(209, 28);
            this.lookUpEdit1.TabIndex = 94;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(334, 528);
            this.Controls.Add(this.lookUpEdit1);
            this.Controls.Add(this.BtnDersSecim);
            this.Controls.Add(this.BtnOgrIslem);
            this.Controls.Add(this.BtnAdmin);
            this.Controls.Add(this.pictureEdit7);
            this.Controls.Add(this.textEdit7);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.BtnKayit);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YOKLAMA SİSTEMİ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton BtnKayit;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit textEdit7;
        private DevExpress.XtraEditors.PictureEdit pictureEdit7;
        private DevExpress.XtraEditors.SimpleButton BtnAdmin;
        private DevExpress.XtraEditors.SimpleButton BtnOgrIslem;
        private DevExpress.XtraEditors.SimpleButton BtnDersSecim;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
    }
}

