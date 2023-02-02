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


class CSVThings
{
    class Book
    {
        public string title;
        public int year;
        public double price;
    }

    static void Main()
    {
        Book book;
        List<Book> books = new List<Book>();
        StreamReader sr = new StreamReader(@"C:\Users\OliverDixon\Downloads\somedata.csv");
        
        while(!sr.EndOfStream)
        {
            string line = sr.ReadLine()!;
            string[] data = line.Split(',');

            book = new Book();
            book.title = data[0];
            book.year = int.Parse(data[1]);
            book.price = double.Parse(data[2]);
            books.Add(book);
        }
    }
}