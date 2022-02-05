using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace otuzocak
{
    public partial class Fener : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-GDBNH21;Initial Catalog=Dilek_Feneri;Integrated Security=True");
        protected void fener_kayit_Click(object sender, EventArgs e)
        {
            String ad = fener_ad.Text;
            String soyad = fener_soyad.Text;
            String tel = fener_tel.Text;
            String add = fener_adres.Text;
            String dk = fener_dilek.Text;

            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO fener_tbl (fener_ad, fener_soyad, fener_tel, fener_adres, fener_dilek) VALUES ('" + ad + "', '" + soyad + "', '" + tel + "','" + add + "', '" + dk+"')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}