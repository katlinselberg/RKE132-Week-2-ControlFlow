// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Kätlin!");

//Rakendus küsib kasutajal valida tema sugu (m/f)
//Lähtudes küsib kasutajal sisestada tema perekonnanime
//lähtudes kasutaja valikust, rakendus tervitab järgmiselt:
//"Welcome, Mr. [kasutaja perekonnanimi] / Welcome, Mrs. [kasutaja perekonnanimi]"
Console.WriteLine("Please, select your gender (m/f):");

Char userGender = Char.Parse(Console.ReadLine()); //loeb konsoolist maha andmeid string (sõne) formaadis

Console.WriteLine("Please, enter your last name:");

string userLastName = Console.ReadLine();

Console.WriteLine($"Welcome, {userGender}");


if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userLastName}!");
}

else if(userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {userLastName}!");
}
else
{
Console.WriteLine("Welcome!");
}
   