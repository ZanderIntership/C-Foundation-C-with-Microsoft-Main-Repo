using System.Diagnostics.Metrics;

string pangram = "The quick brown fox jumps over the lazy dog";

string[] Revised = new string[8];
int Count = 0;

string[] words = pangram.Split(' ');

for (int I = 0; I < words.Length; I++)
{
    words[I] = new string(words[I].Reverse().ToArray());
    Console.Write($"{words[I]} ");
}

