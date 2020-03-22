using System;
using System.Linq;

public class Compare
{
	public void IsSame(string[] arrayOne, string[] arrayTwo)
	{
        //Compares the two arrays and if the returned boolean is false, the program tells the user the files are different
        //otherwise it tells the user they're the same
        if (!Enumerable.SequenceEqual(arrayOne, arrayTwo))
        {
            Console.WriteLine("These files are not the same");
        }
        else
        {
            Console.WriteLine("These files are the same");
        }
    }
}
