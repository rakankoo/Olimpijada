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
    public partial class Ucesnici : Form
    {
        int pozicija = 0;
        DataTable tabela;
        DataTable tabela2;

        private void puni()
        {
            SqlConnection veza = Konekcija.vezuj();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from ucesnik", veza);
            SqlDataAdapter adapter2 = new SqlDataAdapter("select * from pregled", veza);
            tabela = new DataTable();
            tabela2 = new DataTable();
            adapter.Fill(tabela);
            adapter2.Fill(tabela2);
        }

        private void refresh()
        {
            if (tabela.Rows.Count <= 0)
            {
                textID.Text = "";
                textIME.Text = "";
                textPREZIME.Text = "";
                textDISCIPLINA.Text = "";
                textPASS.Text = "";
                textDRZAVA.Text = "";
                textMAIL.Text = "";
            }
            else
            {
                if (pozicija == 0)
                {
                    btLevo.Enabled = false;
                    btLevoSkroz.Enabled = false;
                }
                else
                {
                    btLevo.Enabled = true;
                    btLevoSkroz.Enabled = true;
                }

                if (pozicija == tabela.Rows.Count - 1)
                {
                    btDesno.Enabled = false;
                    btDesnoSkroz.Enabled = false;
                }
                else
                {
                    btDesno.Enabled = true;
                    btDesnoSkroz.Enabled = true;
                }
                textID.Text = tabela.Rows[pozicija]["id_ucesnika"].ToString();
                textIME.Text = tabela.Rows[pozicija]["ime"].ToString();
                textPREZIME.Text = tabela.Rows[pozicija]["prezime"].ToString();
                textDRZAVA.Text = tabela2.Rows[pozicija]["drzava"].ToString();
                textPASS.Text = tabela.Rows[pozicija]["lozinka"].ToString();
                textMAIL.Text = tabela.Rows[pozicija]["email"].ToString();
                textDISCIPLINA.Text = tabela2.Rows[pozicija]["sport"].ToString();
            }
        }
        public Ucesnici()
        {
            InitializeComponent();
        }

        private void Ucesnici_Load(object sender, EventArgs e)
        {
            puni();
            refresh();
        }

        private void btLevoSkroz_Click(object sender, EventArgs e)
        {
            pozicija = 0;
            refresh();
        }

        private void btLevo_Click(object sender, EventArgs e)
        {
            pozicija--;
            refresh();
        }

        private void btDesno_Click(object sender, EventArgs e)
        {
            pozicija++;
            refresh();
        }

        private void btDesnoSkroz_Click(object sender, EventArgs e)
        {
            pozicija = tabela.Rows.Count - 1;
            refresh();
        }

        private void btObrisi_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textID.Text);
            string naredba1 = $"delete from ucesnik where ucesnik_id={id}";
            SqlConnection veza = Konekcija.vezuj();
            SqlCommand komanda1 = new SqlCommand(naredba1, veza);
            veza.Open();
            komanda1.ExecuteNonQuery();
            veza.Close();
            MessageBox.Show("Osoba uspesno obrisana!");
            if (pozicija != 0) pozicija--;
            else pozicija = 0;
            puni();
            refresh();
        }

        private void btIzmeni_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textID.Text);
                string ime = textIME.Text;
                string prezime = textPREZIME.Text;
                string email = textMAIL.Text;
                string lozinka = textPASS.Text;
                string drzava = textDRZAVA.Text;
                string disciplina = textDISCIPLINA.Text;
                string naredba = $"update ucesnik set ime='{ime}', prezime='{prezime}', " +
                    $"email='{email}', lozinka='{lozinka}', where ucesnik_id={id}";
                SqlConnection veza = Konekcija.vezuj();
                SqlCommand komanda = new SqlCommand(naredba, veza);
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
                MessageBox.Show("Izmena je uspesna!");
                puni();
                refresh();
            }
            catch
            {
                MessageBox.Show("Molim Vas ispravno uensite svako polje!");
            }
        }
    }
}
