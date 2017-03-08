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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                int koltukNo = 0;
                int bosGecilenKoltuklar = 0;
                for (int i = 0; i < 6; i++)
                {
                    ++bosGecilenKoltuklar;
                    for (int j = 0; j < 12; j++)
                    {
                        if (bosGecilenKoltuklar % 2 == 1)
                        {
                            if ((j == 0) || (j == 10) || (j == 1) || (j == 11))
                            {
                                continue;
                            }
                        }

                        Button btn = new Button();
                        btn.Width = 38;
                        btn.Height = 38;
                        btn.Left = 40 + (j * 41);
                        btn.Top = 30 + (i * 41);
                        btn.Click += btn_Click;
                        btn.Text = (++koltukNo).ToString();
                        btn.Image = imglKoltuklar.Images[0];
                        btn.Tag = (object)btn;
                        gbKoltuklar.Controls.Add(btn);
                    }                    
                }

                picbBosKoltuk.Image = imglKoltuklar.Images[0];
                picbDoluKoltuk.Image = imglKoltuklar.Images[1];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void btn_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = (Button)sender;
                Rezervasyon_Ekrani frm = new Rezervasyon_Ekrani(btn);
                frm.ShowDialog();

                if (frm.adSoyad != "")
                {
                    btn.Image = imglKoltuklar.Images[1];
                }
                else
                {
                    btn.Image = imglKoltuklar.Images[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
