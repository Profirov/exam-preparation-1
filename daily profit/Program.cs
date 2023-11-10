int workingDAyPerMonth = int.Parse(Console.ReadLine());
double madeMoneyPerDay = double.Parse(Console.ReadLine());  
double kursNaDolara = double.Parse(Console.ReadLine());

double oneMonthSalary = workingDAyPerMonth * madeMoneyPerDay;
double earlyMoney = (oneMonthSalary * 12) + (oneMonthSalary * 2.5);
double danak = earlyMoney * 0.25;
double clearMoney = earlyMoney - danak;
double begeMoney = clearMoney * kursNaDolara;
double moneyPerDay = begeMoney / 365;

Console.WriteLine($"{moneyPerDay:F2}");
