
Console.WriteLine("Mis hinde said?");
char letter;
letter = Convert.ToChar(Console.ReadLine());
if (letter == 'A') 
{
    Console.WriteLine("Suurepärane!");
}
else if (letter == 'B')
{
    Console.WriteLine("Väga hea!!");
}
else if (letter == 'C')
{
    Console.WriteLine("Hea!");
}
else if (letter == 'D')
{
    Console.WriteLine("Rahuldav");
}
else if (letter == 'E')
{
    Console.WriteLine("Kasin!");
}
else if (letter ==  'F')
{
    Console.WriteLine("Puudulik");
}
else
{
    Console.WriteLine("vale väärtus");
}

// Ülesandes jäi segaseks kas peaksin kasutama ToUpper() funktsiooni. Hetkel ei lisanud seda aga mõistan, et kui kasutaja kirjutab väikse tähega, siis saab ta vastuseks vale väärtus. Kui lisaksin ToUpper(), siis kõik lisatud väikesed tähed muutuvad suureks.