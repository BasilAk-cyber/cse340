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

        //Since we are returning an array of doubles we initialize it
        List<double> multiples = new();

        //Iterate by the length we need the array to be
        for (int i = 0; i < length; i++)
        {

            //multiply the number by the amount of time it has been iterated, add 1 since i starts as 0
            double multiple = number * (i + 1);

            //Add the results to list.
            multiples.Add(multiple);
        }
        //type cast list to array and return
        return multiples.ToArray();
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Approach: split the list into two parts - the "tail" (last `amount` elements)
        // and the "head" (first `value` elements). Rebuild the list by putting the
        // tail first, followed by the head, which produces a right rotation.

        //Temporary list to build the rotated result before writing it back to data
        List<int> Rotated = new();

        //Getting index of first char of part of the array to be rotated
        int value = data.Count - amount;

        //Slicing out the untouched part of the array with index of first character and index of char to the right ofthe last untouched char
        List<int> sub = data.GetRange(0, value);

        //iterate from the position of index value
        for (int i = value; i < data.Count; i++)
        {
            //Add into a new array
            Rotated.Add(data[i]);
        }

        foreach (int s in sub)
        {

            //Add untouched chars to end of new array
            Rotated.Add(s);
        }
        //clear the values of data
        data.Clear();      // fixed: actually mutate the caller's list

        //add the value of rotated to data
        data.AddRange(Rotated);

    }
}
