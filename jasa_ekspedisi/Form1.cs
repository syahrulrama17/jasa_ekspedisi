using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jasa_ekspedisi
{
    public partial class Form1 : Form
    {
        string nama, no, alamat, kota, prov, berat, waktu ;
        int harga, total, y;
        
        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            harga = 18000;
            waktu = "2-4 hari";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            harga = 20000;
            waktu = "1-2 hari";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || comboBox2.Text == "" || comboBox1.Text == "" ||
    textBox4.Text == "" || textBox6.Text == "" || comboBox4.Text == "" || comboBox3.Text == "" ||
    textBox7.Text == "")
            {
                MessageBox.Show("Form harus terisi");
            }
            else
            {
                berat = textBox7.Text;
                int brt = Convert.ToInt32(berat);
                total = brt * harga;
                MessageBox.Show(
                "--------------------------------------------------------------------------------------------" +
                "Nama Pengirim :\n" + textBox1.Text + "\n" +
                "No. Telp : \n" + textBox2.Text + "\n"+
                "Alamat Pengirim :\n" + textBox3.Text + "," + comboBox1.Text + "," + comboBox2.Text + "\n\n" +
                "--------------------------------------------------------------------------------------------" +
                "Nama Penerima :\n" + textBox6.Text + "\n" +
                "No. Telp : \n" + textBox5.Text + "\n"+
                "Alamat Penerima :\n" + textBox4.Text + "," + comboBox3.Text + "," + comboBox4.Text + "\n\n" +
                "--------------------------------------------------------------------------------------------" +
                "Harga yang harus dibayar : Rp." + total + "\nPengiriman akan dilakukan dan akan sampai dalam : " + waktu + "\n\n" +
                "Terima kasih telah percaya dengan JEK !!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nama = textBox1.Text;
            no  = textBox2.Text;
            alamat = textBox3.Text;
            kota = comboBox2.Text;
            prov = comboBox1.Text;

            label24.Text =": "+ nama;
            label25.Text =": "+no ;
            label26.Text =": "+alamat;
            if (comboBox2.Text == "Kabupaten/Kota")
            {
                label27.Text = ": ";
            }
            else
            {
                label27.Text = ": "+kota;
            }

            if (comboBox1.Text == "Provinsi")
            {
                label28.Text = ": ";
            }
            else
            {
                label28.Text =": "+ prov;
            }

        }
        public void FillDKI()
        {
            ArrayList kota = new ArrayList() { "Jakarta Pusat", "Jakarta Barat", "Jakarta Timur", "Jakarta Utara", "Jakarta Selatan" };
            if (y == 1)
            {
                foreach (var x in kota)
                {
                    comboBox2.Items.Add(x);
                }
            }
            else if (y == 2)
            {
                foreach (var x in kota)
                {
                    comboBox3.Items.Add(x);
                }
            }
        }

        public void FillJB()
        {
            ArrayList kota = new ArrayList() { "Bandung", "Bekasi", "Bogor", "Cirebon", "Depok" };
            if (y == 1)
            {
                foreach (var x in kota)
                {
                    comboBox2.Items.Add(x);
                }
            }
            else if (y == 2)
            {
                foreach (var x in kota)
                {
                    comboBox3.Items.Add(x);
                }
            }
        }

        public void FillJTengah()
        {
            ArrayList kota = new ArrayList() { "Magelang", "Pekalongan", "Salatiga", "Semarang", "Surakarta" };
            if (y == 1)
            {
                foreach (var x in kota)
                {
                    comboBox2.Items.Add(x);
                }
            }
            else if (y == 2)
            {
                foreach (var x in kota)
                {
                    comboBox3.Items.Add(x);
                }
            }
        }

        public void FillJTimur()
        {
            ArrayList kota = new ArrayList() { "Kediri", "Malang", "Surabaya" };
            if (y == 1)
            {
                foreach (var x in kota)
                {
                    comboBox2.Items.Add(x);
                }
            }
            else if (y == 2)
            {
                foreach (var x in kota)
                {
                    comboBox3.Items.Add(x);
                }
            }
        }

        public void FillDIY()
        {
            ArrayList kota = new ArrayList() { "Yogyakarta" };
            if (y == 1)
            {
                foreach (var x in kota)
                {
                    comboBox2.Items.Add(x);
                }
            }
            else if (y == 2)
            {
                foreach (var x in kota)
                {
                    comboBox3.Items.Add(x);
                }
            }
        }

        public void FillBali()
        {
            ArrayList kota = new ArrayList() { "Denpasar" };
            if (y == 1)
            {
                foreach (var x in kota)
                {
                    comboBox2.Items.Add(x);
                }
            }
            else if (y == 2)
            {
                foreach (var x in kota)
                {
                    comboBox3.Items.Add(x);
                }
            }
        }
        public void FillSUMBAR()
        {
            ArrayList kota = new ArrayList() { "Padang", "Bukittinggi", "Kab.Tanah Datar", "Kab.Pesisir Selatan", "Kab.Pasaman","Kab.Padang Panjang", "Kota Pariaman", "Keplauan Mentawai", "Kab.Pasaman Barat", "Kab.Solok","Kab.Dharmasraya","Kota Payakumbuh" };
            if (y == 1)
            {
                foreach (var x in kota)
                {
                    comboBox2.Items.Add(x);
                }
            }
            else if (y == 2)
            {
                foreach (var x in kota)
                {
                    comboBox3.Items.Add(x);
                }
            }
        }
        public void FillSUMUT()
        {
            ArrayList kota = new ArrayList() { "Medan", "Pematang Siantar", "Sibolga", "Tanjung Balai", "Tebing Tinggi", "Padang Sidempuan", "Gunungsitoli" };
            if (y == 1)
            {
                foreach (var x in kota)
                {
                    comboBox2.Items.Add(x);
                }
            }
            else if (y == 2)
            {
                foreach (var x in kota)
                {
                    comboBox3.Items.Add(x);
                }
            }
        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            y = 2;
            if (comboBox4.SelectedIndex == 0)
            {
                comboBox3.Items.Clear();
                FillDKI();
            }
            else if (comboBox4.SelectedIndex == 1)
            {
                comboBox3.Items.Clear();
                FillJB();
            }
            else if (comboBox4.SelectedIndex == 2)
            {
                comboBox3.Items.Clear();
                FillJTengah();
            }
            else if (comboBox4.SelectedIndex == 3)
            {
                comboBox3.Items.Clear();
                FillJTimur();
            }
            else if (comboBox4.SelectedIndex == 4)
            {
                comboBox3.Items.Clear();
                FillDIY();
            }
            else if (comboBox4.SelectedIndex == 5)
            {
                comboBox3.Items.Clear();
                FillBali();
            }
            else if (comboBox4.SelectedIndex == 6)
            {
                comboBox3.Items.Clear();
                FillSUMBAR();
            }
            else if (comboBox4.SelectedIndex == 7)
            {
                comboBox3.Items.Clear();
                FillSUMUT();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            nama = textBox6.Text;
            no = textBox5.Text;
            alamat = textBox4.Text;
            kota = comboBox3.Text;
            prov = comboBox4.Text;

            label33.Text = ": " + nama;
            label32.Text = ": " + no;
            label31.Text = ": " + alamat;
            if (comboBox4.Text == "Provinsi")
            {
                label29.Text = ": ";
            }
            else
            {
                label29.Text = ": " + prov;
            }

            if (comboBox3.Text == "Kabupaten/Kota")
            {
                label30.Text = ": ";
            }
            else
            {
                label30.Text = ": " + kota;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string[] x = { "1. Pastikan memasukan data dengan lengkap dan benar","2. Masukan data pengirim", "3. Kemudian masukkan data penerima",
                "4. Tekan tombol set penerima dan set pengirim ","5. Pilih jenis pengiriman yang diinginkan", 
                "6. Masukkan jumlah berat barang yang ingin dikirim","7. Jika data yang anda masukan sudah benar tekan tombol proses", 
                "8. Jika mau menghapus semua data tekan tombol Clear All", "9. Selamat mencoba !!!"};
            foreach (string s in x)
            {
                MessageBox.Show (s);
            }
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            y = 1;
            if (comboBox1.SelectedIndex == 0)
            {
                comboBox2.Items.Clear();
                FillDKI();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                comboBox2.Items.Clear();
                FillJB();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                comboBox2.Items.Clear();
                FillJTengah();
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                comboBox2.Items.Clear();
                FillJTimur();
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                comboBox2.Items.Clear();
                FillDIY();
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                comboBox2.Items.Clear();
                FillBali();
            }
            else if (comboBox1.SelectedIndex == 6)
            {
                comboBox2.Items.Clear();
                FillSUMBAR();
            }
            else if (comboBox1.SelectedIndex == 7)
            {
                comboBox2.Items.Clear();
                FillSUMUT();

            }

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            this.textBox5.Text = "";
            this.textBox6.Text = "";
            this.textBox7.Text = "";
            label24.Text = ": ";
            label25.Text = ": ";
            label26.Text = ": ";
            label27.Text = ": ";
            label28.Text = ": ";
            label29.Text = ": ";
            label30.Text = ": ";
            label31.Text = ": ";
            label32.Text = ": ";
            label33.Text = ": ";
            comboBox1.Text = "Provinsi";
            comboBox4.Text = "Provinsi";
            comboBox3.Text = "Kabupaten/Kota";
            comboBox2.Text = "Kabupaten/Kota";
           
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            harga = 15000;
            waktu = "3-6 hari";
        }
    }
}
