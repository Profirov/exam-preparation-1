double zelenKg = double.Parse(Console.ReadLine());
double fruitKg = double.Parse(Console.ReadLine());
int fruall = int.Parse(Console.ReadLine());
int zalall = int.Parse(Console.ReadLine());

double zelenCost = zelenKg * 10;
double fruitCost = fruitKg * 10;
double sumTotall = (zelenCost + fruitCost) / 1.94;

Console.WriteLine(sumTotall);
