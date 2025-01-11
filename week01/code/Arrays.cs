using System;
using System.Collections.Generic;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.
    /// For example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.
    /// Assume that length is a positive integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // Step 1: Create an array of size 'length' to hold the multiples.
        double[] multiples = new double[length];

        // Step 2: Use a loop to calculate and populate each multiple.
        // - Start from 0 and go up to (length - 1).
        // - For each index, multiply the number by (index + 1) to get the multiple.
        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }

        // Step 3: Return the filled array of multiples.
        return multiples;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.
    /// For example, if the data is List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3,
    /// then the list after the function runs should be List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.
    /// The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Step 1: Calculate the effective rotation.
        // - Since rotating by the size of the list (or its multiple) results in the same list,
        //   we use the modulo operator to find the actual amount of rotation.
        amount = amount % data.Count;

        // Step 2: Split the list into two parts:
        // - The last 'amount' elements form the first part of the rotated list.
        // - The rest of the elements form the second part.
        List<int> lastPart = data.GetRange(data.Count - amount, amount);
        List<int> firstPart = data.GetRange(0, data.Count - amount);

        // Step 3: Clear the original list and add the rotated parts in order.
        data.Clear();
        data.AddRange(lastPart);
        data.AddRange(firstPart);
    }
}
