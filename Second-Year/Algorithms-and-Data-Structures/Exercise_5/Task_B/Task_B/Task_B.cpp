#include <iostream>
#include <string>
using namespace std;
bool FindSubstringCon(string S, string Y, string P, string Q);
void LowerCase(char* c);

int main()
{
    string S = "y", Y, P, Q;
    while (S == "y") {
        // Get string to search
        cout << "===================================================" << endl << "Enter a string: ";
        getline(cin >> ws, S);
        // Get pattern
        cout << endl << "Enter a pattern to search in the string: ";
        getline(cin >> ws, Y);
        // Get prefix
        cout << endl << "Enter a prefix for the pattern: ";
        getline(cin >> ws, P);
        // Get Suffix
        cout << endl << "Enter a suffix for the pattern: ";
        getline(cin >> ws, Q);

        // Display result
        if (FindSubstringCon(S, Y, P, Q)) {
            cout << endl << "True:\nThe string '" << P << Y << Q << "' is within the string '" << S << "'";
        }
        else {
            cout << endl << "False:\nThe string '" << P << Y << Q << "' is NOT within the string '" << S << "'";
        }

        // Reset loop
        cout << endl << endl << "Type 'y' to try another string: ";
        getline(cin >> ws, S);
        LowerCase(&S[0]);
        cout << endl;
    }
}

void LowerCase(char* c) {
    *c = tolower(*c);
}

bool FindSubstringCon(string S, string Y, string P, string Q) {
    // Check pattern has a prefix and suffix that is equal to what the user entered
    int index = 0;
    while ((index = S.find(Y, index)) != string::npos) {
        // Check prefix is in bounds of string (prevent error)
        if (P.length() <= S.substr(0, index).length()) {
            // Check prefix then suffix are equal to string entered
            if (S.substr(index - P.length(), P.length()) == P && S.substr(index + Y.length(), Q.length()) == Q) {
                return true;
            }
        }
        index++;
    }
    return false;
}