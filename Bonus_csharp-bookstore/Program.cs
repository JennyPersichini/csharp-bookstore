// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Console.Write("Inserire il titolo del libro: ");
string titoloUtente = Console.ReadLine();

Console.Write("Inserire l'autore del libro: ");
string autoreUtente = Console.ReadLine();

Console.Write("Inserire il codice identificativo del libro (ISBN): ");
string isbnUtente = Console.ReadLine();

Console.Write("Inserire il numero di pagine del libro: ");
int numeroPagineUtente = int.Parse(Console.ReadLine());

Console.Write("Inserire il peso del libro (in grammi): ");
int pesoLibroUtente = int.Parse(Console.ReadLine());

Console.Write("Inserire la larghezza del libro (in cm): ");
double larghezzaLibroUtente = double.Parse(Console.ReadLine());

Console.Write("Inserire l'altezza del libro (in cm): ");
double altezzaLibroUtente = double.Parse(Console.ReadLine());

Console.Write("Inserire la profondità del libro (in cm): ");
double profonditaLibroUtente = double.Parse(Console.ReadLine());

Console.Write("Inserire il numero totali di recensioni presenti sul sito: ");
int numeroRecensioniUtente = double.Parse(Console.ReadLine());

Console.Write("Inserire la valutazione media delle recensioni presenti sul sito: ");
double valutazioneMediaUtente = double.Parse(Console.ReadLine());
int maxValutazione = 5;

Console.Write("È disponibile la versione kindle del libro? Scrivere si o no");
string versioneKindleUtente = Console.ReadLine();

Console.Write("È disponibile la copertina flessible del libro? Scrivere si o no");
string copertinaFlessibileUtente = Console.ReadLine();


Console.WriteLine("------ IL LIBRO DI OGGI: " + titoloUtente + " di " + autoreUtente + " ------");
Console.WriteLine("Informazioni generiche:");
Console.WriteLine("ISBN: " + isbnUtente);
Console.WriteLine("Numero delle pagine: " + numeroPagineUtente + " pagine");
Console.WriteLine("Peso del libro: " + pesoLibroUtente + " g");
Console.WriteLine("Dimensioni del libro: " + larghezzaLibroUtente + " cm x " + altezzaLibroUtente + " cm x " + profonditaLibroUtente + " cm");

Console.WriteLine("");

Console.WriteLine("Informazioni Amazon:");
Console.WriteLine("Numero di recensioni: " + numeroRecensioniUtente);
Console.WriteLine("Valutazione media delle recensioni: " + valutazioneMediaUtente + " / " + maxValutazione + " stelle");

Console.WriteLine("---------------------------------------------------------------");