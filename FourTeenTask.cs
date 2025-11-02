string[] values = { "12.3", "45", "ABC", "11", "DEF" };

float T = 0;
float Total = 0;
string NewWord = "";

for (int I = 0; I < values.Length; I++)
{
    bool results = float.TryParse(values[I], out T);

    if (results == true)
    {
        Total += float.Parse(values[I]);
    }
    else
    {
        NewWord += values[I];
    }


}

Console.WriteLine(Total);
Console.WriteLine(NewWord);
