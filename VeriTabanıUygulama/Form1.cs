using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb; //Access Veri Tabanı Kütüphanesi
namespace VeriTabanıUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection Connection=new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=DenemeDers.accdb");
        //Veritabanı Kontrollü Açan Method
        public void ConnectionOpen()
        {
            try
            {
                Connection.Open();
            }
            catch (Exception hata)
            {
                //Sistem Hata Mesajı
                MessageBox.Show(hata.Message,"Bağlantı Açma Hata Penceresi");
            }
        }






        private void button1_Click(object sender, EventArgs e)
        {
            ConnectionOpen();
            MessageBox.Show("Veritabanı Açık");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Connection.Close();
            MessageBox.Show("Veritabanı Kapalı");
        }
    }
}
