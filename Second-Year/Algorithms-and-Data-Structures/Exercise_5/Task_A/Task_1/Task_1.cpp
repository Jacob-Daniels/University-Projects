#include <iostream>
#include <string>
using namespace std;
void Substitute(char* s, char c1, char c2);
void lowerCase(char* c);

int main()
{
	string userInput = "y", c1, c2;
	// Main loop
	while (userInput == "y") {
		// Get string to replace
		cout << "Enter a string: ";
		getline(cin >> ws, userInput);
		// Get first character
		cout << "Enter a letter to change: ";
		getline(cin >> ws, c1);
		// Get second character
		cout << "Enter a letter to replace " << c1[0] << ": ";
		getline(cin >> ws, c2);
		cout << endl << "Your old string was '" << userInput << "'" << endl;
		// Pass in string and chars to get new string
		Substitute(&userInput[0], c1[0], c2[0]);
		cout << endl << "All characters of '" << c1[0] << "' have been replaced with '" << c2[0] << "'." << endl;
		cout << "Your new string is '" << userInput << "'" << endl << endl;
		// Check whether to loop again
		cout << "Type 'y' to start again:";
		cin >> userInput;
		// Turn input to lowercase to loop again
		lowerCase(&userInput[0]);
		cout << endl;
	}
}

void lowerCase(char* c) {
	*c = tolower(*c);
}

void Substitute(char* str, char c1, char c2) {
	// Loop string to replace c1 characters with c2
	while (*(str) != '\0') {
		if (*str == c1) {
			*str = c2;
		}
		str++;
	}
}