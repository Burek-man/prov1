/* 
//uppgift 1
void skrivutantal( int mat, int antal, int vikt) {

}
string mat = "burek";
int antal = 1;
double vikt = 3.6;
Console.WriteLine($"jag har {antal} {mat} som väger {vikt} kg" );
*/

/* 
//uppgift 2

void SkrivUtSumma(int tal1, int tal2) {
    int summa= tal1 + tal2;
    Console.WriteLine($"Summan av {tal1} och {tal2} är {summa}");
}

SkrivUtSumma(4,21);
*/


/* 
//uppgift 3
void radieförcirkel(int radie){
Console.WriteLine(radie*radie*Math.PI);
}

radieförcirkel(5);
*/


/*
//uppgift 4
void namnmat(string namn, string mat){
Console.WriteLine($"mitt namn är {namn} och jag gillar {mat}");
}
namnmat("Albin" , "burek");
*/

Console.WriteLine("din ålder");
string input = Console.ReadLine();
int ålder = int.Parse(input);
Console.WriteLine($"du är {ålder} år gammal");