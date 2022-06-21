using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace But_Odevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source = ENESTELEFON; Initial Catalog = liste; Integrated Security = True");
        SqlCommand cmd;

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'listeDataSet.Table' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tableTableAdapter.Fill(this.listeDataSet.Table);

        }

        private void button1_Click(object sender, EventArgs e) //Veritabanına Ekleme Yapar.
        {
            string arac = aracmarka.Text;
            string model = textBox2.Text;
            string yil = textBox1.Text;
            string sase = textBox3.Text;
            string fiyat = textBox4.Text;

            con.Open();
            cmd = new SqlCommand("INSERT INTO [liste].[dbo].[Table](Arac_Markasi, Arac_Modeli, Arac_Sase_No, Arac_Uretim_Yili, Aracin_Fiyati) VALUES ('"+ arac +"', '"+ model +"','"+ yil +"','"+ sase + "','" + fiyat + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Başarıyla Kaydedildi.");


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e) //TextBoxları Sıfırlama
        {
            aracmarka.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();


        }

        private void button2_Click_1(object sender, EventArgs e) //ListBoxa Ekleme Yapar.
        {
            listBox1.Items.Add(aracmarka.Text + " - " + textBox2.Text + " - " + textBox1.Text + " - " + textBox3.Text + " - " + textBox4.Text + " - ");
        }

        private void button3_Click(object sender, EventArgs e) //ListBoxu Temizler.
        {
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e) //ListBox Seçili Satırı Siler.
        {
            listBox1.Items.RemoveAt(listBox1.Items.IndexOf(listBox1.SelectedItem));
        }

        

    }
}
