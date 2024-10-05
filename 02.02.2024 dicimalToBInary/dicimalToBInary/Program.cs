Console.Write("Enter a decimal number: ");
int decimalInput = int.Parse(Console.ReadLine());
string binaryResult = Convert.ToString(decimalInput, 2);
Console.WriteLine($"Binary equivalent: {binaryResult}");
