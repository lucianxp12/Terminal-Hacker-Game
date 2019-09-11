using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{

    //Game state

    int level;
    
    enum Screen {  MainMenu, Password, Win};

    Screen currentScreen = Screen.MainMenu;
    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu();

    }


    void ShowMainMenu()
    {

        Terminal.ClearScreen();
        Terminal.WriteLine("Pe cine vrei sa heckaresti ?");
        Terminal.WriteLine("Apasa 1 pentru Cata");
        Terminal.WriteLine("Apasa 2 pentru Luci");
        Terminal.WriteLine("Apasa 3 pentru altceva");

        Terminal.WriteLine("Raspuns:");


    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnUserInput(string input)
    { 
        switch (input)
        {
            case "1":
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("Hacking Cata");
                    break;
                }
            case "2":
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("Hacking Luci");
                    break;
                }
            case "3":
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("Hacking altceva");
                    break;
                }
            case "menu":
                {
                    Terminal.ClearScreen();
                    ShowMainMenu();
                    break;
                }
            case "Menu":
                {
                    Terminal.ClearScreen();
                    ShowMainMenu();
                    break;
                }
            default:
                {
                    Terminal.ClearScreen();
                    ShowMainMenu();
                    Terminal.WriteLine("Selecteaza ceva ce exista... nu ca ultima data");
                    break;
                }
        }
    }

    void StartGame()
    {
        currentScreen = Screen.Password;
        Terminal.WriteLine("You have chosen level " + level);
        Terminal.WriteLine("Please enter your password: ");
    }
}
