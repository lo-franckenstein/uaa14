using System.Data;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using System.Security.AccessControl;
using System.Security;
using Org.BouncyCastle.Crypto.Operators;
using Act1BDD_PremierPas;

DataSet donnees;
DataSet infos;
mesOutils mp = new mesOutils();

Console.WriteLine("Liste de vos biens:\n\n");
if(mp.ListingBiens(out donnees))
{
    string listeBiens = mp.AfficheDataBiens(donnees);
    Console.WriteLine(listeBiens);
} else
{
    Console.WriteLine("Un soucis est arrivé lors de la demande...");
}




