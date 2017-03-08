using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_OturmaPlani
{
    public partial class Rezervasyon_Ekrani : Form
    {
        public bool kadinMi;
        public string adSoyad;
        public string TC;
        private Button btn;

        public Rezervasyon_Ekrani()
        {
            InitializeComponent();
        }

        public Rezervasyon_Ekrani(Button btn) : this()
        {
            this.btn = btn;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {                
                kadinMi = true;
                adSoyad = txtAdSoyad.Text.ToString();
                TC = mtxtTC.Text.ToString();

                if (rbBay.Checked == true)
                {
                    kadinMi = false;
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
