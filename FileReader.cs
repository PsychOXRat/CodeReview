using System;
using System.Collections.Generic;
using System.IO;
public class FileReader
{
	//Creates class fields
	public string[] file1a;
	public string[] file1b;
	public string[] file2a;
	public string[] file2b;
	public string[] file3a;
	public string[] file3b;

	//Creates class method to read all files and assign them to an array
	public void FileReadAll()
	{
		//Initialises the variable used in the reader
		string line;

        try
        {
            StreamReader sr = new StreamReader("GitRepositories_1a.txt");
            List<string> addList = new List<string>();

            //Reads the file until the end of the file
            while (!sr.EndOfStream)
            {
                //Uses the ReadLine method to set the line vairable to the read line
                line = sr.ReadLine();
                //Adds the line to the list that is turned to an array 
                addList.Add(line);
            }
            //Closes the text file
            sr.Close();
            //Turns the list into an array and equals the array to it
             file1a = addList.ToArray();
        }
        //If there is an error, the error message is given here
        catch (Exception E)
        {
            Console.WriteLine("exception: " + E.Message);
        }
        try
        {
            StreamReader sr = new StreamReader("GitRepositories_1b.txt");
            List<string> addList = new List<string>();

            //Reads the file until the end of the file
            while (!sr.EndOfStream)
            {
                //Uses the ReadLine method to set the line vairable to the read line
                line = sr.ReadLine();
                //Adds the line to the list that is turned to an array 
                addList.Add(line);
            }
            //Closes the text file
            sr.Close();
            //Turns the list into an array and equals the array to it
            file1b = addList.ToArray();
        }
        //If there is an error, the error message is given here
        catch (Exception E)
        {
            Console.WriteLine("exception: " + E.Message);
        }

        try
        {
            StreamReader sr = new StreamReader("GitRepositories_2a.txt");
            List<string> addList = new List<string>();

            //Reads the file until the end of the file
            while (!sr.EndOfStream)
            {
                //Uses the ReadLine method to set the line vairable to the read line
                line = sr.ReadLine();
                //Adds the line to the list that is turned to an array 
                addList.Add(line);
            }
            //Closes the text file
            sr.Close();
            //Turns the list into an array and equals the array to it
            file2a = addList.ToArray();
        }
        //If there is an error, the error message is given here
        catch (Exception E)
        {
            Console.WriteLine("exception: " + E.Message);
        }
        try
        {
            StreamReader sr = new StreamReader("GitRepositories_2b.txt");
            List<string> addList = new List<string>();

            //Reads the file until the end of the file
            while (!sr.EndOfStream)
            {
                //Uses the ReadLine method to set the line vairable to the read line
                line = sr.ReadLine();
                //Adds the line to the list that is turned to an array 
                addList.Add(line);
            }
            //Closes the text file
            sr.Close();
            //Turns the list into an array and equals the array to it
            file2b = addList.ToArray();
        }
        //If there is an error, the error message is given here
        catch (Exception E)
        {
            Console.WriteLine("exception: " + E.Message);
        }

        try
        {
            StreamReader sr = new StreamReader("GitRepositories_3a.txt");
            List<string> addList = new List<string>();

            //Reads the file until the end of the file
            while (!sr.EndOfStream)
            {
                //Uses the ReadLine method to set the line vairable to the read line
                line = sr.ReadLine();
                //Adds the line to the list that is turned to an array 
                addList.Add(line);
            }
            //Closes the text file
            sr.Close();
            //Turns the list into an array and equals the array to it
            file3a = addList.ToArray();
        }
        //If there is an error, the error message is given here
        catch (Exception E)
        {
            Console.WriteLine("exception: " + E.Message);
        }
        try
        {
            StreamReader sr = new StreamReader("GitRepositories_3b.txt");
            List<string> addList = new List<string>();

            //Reads the file until the end of the file
            while (!sr.EndOfStream)
            {
                //Uses the ReadLine method to set the line vairable to the read line
                line = sr.ReadLine();
                //Adds the line to the list that is turned to an array 
                addList.Add(line);
            }
            //Closes the text file
            sr.Close();
            //Turns the list into an array and equals the array to it
            file3b = addList.ToArray();
        }
        //If there is an error, the error message is given here
        catch (Exception E)
        {
            Console.WriteLine("exception: " + E.Message);
        }
        //Once the files are all written, the program lets the user know that all the files have been read correctly
        finally
        {
            Console.WriteLine("Finished reading all files.");
        }
    }
}
