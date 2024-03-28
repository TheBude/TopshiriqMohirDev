Console.WriteLine("Assalomu allaykum men doirani yuzi va aylana uzinligini hisoblaydigan dasturman");
Console.Write("Doira radiusini kiring:  ");

string radius = Console.ReadLine();
int copyRadius = Convert.ToInt32(radius);
Console.WriteLine($"Doira yuzasi S =  {copyRadius * copyRadius * 3.141516}");
Console.WriteLine($"Doira uzunligi L =  {2 * copyRadius * 3.141516}");

