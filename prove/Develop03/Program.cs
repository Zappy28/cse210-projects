using System;

class Program
{
    static void Main(string[] args)
    {
        Word myWord = new Word("Bonjour");

        myWord.DisplayWord();
        myWord.hide();
        myWord.DisplayWord();
    }
}