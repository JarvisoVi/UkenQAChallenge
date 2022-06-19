using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

class LeastRepeatedNumber
{
    public void LowestFreq(string file)
    {
        int count = 0;
        int lowestCount = 1000;
       
        // Reads each line
        List<int> listofNum = new List<int>();

        //Prints each line in text file
        foreach (string line in File.ReadLines(file))
        {
            listofNum.Add(int.Parse(line));
        }

        listofNum.Sort(); // Sorts the list 
        int answer = 0; // Length of the array

        //Determine the least frequent number in a file  
        for (int i = 0; i < listofNum.Count; i++)
        {
            //Counts each number in the file and store it in variable count  
            for (int j = 0; j < listofNum.Count; j++)
            {
                if (listofNum[i] == (listofNum[j]))
                {
                    count++;
                }
            }
            if (count == lowestCount) 
            {
                if (answer > listofNum[i])
                {
                    lowestCount = count;
                    answer = listofNum[i];
                }
            }
            else if (count < lowestCount)
            {
                lowestCount = count;
                answer = listofNum[i];
            }
            
            count = 0; // Reset the counter

        }

        // Trims the file output string
        string fileTrim = file.Remove(0,13);

        Console.WriteLine("File: " + fileTrim + ", Number: " + answer + ", Repeated: " + lowestCount);
    }
    static void Main(string[] args)
    {
        //Outputs all the text files
        LeastRepeatedNumber leastRepeatedNumber = new LeastRepeatedNumber();
        leastRepeatedNumber.LowestFreq("../../../src/1.txt");
        leastRepeatedNumber.LowestFreq("../../../src/2.txt");
        leastRepeatedNumber.LowestFreq("../../../src/3.txt");
        leastRepeatedNumber.LowestFreq("../../../src/4.txt");
        leastRepeatedNumber.LowestFreq("../../../src/5.txt");

        Console.ReadLine();
    }
}