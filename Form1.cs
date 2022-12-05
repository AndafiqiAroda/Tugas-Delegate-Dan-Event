//Nama : Andafiqi Aroda
//NIM : 21.11.4014
//Kelas: 21 IF 03


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        private IList<Perhitungan> listOfPerhitungan = new List<Perhitungan>();
        public Form1()
        {
            InitializeComponent();
            
        }
        private void FormEntry_OnCreate(Perhitungan hitung)
        {
            listOfPerhitungan.Add(hitung);
            listBox1.Items.Add(hitung.Hasil);
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmEntryPerhitungan formEntry = new FrmEntryPerhitungan("Calculator");
            formEntry.OnCreate += FormEntry_OnCreate;
            formEntry.ShowDialog();
        }
    }
}
