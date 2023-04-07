Console.Write("Input amount of numbers: ");
var size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
var numbers = new int[size];

for (var i = 0; i < size; i++)
{
    Console.Write("Input the number: ");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}

var maxNumber = numbers[0];
var minNumber = numbers[0];
for (var i = 0; i < size; i++)
{
    if (numbers[i] > maxNumber)
    {
        maxNumber = numbers[i];
    }
    if (numbers[i] < minNumber)
    {
        minNumber = numbers[i];
    }
}


Console.WriteLine($"Maximal number is {maxNumber} and minimal is {minNumber}.");
