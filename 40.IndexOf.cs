﻿string text = "Hallo Welt!";
string search = "ll";

int idx = -1; // Speichert das Ergebnis (-1 bedeutet „nicht gefunden“)


for (int i = 0; i <= text.Length - search.Length && idx == -1; i++)
{
    int n;
    for (n = 0;n < search.Length && text[i + n] == search[n];
         n++)
    {

    }

    if (n == search.Length) 
    {
        idx = i; 
    }
}

Console.WriteLine($"\"{search}\" in \"{text}\" at index {idx}");

//Alternative mit IndexOf:

//string text = "Hallo Welt!";
//string search = "ll";
//int idx = text.IndexOf(search);
//Console.WriteLine($"\"{search}\" in \"{text}\" at index {idx}");



