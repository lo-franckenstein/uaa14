uint exercice;
float rayon;


Console.WriteLine("Bonjour, quel exercice souhaitez-vous tester? \n[1] Cercle\n[2] \n[3]");
exercice = uint.Parse(Console.ReadLine());

if (exercice == 1)
{
    Console.Clear();
    Console.WriteLine("Bienvenue dans ce programme sur le cercle !\nTapez un rayon pour votre cercle.");

    rayon = float.Parse(Console.ReadLine());

}
