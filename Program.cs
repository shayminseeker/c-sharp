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

Console.WriteLine((4 * (7 - 9) + 11) / 3);
int ex1 = (4 * (7 - 9) + 11) / 3;
Console.WriteLine(ex1);