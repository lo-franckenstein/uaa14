Console.WriteLine("Bonjour");
Thread.Sleep(2000);
Console.Write("\nBienvenue à la centre d'appel, sponsorisé par Louis   |||   ");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Service approuvé par Béatrice Baudson");
Console.ForegroundColor = ConsoleColor.White;
Thread.Sleep(2000);
Console.WriteLine("\nQui souhaitez-vous appeler?\n");
Thread.Sleep(1000);
Console.WriteLine("  [1] Appeler Clôture Leblanc, car vos enfants réclament des poules, et vous avez besoin d'une clôture en forme de cercle.");
Thread.Sleep(1000);
Console.WriteLine("  [2] Appeler Service Santé, car votre vie est complexe.");
Thread.Sleep(1000);
Console.WriteLine("  [3] Appeler McDonald, car vous souhaitez un bon petit sandwich pour votre journée.");
Thread.Sleep(1000);
Console.WriteLine("  [4] Appeler Belfius, car vous êtes endetté, mais malgré cela, vous souhaitez faire plaisir à quelqu'un.");
Thread.Sleep(5000);
Console.WriteLine("\nAprès avoir connu nos services disponibles actuellement, qui souhaitez-vous appeler? (Cliquer sur le chiffre se situant sur votre pavé numérique)");



ConsoleKeyInfo cki = Console.ReadKey();
do
{
    cki = Console.ReadKey();
} while (cki.Key != ConsoleKey.NumPad1 || cki.Key != ConsoleKey.NumPad2 || cki.Key != ConsoleKey.NumPad3 || cki.Key != ConsoleKey.NumPad4);

if (cki.Key == ConsoleKey.NumPad1)
{
    Console.WriteLine("test");
}