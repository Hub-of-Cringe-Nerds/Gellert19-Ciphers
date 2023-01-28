using System;
using System.IO;

class Cipher
{
    static void Main()
    {
        const string FILE = @"C:\Users\golde\Downloads\Plain.txt";

        System.IO.StreamReader sr = new System.IO.StreamReader(FILE);

        var data = new List<string>();

        int[] tally = new int[26];

        while (!sr.EndOfStream)
        {
            data.Add(sr.ReadLine()!);

            foreach (var line in data)
            {
                foreach (var ch in line)
                {
                    tally[(int)ch - 65]++;
                }
            }
        }
    }
}