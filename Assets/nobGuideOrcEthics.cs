using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nobGuideOrcEthics : MonoBehaviour {

	
	const string welcome = "welcome to a nobleman guide to orc ethics";
	const string death = "death is final, and so is your path, oblivion embraces you";
	
	

	int level;
	enum Screen { Base, Win, Death};
	Screen currentScreen;
	//string code;

	//string[] storyText = {}


	void Start () {

		ShowBaseScreen();

		
	}

	void ShowBaseScreen() {

		currentScreen = Screen.Base;
		Terminal.ClearScreen();
		Terminal.WriteLine(welcome);
		Terminal.WriteLine("write with blood to start");
	}
	

	void OnUserInput(string input) {

		if (input == "with blood") {
			GoToLevel1();

		} else if (input == "restart") {
			Restart();
		} else if (input == "orc") {
			Terminal.WriteLine("there is no orc, only the pack");
			Terminal.WriteLine("dont you ever cast individuality upon orcself");
		} else if (input == "orcs") {
			GoToLevel2();
		} else 	if (input == "Death" || input == "DEATH") {
			Terminal.WriteLine("you are a brave one... and also a fool one");
			Die();
		} else if (input == "death") {
			GoToLevel3();
		} else if (input == "load") {
			GoToLevel4();
		} else if (input == "elven bow" || input == "elven fancy light refreshment" || input == "elven rain god")  {
			Terminal.WriteLine("really?... elv...dude its in the f@!%#ing first word");
			Die();
		} else if (input == "axe") {
			GoToLevel5();	
		} else if (input == "continue") {
			GoToLevel6();	
		} else if (input == "humans") {
			Terminal.WriteLine("remember this, noble orc, humans are distasteful");	
		} else if (input == "meat") {
			Terminal.WriteLine("not just any meat... dont be lazy to type down");	
		} else if (input == "red juicy and bloody meat") {
			GoToLevel7();
		} else if (input == "beer") {
			GoToLevel8();
		} else if (input == "savage") {
			GoToLevel9();
		} 	else if (input == "strength") {
			Terminal.WriteLine("strength is good but there are better choices for a noble orcbeing");
		} else if (input == "intelligence") {
			GoToLevel10();
		} else if (input == "none") {
			GoToLevel11();
		} else if (input == "cave") {
			Terminal.WriteLine("you have won, write with blood to continue your training...");
			//GoToLevel12();
		}

		/*

		else if (input == "") {
			GoToLevel10();
		}

		Terminal.WriteLine("")

		else if (input == "") {
			Terminal.WriteLine("")
		}

	

		*/

		else {
			Die();
		}


	}

	void GoToLevel1(){
		Terminal.ClearScreen();
		Terminal.WriteLine("it is important for you to know....");
		Terminal.WriteLine("... that <orcs> always write in lowercase and can time-travel.");
		Terminal.WriteLine("it´s a theological thing, dont get me started on it...");
		Terminal.WriteLine("write down who must never use uppercase and cant avoid linearity in time...");
	}

	void GoToLevel2() {
		Terminal.ClearScreen();
		Terminal.WriteLine("GOOO....ooood ... oops, well sometimes");
		Terminal.WriteLine("special orcs like myself can use UpperCase");
		Terminal.WriteLine("but is a power few possess...dont you ever try it...");
		Terminal.WriteLine("or... maybe... do it, write <Death> as orcS should do it");
	}

	void GoToLevel3() {
		Terminal.ClearScreen();
		Terminal.WriteLine("well, you must know and remember the words");
		Terminal.WriteLine("cause that´s your progress");
		Terminal.WriteLine("type <load> to start your training");
		Terminal.WriteLine("and remember to <load> your progress with key words if you die");
	}

	void GoToLevel4() {
		Terminal.ClearScreen();
		Terminal.WriteLine("your training consist in answer what an orc should do");
		Terminal.WriteLine("guiding orcself upon the noble path of orcmanship");
		Terminal.WriteLine("now choose wisely your weapon");
		Terminal.WriteLine("an <axe>, a <flower> or <elven bow>");
	}

	void GoToLevel5() {
		Terminal.ClearScreen();
		Terminal.WriteLine("nooo. well... yes, but first");
		Terminal.WriteLine("orcs use their minds, and gather intelligence");
		Terminal.WriteLine("and only after it, they choose brutality");
		Terminal.WriteLine("now type <continue> to resume your training");
	}

	void GoToLevel6() {
		Terminal.ClearScreen();
		Terminal.WriteLine("sometimes you need to travel in time");
		Terminal.WriteLine("but we wont get there yet...");
		Terminal.WriteLine("now, imagine that you have to eat... choose, and dont be an elf about it");
		Terminal.WriteLine("you can have <salad>, <fruits>, <humans> or <red juicy and bloody meat>");
	}
	
	void GoToLevel7() {
		Terminal.ClearScreen();
		Terminal.WriteLine("yes, now: thats how we like to feast");
		Terminal.WriteLine("what should a gentle orc drink...");
		Terminal.WriteLine("lets say....during a full moon festival?");
		Terminal.WriteLine("some <apple juice>, a barrel of <beer> or some <elven fancy light refreshment>");
	}

	void GoToLevel8() {
		Terminal.ClearScreen();
		Terminal.WriteLine("yea, beer is gonna make the trick, now, to combat strategy:");
		Terminal.WriteLine("imagine the chief gives you ten riders to pillage a town");
		Terminal.WriteLine("how do you raid to loot and plunder?");
		Terminal.WriteLine("you may <refuse> the command, ask for a <peace treaty> with the leader or <savage> the fields");
	}

	void GoToLevel9() {
		Terminal.ClearScreen();
		Terminal.WriteLine("savage is good if the prey is weak");
		Terminal.WriteLine("but is best when the enemy is strong");
		Terminal.WriteLine("because you either die or get stronger");
		Terminal.WriteLine("so...for orcs is better <strength>, <sneakyness> or <intelligence>");
	}
 	
 	void GoToLevel10() {
		Terminal.ClearScreen();
		Terminal.WriteLine("without it you wouldn´t even know about noble and gentle ways.");
		Terminal.WriteLine("the ferocity may be unleashed after a choice is taken.");
		Terminal.WriteLine("now to gods, before geography or time-travel.");
		Terminal.WriteLine("who to worship? <elven rain god>, <farrukgah´thahagar>, <death> or <none>");
	}
	
	void GoToLevel11() {
		Terminal.ClearScreen();
		Terminal.WriteLine("yea, no metaphysical trash for an orc´s expectancy");
		Terminal.WriteLine("life is here and is one, and no soul nor afterlife exists");
		Terminal.WriteLine("now to geography, before time-travel...unless.. nah, i will continue");
		Terminal.WriteLine("or repeat it: where to live? in a <fairy forest>, a <cave> or the <cold ocean>");
		
	}
	/*	

	void GoToLevelX() {
		Terminal.ClearScreen();
		Terminal.WriteLine("");
		Terminal.WriteLine("");
		Terminal.WriteLine("");
		Terminal.WriteLine("");
	}

	*/
	

	void Restart() {
		Terminal.ClearScreen();
		ShowBaseScreen();

	}

	void Die() {
			currentScreen = Screen.Death;
			Terminal.WriteLine(" X_______X !");
			Terminal.WriteLine(death);
			Terminal.WriteLine("***type restart to play again***");
	}


}
