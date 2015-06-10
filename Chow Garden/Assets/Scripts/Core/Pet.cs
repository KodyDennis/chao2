using System.Collections;


public class Pet {

	//Variables
	string name;						//Name of the pet, c'mon man
	string type;						//Type for stat favor
	string color;						//Cosmetic color
	string temperment;					//Personality type
	string mood;						//Temporary mood

	//Main stats
	int ferocity = 0;
	int moxie = 0;
	int hustle = 0;
	int cuteness = 0;
	int smarts = 0;
	int luck = 0;

	//Max stats
	int ferocityMax = 100;
	int moxieMax = 100;
	int hustleMax = 100;
	int cutenessMax = 100;
	int smartsMax = 100;
	int luckMax = 100;

	//Equips
	string[] equips;					//Cosmetic
	string[] trinkets;					//Stat gainers

	//Constructor
	Pet (string newName, string newType, string newColor, string newTemperment){
		name = newName;
		type = newType;
		color = newColor;
		temperment = newTemperment;
		mood = "Indifferent";

		switch(type) {
		//Vanilla pet types
		case "Ferocious":
			ferocity = 10;
			break;
		case "Stalwart":
			moxie = 10;
			break;
		case "Speedy":
			hustle = 10;
			break;
		case "Adorable":
			cuteness = 10;
			break;
		case "Enlightened":
			smarts = 10;
			break;
		case "Gambler":
			luck = 10;
			break;
		//Add new pet hybrid cases below

		//Stupid god type
		case "Divine":
			ferocity = 10;
			moxie = 10;
			hustle = 10;
			cuteness = 10;
			smarts = 10;
			luck = 10;
			break;
		}

	}
	
}
