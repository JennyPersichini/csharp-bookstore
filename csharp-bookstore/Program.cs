// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");


string titolo = "Clean code";
string autore = "Robert C. Martin";
string isbn = "9788850334384";
int numeroPagine = 431;
int pesoLibro = 800;
double larghezzaLibro = 17.2;
double altezzaLibro = 23.3;
double profonditaLibro = 2.7;
double valutazioneMedia = 4.7;
int maxValutazione = 5;
int numeroRecensioni = 5413;
string versioneKindle = "si";
string copertinaFlessibile = "si";


Console.WriteLine("------ IL LIBRO DI OGGI: " + titolo + " di " + autore + " ------");
Console.WriteLine("Informazioni generiche:");
Console.WriteLine("ISBN: " + isbn);
Console.WriteLine("Numero delle pagine: " + numeroPagine + " pagine");
Console.WriteLine("Peso del libro: " + pesoLibro + " g");
Console.WriteLine("Dimensioni del libro: " + larghezzaLibro + " cm x " + altezzaLibro + " cm x " + profonditaLibro + " cm");

Console.WriteLine("");

Console.WriteLine("Informazioni di Amazon:");
Console.WriteLine("Numero di recensioni: " + numeroRecensioni);
Console.WriteLine("Valutazione media delle recensioni: " + valutazioneMedia + " / " + maxValutazione + " stelline");

Console.WriteLine("Kindle disponibile: " + versioneKindle);
Console.WriteLine("Copertina flessibile disponibile: " + copertinaFlessibile);

Console.WriteLine("---------------------------------------------------------------");
