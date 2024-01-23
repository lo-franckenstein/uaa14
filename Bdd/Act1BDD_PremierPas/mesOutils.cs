using System.Data;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using System.Security.AccessControl;
using System.Security;
using Org.BouncyCastle.Crypto.Operators;

namespace Act1BDD_PremierPas
{
    public struct mesOutils
    {
        public string connexionDataBase()
        {
            string connexionIp = "server=10.10.51.98;database=immo;port=3306;User Id=louis;password=root";
            return connexionIp;
        }


        public bool ListingBiens(out DataSet infos)
        {
            bool ok = false;
            MySqlConnection maConnection = new MySqlConnection(connexionDataBase());
            string query = "";
            try
            {
                maConnection.Open();
                query = "SELECT * FROM biens;";

                MySqlDataAdapter da = new MySqlDataAdapter(query, maConnection);
                infos = new DataSet();
                da.Fill(infos, "infoBiens");
                if (infos.Tables[0].Rows.Count >= 1)
                {
                    ok = true;
                }
                maConnection.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                throw;
            }
            return ok;
        }

        public string AfficheDataBiens(DataSet donnees)
        {
            string infos = "";
            for (int i = 0; i < donnees.Tables[0].Rows.Count; i++)
            {
                infos += donnees.Tables[0].Rows[i]["bienId"].ToString() + " | " +
                    donnees.Tables[0].Rows[i]["nom"].ToString() + " | " +
                    donnees.Tables[0].Rows[i]["taille"].ToString() + " | " +
                    donnees.Tables[0].Rows[i]["prix"].ToString() + " | " +
                    donnees.Tables[0].Rows[i]["ville"].ToString() + " | ";
            }
            return infos;
        }
    }
}
