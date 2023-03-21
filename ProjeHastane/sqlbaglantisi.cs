using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjeHastane
{
    internal class sqlbaglantisi
    {

        BaglantiSinif dbcon=new BaglantiSinif();

        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(dbcon.Adres);
            baglan.Open();
            return baglan;
        }
    }
}
