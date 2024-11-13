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
// int gissningint = 0;
// int randomnumber = Random.Shared.Next(1,11);
// Console.WriteLine("gissa på ett nummer mellan 1-10");
// while(true){
// string gissning = Console.ReadLine();
// bool sucess = int.TryParse(gissning, out gissningint);
// if(sucess == true && randomnumber == gissningint){
// Console.WriteLine("det var rätt!");
// Thread.Sleep(1000);
// break;
// }
// else if(sucess == true && randomnumber < gissningint){
//     Console.WriteLine("det var för högt!");
// }
// else if(sucess == true && randomnumber > gissningint){
//     Console.WriteLine("det var för lågt!");
// }
//     else if(sucess != true){
//         Console.WriteLine("det är inte en gissning!");
//     }
// }



// Uppgift 02 listor och arrayer

// uppgift 1 & 2
// string[] leksaker = {"docka", "leksaksbil", "spade", "traktor", "skateboard"};
// for(int i=0;i<5;i++){
//     Console.WriteLine(leksaker[i]);
// }
// Console.ReadLine();

// uppgift 3
// string[] klasskamrater = {"calle", "elis", "anton", "oscar", "harald};

// uppgift 4
// string[] värden = {"10", "9", "8", "1", "2"};

// uppgift 5
// string[] leksaker = {"docka", "leksaksbil", "spade", "traktor", "skateboard"};
// string[] klasskamrater = {"calle", "elis", "anton", "oscar", "harald"};
// string[] värden = {"10", "9", "8", "1", "2"};
// for(int i = 0 ; i < 5 ; i++){
// Console.WriteLine($"{leksaker[i]} ger {klasskamrater[i]} betyget {värden[i]}");
// }
// Console.ReadLine();

// uppgift 6,7 och 8
// List<string> cities = new List<string>();

//     for(int i = 0; i < 5; i++){
//    string input = Console.ReadLine();
//    if(input.ToLower() == "exit"){
//     break;
//    }
//     cities.Add(input);
//     }
//      for(int j = 0; j < 10; j++){
//     Console.WriteLine($"{cities[j]}");
//      }
// Console.ReadLine();



// uppgift 03 Metoder

// uppgift 1
// void Hello32() {
//  for(int i = 0; i < 32; i++ ){
//     Console.WriteLine("Hello, World");
//  }
// }
// Hello32();
// Console.ReadLine();

// uppgift 2
// int kvadrat = 25;

// void bib(int kvadrat){
//  Console.WriteLine($"{kvadrat*kvadrat}");
//   Console.ReadLine();
// }
// bib(kvadrat);

// uppgift 3