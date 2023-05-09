//Skapar den generiska klassen och lägger till innehåll
Dictionary<string, Human> people = new()
{
 {"Linnea", new() {Name = "Linnea", Age = 18}},
 {"Samuel", new() {Name = "Samuel", Age = 18}},
 {"Sofie", new() {Name = "Sofie", Age = 19}},
};

//Frågar användaren att skriva in ett namn som programmet sedan tar upp
Console.WriteLine("Vem letar du efter?");
string person = Console.ReadLine();

//Progammet kollar om den personen finns med i den generiska klassen, om den är det skrivs personens ålder ut
if (people.ContainsKey(person))
{
    Console.WriteLine(people[person].Age + " år");
}
//Om den inte är med skriver programmet det
else
{
    Console.WriteLine("Den personen finns inte");
}


Console.ReadLine();
