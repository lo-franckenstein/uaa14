

// Verifier declaration & Verifier création & Changement de valeur

Declaration feu1 = new Declaration(1, "1001");
Declaration feu2 = new Declaration(3, "007");

Console.WriteLine("Etat des feux:\n---------------");

Console.WriteLine(feu1.AffichageEtat());
Console.WriteLine(feu1.AffichageEtat());



Console.WriteLine("\nChangement d'état:\n---------------");
for (int i = 1; i < 3; i++)
{
    for (int j = 1; j < 4; j++)
    {
        feu1.Change = j;
        Console.WriteLine(feu1.AffichageEtat());
    }
}


Console.WriteLine("\nFaire passer le 007 à l'orange :");
feu2.Change = 2;
Console.WriteLine(feu2.AffichageEtat());


Console.WriteLine("\nFeu Clignotant: \n---------------");
Console.WriteLine(AffichageCligno());