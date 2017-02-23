using System.Linq;

public class Kata
{
    public static int GetLengthOfMissingArray(object[][] arrayOfArrays)
    {
        // If the array of arrays is null/nil or empty, the method should return 0.
        if (arrayOfArrays == null || arrayOfArrays.Length == 0) return 0;

        // When an array in the array is null or empty, the method should return 0 too!
        foreach (var array in arrayOfArrays)
        {
            if (array == null || array.Length == 0) return 0;
        }

        // reduce the array of arrays to array of lengths
        // sort
        int[] sortedListOfLengths = arrayOfArrays
                        .Select(array => array.Count())
                        .OrderBy(count => count)
                        .ToArray<int>();

        // get the missing integer
        for (int i = 0; i < sortedListOfLengths.Length - 1; i++)
        {
            if (sortedListOfLengths[i + 1] != sortedListOfLengths[i] + 1) 
                return sortedListOfLengths[i] + 1;
        }

        return 0;
    }
}

