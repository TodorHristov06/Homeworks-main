int x = int.Parse(Console.ReadLine());
int rest, decVal = 0, baseVal = 1;

while (x > 0)
{
    rest = x % 10;
    decVal = decVal + rest * baseVal;
    x = x / 10;
    baseVal = baseVal * 2;
}
Console.Write("Decimal: " + decVal);



/*Console.Write("Enter a binary number: ");
string binaryInput = Console.ReadLine();

try
{
    int decimalResult = Convert.ToInt32(binaryInput, 2);
    Console.WriteLine($"Decimal equivalent: {decimalResult}");
}
catch (FormatException)
{
    Console.WriteLine("Skill Issue");
}*/
