using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace otuzocak
{
    public partial class Çatı : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-GDBNH21;Initial Catalog=Dilek_Feneri;Integrated Security=True");
        protected void cati_kayit_Click(object sender, EventArgs e)
        {
            String ad = cati_ad.Text;
            String soyad = cati_soyad.Text;
            String tel = cati_tel.Text;

            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO cati_tbl (cati_ad, cati_soyad, cati_tel) VALUES ('" + ad + "', '" + soyad + "', '" + tel + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
           

        }
    }
}