int bitcoin = int.Parse(Console.ReadLine());
double chinese = double.Parse(Console.ReadLine());
double comisionera = double.Parse(Console.ReadLine());

double price = bitcoin * 1168;
double ioana = chinese * 0.15;
double bgioani = ioana * 1.76;
double totalmoney = (price + bgioani) / 1.95;
double comisiq = totalmoney * 0.05;
double aidevsichko = totalmoney - comisiq;


Console.WriteLine(aidevsichko);
