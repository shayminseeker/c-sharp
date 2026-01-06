using System.Linq.Expressions;

int a = 1;
int b = 0;
Console.WriteLine("a: " + a + " b: " + b);
//swap ints
int temp = 0;
temp = a;
a = b;
Console.WriteLine("a: " + a + " b: " + b);

string name = "Lucas";
int age = 17;
string hometown ="Hyrum";
Console.WriteLine( name +" is from" + hometown + " and is " + age + " years old");

double celcius;
Console.ReadLine("Enter a temperature in Celcius: ");
double fahrenheit = (celcius * 9/5) + 32;
Console.WriteLine(celcius + " degrees Celsius is equivalent to " + fahrenheit + " degrees Fahrenheit");

double width;
double height;
Console.ReadLine("Enter the width of a rectangle: ");
Console.ReadLine("Enter the height of a rectangle: ");
double area = width * height;
Console.WriteLine("The area of the rectangle is: " + area);

int luck = 1;
double chance = .002;
string color = "blue";
char rarity = 'S';
bool isLucky = true;
Console.WriteLine(luck.GetType() + "\n" + chance.GetType() + "\n" + color.GetType() + "\n" + rarity.GetType() + "\n" + isLucky.GetType());

//statements and stuff

int calculation = 34 * 17 - 12/6;
calculation -= (9*3);
Console.WriteLine(calculation);

//expression 1
Console.WriteLine((4 * (7 - 9) + 11) / 3);
int ex1 = (4 * (7 - 9) + 11) / 3;
Console.WriteLine(ex1);
//expression 2
Console.WriteLine(3 == 2 && 4>1) || false ;
int ex2 = (3 == 2 && 4>1) || false;
Console.WriteLine(ex2);
//expression 3
Console.WriteLine(32.1-3.445) *17.7 /(2.38 +21.9);
double ex3 = (32.1-3.445) *17.7 /(2.38 +21.9);
Console.WriteLine(ex3);

//expression 1.a
Console.WriteLine(4 * 7 - 9 + 11 / 3);
int ex1 = 4 * 7 - 9 + 11 / 3;
Console.WriteLine(ex1);
//expression 2.a
Console.WriteLine(3 == 2 && 4>1 || false);
int ex2 = 3 == 2 && 4>1 || false;
Console.WriteLine(ex2);
//expression 3.a
Console.WriteLine(32.1-3.445 *17.7 /2.38 +21.9);
double ex3 = 32.1-3.445 *17.7 /2.38 +21.9;
Console.WriteLine(ex3);
//Type-inffered
int declared = 28;
var inferred = declared * 2.13;
bool isDeclared = true;
var isInferred = 2 > 3;
var alsoInferred = $"{inferred}";
Console.WriteLine(declared.GetType());
Console.WriteLine(inferred.GetType());
Console.WriteLine(isDeclared.GetType());
Console.WriteLine(isInferred.GetType());
Console.WriteLine(alsoInferred.GetType());