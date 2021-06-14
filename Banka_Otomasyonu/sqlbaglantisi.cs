using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //kutuphaneyi ekledik


namespace Banka_Otomasyonu
{
    class sqlbaglantisi
    {
        public SqlConnection baglanti()  //method
        { //baglan nesne
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-E9UTSVL;Initial Catalog=Banka_Otomasyonu;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
