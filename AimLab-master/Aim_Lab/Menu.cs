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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kolay seviyede amaç 30 saniye içerisinde 30 adet hedefi vurmanızdır.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            KolaySeviye frm = new KolaySeviye(); // tanımalam 
            frm.Show(); // formu açma
            this.Hide(); // formu gizleme
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Orta seviyede amaç 30 saniye içerisinde 40 adet hedefi vurmanızdır.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            OrtaSeviye frm = new OrtaSeviye();
            frm.Show();
            this.Hide();
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zor seviyede amaç 30 saniye içerisinde 50 adet hedefi vurmanızdır.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ZorSeviye frm = new ZorSeviye();
            frm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult exit; //tanımlama
            exit = MessageBox.Show("Uygulamadan Çıkmak İstediğinize Emin Misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exit == DialogResult.Yes)
            {
                Application.Exit(); //uygulamayı kapatır
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sınırsız süre! İstediğiniz kadar atış yapabilirsiniz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            SerbestMod frm = new SerbestMod();
            frm.Show();
            this.Hide();
        }

        
    }
}
