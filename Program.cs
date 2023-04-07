Console.Write("Input amount of numbers: ");
var size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

vr maxNumber = int.MaxValue;
var minNumber = int.MinValue;
for (var i = 0; i < size; i++)
{
    Console.Write("Input the number: ");
    var number = Convert.ToInt32(Console.ReadLine());
    
    if (number > maxNumber)
    {
        maxNumber = number;
    }
    if (number < minNumber)
    {
        minNumber = number;
    }
}

Console.WriteLine($"Maximal number is {maxNumber} and minimal is {minNumber}.");
