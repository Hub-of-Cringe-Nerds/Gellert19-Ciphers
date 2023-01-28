using System;
using System.IO;

const string FILE = @"C:\Users\golde\Downloads\Plain.txt";

streamreader sr = new streamreader(FILE);

var data = List<string>();

int[] tally = new int[26];



while (!sr.endofstream)
{
    data.Add(sr.ReadLine());

    foreach(var line in data)
    {
        foreach (var ch in line)
        {
            tally[(int)ch  - 65]++;
        }
    }
}