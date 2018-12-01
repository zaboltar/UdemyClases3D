using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {



    // Use this for initialization
    void Start() {
        
        ShowMainMenu();
    }

    void ShowMainMenu() {

        Terminal.ClearScreen();
        Terminal.WriteLine("What kind of beer do you want?");
        Terminal.WriteLine("Press 1 for a Cuzqueña");
        Terminal.WriteLine("Press 2 for a Pilsen");
        Terminal.WriteLine("Press 3 for a Budweiser");
        Terminal.WriteLine("Enter your selection: ");
     // Terminal.ClearScreen();
    }

    void OnUserInput(string input)
    {
        Terminal.WriteLine("User choosed: " + input);

        if (input == "1") {
            Terminal.WriteLine("You choose wisely 1");
        } else if (input == "menu")
        {
            ShowMainMenu();

        } else if (input == "2") {

            Terminal.WriteLine("You choose circumstantially 2");

        } else if (input == "3") {

            Terminal.WriteLine("You choose unexpectedly 3");

        }

        else {
            Terminal.WriteLine("Enter a valid Input, you drunk-ass");
        }

        //Terminal.WriteLine("User choosed: " + input); do it first
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
