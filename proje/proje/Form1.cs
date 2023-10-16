using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int secim = cmbMevsimler.SelectedIndex;

            if (secim == 0)
            {
                lstAylar.Items.Clear();
                lstAylar.Items.Add("Mart");
                lstAylar.Items.Add("Nisan");
                lstAylar.Items.Add("Mayıs");
            }
            else if (secim == 1)
            {
                lstAylar.Items.Clear();
                lstAylar.Items.Add("Haziran");
                lstAylar.Items.Add("Temmuz");
                lstAylar.Items.Add("Ağustos");
            }
            else if (secim == 2)
            {
                lstAylar.Items.Clear();
                lstAylar.Items.Add("Eylül");
                lstAylar.Items.Add("Ekim");
                lstAylar.Items.Add("Kasım");
            }
            else
            {
                lstAylar.Items.Clear();
                lstAylar.Items.Add("Aralık");
                lstAylar.Items.Add("Ocak");
                lstAylar.Items.Add("Şubat");
            }
        }
}
