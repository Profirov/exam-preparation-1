int Nploshtadka = int.Parse(Console.ReadLine());
double WshirPlochka = double.Parse(Console.ReadLine());
double Ldaljiplochka = double.Parse(Console.ReadLine());    
int MshirinaPeikA = int.Parse(Console.ReadLine());
int OdaljinaPeikA = int.Parse(Console.ReadLine());


double sqare = Nploshtadka * Nploshtadka;
double bench = MshirinaPeikA * OdaljinaPeikA;
double sqareToBeCovered = sqare - 2;
double plochkaSqare = WshirPlochka * Ldaljiplochka;
double nededTiles = sqareToBeCovered / plochkaSqare;
double neededTime = nededTiles * 0.2;

Console.WriteLine(nededTiles);
Console.WriteLine(neededTime);