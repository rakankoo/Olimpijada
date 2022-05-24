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

namespace Olimpijada
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Molim Vas popunite oba polja!");
                return;
            }
            else
            {
                try
                {
                    SqlConnection veza = Konekcija.vezuj();
                    string mail = textBox1.Text;
                    string sifra = textBox2.Text;
                    string naredba1 = $"select * from ucesnik where email='{mail}'";
                    SqlCommand komanda = new SqlCommand(naredba1, veza);
                    veza.Open();
                    DataTable tabela = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(komanda);
                    adapter.Fill(tabela);
                    int broj = tabela.Rows.Count;
                    if (broj == 1)
                    {
                        if (string.Compare(sifra, tabela.Rows[0]["lozinka"].ToString()) == 0)
                        {
                            this.Hide();
                            Pregled meni = new Pregled();
                            meni.Show();
                        }
                        else
                        {
                            MessageBox.Show("Netacna lozinka!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Uneti email ne postoji!");
                    }
                    veza.Close();
                }
                catch
                {
                    MessageBox.Show("Doslo je do greske!");
                }
            }
        }
    }
}

