Console.WriteLine("Salom men EURO/USZ kurs hisoblash uchun kalkulyatrman");
Console.Write("Sizda necha EURO bor:  ");

string euro = Console.ReadLine();
int copyEuro = Convert.ToInt32(euro);
int hisob = copyEuro * 13650;

Console.WriteLine($"Sizning EURO valyutangiz so'mga hisoblaganda: {hisob} So'm");
Console.WriteLine("Bizdan foydalanganingiz uchun rahmat!!!");
