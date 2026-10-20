using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        bool again = true;
        Menu runMenu = new Menu();

        while (again != false)
        {
            int choice = runMenu.DisplayMenu();

            if (choice == 5)
            {
                again = false;
            }

            runMenu.ChoiceNavigation(choice);
        }
    }
}