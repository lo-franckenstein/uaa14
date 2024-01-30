using ActHeritagePooLouis_ExEntreprise;

Employe[] mesEmployes = new Employe[10];
generateurInformation fonction = new generateurInformation();
bool leave = false;
int pourcentageOfficiel = fonction.pourcentage();









for (int i = 0; i < 2; i++)
{
    mesEmployes[i] = new Directeur(fonction.GetRandomMatricule, fonction.GetRandomName, fonction.GetRandomSurName, fonction.GetRandomDate, 0, fonction.ca, pourcentageOfficiel);
}

for (int i = 2;i < 5;i++)
{
    mesEmployes[i] = new Cadre();
}

for (int i = 5; i < 10; i++)
{
    mesEmployes[i] = new Ouvrier();
}