String[] InputArray = {"2","Milan",":-)"};
int length = InputArray.Length;

String[] OutputArray = new String[length];

for (int i = 0, k = 0; i < length; i++)
{
    if (InputArray[i].Length <= 3)
    {
        OutputArray[k] = InputArray[i];
        k++;
    }    
}

// while-cycle using: 
// while (i < length)
// {
//     if (InputArray[i].Length <= 3)
//     {
//         OutputArray[k] = InputArray[i];
//         k++;
//     }
//     i++;   
// }

System.Console.WriteLine();
foreach (string element in OutputArray)
{
    Console.Write($"{element} ");
}