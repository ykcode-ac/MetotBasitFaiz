using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetotBasitFaiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                // Kullanıcıdan değerlerin alınması
                double anapara = Convert.ToDouble(txtAnapara.Text);
                double faizOrani = Convert.ToDouble(txtFaizOrani.Text) / 100;
                int sure = Convert.ToInt32(txtSure.Text);

                // Metot çağrıları
                double toplamFaiz = FaizHesapla(anapara, faizOrani, sure);
                double toplamOdenecek = anapara + toplamFaiz;

                // Sonuçların gösterilmesi
                lblToplamFaiz.Text = $"Toplam Faiz: {toplamFaiz:C}";
                lblToplamOdenecek.Text = $"Toplam Ödenecek: {toplamOdenecek:C}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Basit faiz hesaplama metodu
        private double FaizHesapla(double anapara, double faizOrani, int sure)
        {
            return anapara * faizOrani * sure;
        }
    }
}
