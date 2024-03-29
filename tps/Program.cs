Console.WriteLine("Assalomu allaykum! ");
Console.Write("ismingiz: ");

string name =  Console.ReadLine();
Console.WriteLine($"Tanishganimdan Xursandman {name} !");
Console.Write("Nechanchi yilsiz: ");


int year = Convert.ToInt32( Console.ReadLine() );
int math = 2024 - year;
Console.WriteLine($"Aha {name} demak siz {math} yoshdasiz.");

Console.WriteLine("Sizning necha kun yashaganingizdi hisoblamaoqdamiz...");

int math1 = math * 365;
int math2 = math1 * 24;
Console.WriteLine($"Demak {name} siz {year} dan 2024 yilgacha yashagam kuningiz va yashagan soatingiz \nKun: {math1}\nSoat: {math2}  \nBu juda yaxshi ammo baxt qancha vaqt yashaganlikdamas, qanday yashaganlikda Hurmatli {name}");