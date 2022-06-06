using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aim_Lab
{
    public partial class KolaySeviye : Form
    {
        public KolaySeviye()
        {
            InitializeComponent();
        }

        int sayac = 30;

        private void KolaySeviye_Load(object sender, EventArgs e)
        {
            target.Enabled = false;     //başlangıçta gizliyoruz
            target.Visible = false;
            lblSkor.Visible = false;
            lblSkor.Enabled = false;
            lblZaman.Visible = false;
            lblZaman.Enabled = false;
            label1.Enabled = false;
            label1.Visible = false;
            label3.Enabled = false;
            label3.Visible = false;
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            sayac = 30;
            skor = 0;

            lblSkor.Text = "0";
            lblZaman.Text = "30";

            timer1.Start();

            btnBasla.Enabled = false;   // başlayınca menü ve başla butonlarını gizliyoruz
            btnBasla.Visible = false;
            btnMenuyeDon.Enabled = false;
            btnMenuyeDon.Visible = false;

            target.Enabled = true; // başladıında hedefleri gösteriyouz
            target.Visible = true;
            lblSkor.Visible = true;
            lblSkor.Enabled = true;
            lblZaman.Visible = true; 
            lblZaman.Enabled = true;
            label1.Enabled = true;
            label1.Visible = true;
            label3.Enabled = true;
            label3.Visible = true;
        }

        int skor = 0;

        private void target_Click(object sender, EventArgs e)
        {
            skor++;

            Random konum = new Random(); // random konum üretiyor
            int x = konum.Next(0, 900);
            int y = konum.Next(0, 400);

            target.Location = new Point(x, y); 
            lblSkor.Text = skor.ToString(); // skoru yazdırıyoruz
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            Random konum = new Random(); //tıklamadan random konum üretiyor
            int x = konum.Next(0, 900); 
            int y = konum.Next(0, 450);

            sayac--;
            lblZaman.Text = sayac.ToString(); // sayacı birer birer azaltıp label a yazdırıyor

            if (sayac > 0 && lblSkor.Text == "30")
            {
                timer1.Stop(); //durdur

                target.Visible = false; //gizle
                target.Enabled = false;

                MessageBox.Show("Harika! Kolay Seviyeyi " + sayac + " saniye kala tamamladınız.", "Kolay Seviye", MessageBoxButtons.OK, MessageBoxIcon.Information); 

                btnBasla.Enabled = true;
                btnBasla.Visible = true;   // başlayınca menü ve başla butonlarını açıyoruz
                btnMenuyeDon.Enabled = true;
                btnMenuyeDon.Visible = true;

                lblZaman.Visible = false;
                lblZaman.Enabled = false;
                lblSkor.Visible = false;   // gizliyoruz
                lblSkor.Enabled = false;
                label3.Visible = false;
                label3.Enabled = false;
                label1.Visible = false;
                label1.Enabled = false;
            }

            if (sayac == 0 && skor < 30)
            {
                timer1.Stop();
                MessageBox.Show("Süre Doldu ve Hedef Sayıya Ulaşamadınız. Skorunuz: " + skor, "Orta Seviye", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                btnBasla.Visible = true;
                btnBasla.Enabled = true;
                btnCikisYap.Visible = true;
                btnCikisYap.Enabled = true;
                btnMenuyeDon.Visible = true;
                btnMenuyeDon.Enabled = true;

                lblSkor.Visible = false;
                lblSkor.Enabled = false;
                lblZaman.Visible = false;
                lblZaman.Enabled = false;
                label1.Visible = false;
                label1.Enabled = false;
                label3.Visible = false;
                label3.Enabled = false;

                target.Visible = false;
                target.Enabled = false;
                
            }
        }

        private void btnMenuyeDon_Click(object sender, EventArgs e)
        {
            Menu frm = new Menu(); // yeni menü formu oluşturuyor
            frm.Show(); // gösteriyor
            this.Hide(); // gizliyor
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            DialogResult exit;
            exit = MessageBox.Show("Poligondan Ayrılıp Ana Menüye Dönmek İstediğinize Emin Misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exit == DialogResult.Yes)
            {
                Menu frm = new Menu();
                frm.Show();
                this.Hide();
            }
        }
    }
}
