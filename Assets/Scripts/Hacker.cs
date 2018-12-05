using UnityEngine;

public class Hacker : MonoBehaviour {
	
	// Game Config Data
	const string menuHint = "You may type menu at any time";
	string[] lvlCodes = {"Parmenides", "Heraclito", "Pitagoras", "Anaximandro", "Tales" };
	// pero q carajos
	string[] lvl2Codes = {"Leibniz", "Newton", "Spinoza", "Descartes", "Pascal"};
	string[] lvl3Codes = {"Dali", "Rembrandt", "Seurat", "Rubens", "Caravaggio"};


	//game state
	int level;
	enum Screen { MainMenu, Code, Win};
	Screen currentScreen;
	string code;

    
    void Start() {


        ShowMainMenu();
    }

    void ShowMainMenu() {

    	currentScreen = Screen.MainMenu;
        Terminal.ClearScreen();
        Terminal.WriteLine("What kind of beer do you want?");
        Terminal.WriteLine("Press 1 for a Ancient Times");
        Terminal.WriteLine("Press 2 for a Modern Times");
        Terminal.WriteLine("Press 3 for random Painters");
        Terminal.WriteLine("Enter your selection: ");
     
    }

    void OnUserInput(string input) {
     	if (input == "menu")
        {
            ShowMainMenu();

        } else if (currentScreen == Screen.MainMenu) {
        	RunMainMenu(input);
        } else if (currentScreen == Screen.Code) {
        	CheckCode(input);
        }	  	           
    }

    void RunMainMenu(string input) {

    	bool isValidLevelNumberVariable = (input == "1" || input == "2" || input == "3" );

    		if(isValidLevelNumberVariable){
    			level = int.Parse(input);
    			AskForPassword();
    		} else {
            Terminal.WriteLine("Enter a valid Input, you drunk-ass");
            Terminal.WriteLine(menuHint);
        }
    }

    void AskForPassword() {
    	currentScreen = Screen.Code;

    	Terminal.ClearScreen();
		SetRandomCode();  	
    	Terminal.WriteLine("Please Enter Code, hint:" + code.Anagram());
    }

    void SetRandomCode(){
    	switch (level) {


				case 1:
					code = lvlCodes[Random.Range(0, lvlCodes.Length)];
				break;
		    		
		    	case 2:
					code = lvl2Codes[Random.Range(0, lvl2Codes.Length)];
				break;

				case 3:
					code = lvl3Codes[Random.Range(0, lvl3Codes.Length)];
				break;

				default:
			  		Debug.LogError("Invalid Level Number!!!!");
			  	break;
		    	}  
    }
	
	void CheckCode(string input) {
		if (input == code) {
			DisplayWinScreen();
		} else {
			Terminal.WriteLine("Machine will explode soon...");
			AskForPassword();
		}
	}
	
	void Update() {

	}

	void DisplayWinScreen() {
		currentScreen = Screen.Win;
		Terminal.ClearScreen();
		ShowLevelReward();
		Terminal.WriteLine(menuHint);

		
	}

	void ShowLevelReward (){

			switch (level) {
				case 1:
				Terminal.WriteLine("Yes.");
				Terminal.WriteLine(@" 
      x     x

    .         .
      .     .
       .   .
         .

"				);
				break;

				case 2:
				Terminal.WriteLine("Yes.");
				Terminal.WriteLine(@"

					ax

					drunk-ass

					x randomness
					ShowLevelReward
					as
					as

					"

				);
				break;

				case 3:
				Terminal.WriteLine("Yes.");
				Terminal.WriteLine(@" 
      x     x

    .         .
      .     .
       .   .
         .

"				);
				break;

				default:
				  Debug.LogError("invalid lvl reached");
				  break;
			}



		
	}
}
