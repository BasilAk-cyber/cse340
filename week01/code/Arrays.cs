public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Loop through the lenght andfor each iteration multiply by number and add to array then return the array

        List<double> multiples = new();

        for (int i = 1; i < length; i++)
        {
            double multiple = number * i;
            multiples.Add(multiple);
        }

        return multiples.ToArray();
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static int[] RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Approach: split the list into two parts - the "tail" (last `amount` elements)
        // and the "head" (first `value` elements). Rebuild the list by putting the
        // tail first, followed by the head, which produces a right rotation.


        List<int> Rotated = new();

        int value = data.Count - amount;

        List<int> sub = data.GetRange(0, value - 1);

        for (int i = value; i < data.Count; i++)
        {
            Rotated.Add(data[i]);
        }

        foreach (int s in sub)
        {
            Rotated.Add(s);
        }

        return Rotated.ToArray();
    }
}
