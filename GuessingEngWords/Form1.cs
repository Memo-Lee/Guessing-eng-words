using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace GuessingEngWords
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Acer\Desktop\dbSozluk.accdb");
        Random rast = new Random();
        // Random classından rast nesnesi oluşturduk.
        int sure = 20;
        int kelime = 0;
        void getir () // işlemimizi bir metot içerisine aldık.
        {
            int sayi;
            sayi = rast.Next(1, 2490);
            // Random classının .Next() propertisi kullanıyoruz.
            // .Next(a,b) a'yı dahil etmiyor, b'yi dahil ediyor.
            LblCevap.Text = sayi.ToString();
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select * from sozluk where id=@p1", baglanti); // '*' dediğimizde tüm sütunları getiriyor.
            // p1 radom gelen sayi 'sayi' den geliyor.
            komut.Parameters.AddWithValue("@p1", sayi);
            // komuttan gelen değerleri okumak için 'dr' nesnesi oluşturuluyor.
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                // dr[1] itemı 'ingilizce'
                EngBox.Text = dr[1].ToString();
                // üretilen sayıdaki id'ye ait tr karşılığı
                LblCevap.Text = dr[2].ToString();
                LblCevap.Text = LblCevap.Text.ToLower(); // lower-upper case 
            }
            baglanti.Close();
        }

        void View ()
        {
            LblCevap.Visible = true;
            
            return;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getir(); //form yüklendiğinde metotu çağır
            EngBox.Enabled = false; //Eng kelimelerde işlem yapılmaması için enabled = false;
            EngBox.BackColor = Color.WhiteSmoke;
            //TabIndex'i bir olan değer ilk seçilen alan olduğu için TrBox'ın TabIndex'i 1
            Timer.Start(); // timer start
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TrBox_TextChanged(object sender, EventArgs e)
        {  
            if(TrBox.Text == LblCevap.Text)
            {
                kelime++;
                WordNum.Text = kelime.ToString();
                getir();
                TrBox.Clear();
                LblCevap.Visible = false;
            }

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            sure--;
            LblTimer.Text = sure.ToString();
            if(sure == 0)
            {
                TrBox.Enabled = false;
                EngBox.Enabled = false;
                Timer.Stop();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            View();
        }
    }
}
