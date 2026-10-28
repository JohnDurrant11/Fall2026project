using System;


//A section was added to allow the user to add scriptures to a pre-existing list of scriptures that can be memorized.
//Additionally, a selection can be made from within the list to choose which scripture to use for the program.
class Program
{
    static void Main(string[] args)
    {
        Menu runMenu = new Menu();
        runMenu.MenuRun();
    }
}