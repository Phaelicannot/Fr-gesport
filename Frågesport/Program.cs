// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hej och välkommen till rymdquizet! Jag kom inte på något bättre så här är några slumpmässiga frågor om rymden, så att vi åter kan bli påminda om hur små vi är.");
Console.WriteLine("På varje fråga kommer det finnas tre valmöjligheter. Skriv 'a', 'b', eller 'c' när du svarar på frågorna. Tryck på 'enter' för att fortsätta.");
Console.ReadLine();

Console.WriteLine("Fråga 1:");
Console.WriteLine("Hur många jordklot får plats mellan Jorden och månen?");
Console.WriteLine("a) 10");
Console.WriteLine("b) 20");
Console.WriteLine("c) 30");
string fr1 = Console.ReadLine();
int score = 0;

if (fr1 == "c")
{
    Console.WriteLine("Korrekt! Vidare till nästa fråga.");
    score = score + 1;
}
else if (fr1 != "c")
{
    Console.WriteLine("Fel! Vidare till nästa fråga.");
}


Console.WriteLine("Fråga 2:");
Console.WriteLine("Hur lång tid tar det för ljuset från solen att nå vår planet?");
Console.WriteLine("a) 8 minuter");
Console.WriteLine("b) 9 minuter");
Console.WriteLine("c) 10 minuter");
string fr2 = Console.ReadLine();

if (fr2 == "a")
{
    Console.WriteLine("Korrekt! Vidare till nästa fråga.");
    score = score + 1;
}
else if (fr2 != "a")
{
    Console.WriteLine("Fel! Vidare till nästa fråga.");
}


Console.WriteLine("Fråga 3:");
Console.WriteLine("Hur många planeter finns det i vårt solsystem?");
Console.WriteLine("a) 5");
Console.WriteLine("b) 8");
Console.WriteLine("c) 10");
string fr3 = Console.ReadLine();

if (fr3 == "b")
{
    Console.WriteLine("Korrekt! Vidare till nästa fråga.");
    score = score + 1;
}
else if (fr3 != "b")
{
    Console.WriteLine("Fel! Vidare till nästa fråga.");
}


Console.WriteLine("Fråga 4:");
Console.WriteLine("Vad är namnet på den närmsta stjärnan bortom vår sol?");
Console.WriteLine("a) Dinus Mammus");
Console.WriteLine("b) Kaus Australis");
Console.WriteLine("c) Proxima Centauri");
string fr4 = Console.ReadLine();

if (fr4 == "c")
{
    Console.WriteLine("Korrekt! Vidare till nästa fråga.");
    score = score + 1;
}
else if (fr4 != "c")
{
    Console.WriteLine("Fel! Vidare till nästa fråga.");
}


Console.WriteLine("Fråga 5:");
Console.WriteLine("När började Pluto klassificeras som dvärgplanet, istället för planet?");
Console.WriteLine("a) 2006");
Console.WriteLine("b) 1995");
Console.WriteLine("c) 2002");
string fr5 = Console.ReadLine();

if (fr5 == "a")
{
    Console.WriteLine("Korrekt! Vidare till nästa fråga.");
    score = score + 1;
}
else if (fr5 != "a")
{
    Console.WriteLine("Fel! Vidare till nästa fråga.");
}

Console.WriteLine("Grattis! Du klarade dig genom quizzet, få se om du kan lite om rymden eller om du behöver gå om grundskolan. Tryck på 'enter' för att se dina poäng.");
Console.ReadLine();

if (score == 3 || score == 4)
{
    Console.WriteLine($"Du fick {score} poäng, grattis, du kan lite grundläggande fakta om rymden.");
    Console.ReadLine();
}
else if (score == 1 || score == 2)
{
    Console.WriteLine($"Du fick {score} poäng, du behöver nog gå om grundskolan, sorry not sorry");
}
else if (score == 5)
{
    Console.WriteLine($"Wow, {score} poäng! Fullpott! Du kan faktiskt lika mycket som the bare minimum! Grattis!");
}

Console.ReadLine();


