// Clase para procesar números
using System.Collections.Generic;

public class NumberProcessor
{
    public List<string> ProcessNumbers(List<int> numbers)
    {
        List<string> results = new List<string>();

        foreach (int num in numbers)
        {
            if (num % 2 == 0)
            {
                results.Add($"{num} es Par");
            }
            else
            {
                results.Add($"{num} es Impar");
            }
        }

        return results;
    }
}

