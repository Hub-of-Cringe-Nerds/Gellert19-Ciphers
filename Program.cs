using System;
using System.IO;

class Cipher
{
    static void Main()
    {
        const string FILE = @"C:\Users\golde\Downloads\Plain.txt";
        const string SCHL = @"C:\Users\OliverDixon\Downloads\Plain.txt";

        System.IO.StreamReader sr = new System.IO.StreamReader(SCHL);

        var data = new List<string>();

        int[] tally = new int[26];

        while (!sr.EndOfStream)
        {
            data.Add(sr.ReadLine()!);

            foreach (var line in data)
            {
                foreach (var ch in line)
                {
                    if (((int)ch) <= ((int)'Z') && ((int)ch) >= ((int)'A'))
                    {
                        tally[(int)ch - 65]++;
                    }
                }
            }
        }

        Console.WriteLine("A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z");

        for (int i = 0; i < 26; i++)
        {
            Console.Write(tally[i] + ",");
        }

        Console.ReadLine();
    }
}