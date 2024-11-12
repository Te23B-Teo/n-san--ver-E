// uppgift 1 av if-satser, loopar och datatyper
// if(6>=3){Console.WriteLine("Hello, World!");Console.ReadLine();}


// uppgift 2
// Console.WriteLine("skriv ett namn?");
// string namn = Console.ReadLine();
// if(namn.ToLower() == "noname"){
//  Console.WriteLine("Welcome");
//  Console.ReadLine();
// }


// uppgift 3
// Console.WriteLine("skriv ditt namn och lössenord?");
// string namn = Console.ReadLine();
// string lössenord = Console.ReadLine();
// if(namn.ToLower() == "noname" && lössenord.ToLower() == "nopass"){
//     Console.WriteLine("Welcome");
// }
// else{
// Console.WriteLine("wrong username or password");
// }
// Console.ReadLine();

// uppgift 4
// for (int i = 0; i < 32; i++)
// {
// Console.WriteLine("Hello, World!");
// }
// Console.ReadLine();

// uppgift 5
// while(true){
//     string löss = Console.ReadLine();
//     if(löss == "katt"){
//         break;
//     }
// }
// Console.ReadLine();

// uppgift 6
// for (int i = 0; i < 32; i++){
//     Console.WriteLine("vad är nummret");
//     string nummer = Console.ReadLine();
//     int nummerbäst = 0;
//     int.TryParse(nummer,out nummerbäst);
//     if(nummerbäst > 5){
//         Console.WriteLine("högre än 5!");
//     }
// }

// uppgift 7
// int bib = 0;
// while(true){
// string bab = Console.ReadLine();
// bool beb = int.TryParse(bab,out bib);
// while(beb != true){
// Console.WriteLine("igen");
// break;
// }
// if(beb == true){
//     break;
// }
// }

// uppgift 8

int randomnumber = Random.Shared.Next(1,10);