double lenght = double.Parse(Console.ReadLine());
double width = double.Parse(Console.ReadLine());

int myLenght = (int)lenght;
int mywidth = (int)width;

int cols = ((int)mywidth - 100) / 70;
int rows = (int)myLenght / 120;


Console.WriteLine((cols * rows) );
