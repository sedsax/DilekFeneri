using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace otuzocak
{
    public partial class AdminPaneli : System.Web.UI.Page
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-GDBNH21;Initial Catalog=Dilek_Feneri;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

            listele1();
            listele2();

        }

        private void listele1() // veritabanındaki kayıtların görüntülenmesi
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from fener_tbl", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            GridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void listele2() // veritabanındaki kayıtların görüntülenmesi
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from cati_tbl", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            GridView2.DataSource = tablo;
            baglanti.Close();
        }
    }
}