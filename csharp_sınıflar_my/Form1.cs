using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_sınıflar_my
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //nesne türetmek için; "sınıf adı" + "nesne adı" = "new" + "sınıf adı"
            araba car = new araba(); //car isimli bir nesne türettik
            //nesneler aracılığıyla sınıfların özelliklerine ulaşabiliriz. araba sınıfında 5 tane özellik belirlemiştik. renk, hiz, motor, durum, fiyat

            car.renk = "Mavi";
            car.hiz = 160;
            car.motor = 1245.56;
            car.fiyat = 50000;
            car.durum = 's'; //durum değişkeninin türü char olduğu için tek tırnakta yazdık

            label1.Text=car.renk;
            label2.Text = car.hiz.ToString();
            label3.Text = car.motor.ToString();
            label4.Text = car.fiyat.ToString();
            label5.Text = car.durum.ToString();
            pictureBox1.BackColor = Color.CadetBlue;
        }
    }
}
