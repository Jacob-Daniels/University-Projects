#include <iostream>
#include <string>
using namespace std;
void DNAreverse(string S, string Y, string L, string R);
bool CheckSubstring(string S, string Y, string L, string R);
void ReverseString(char* str, int start, int end);
void LowerCase(char* c);

int main()
{
    string S = "y", Y, L, R;
    string oldString = "";

    while (S == "y") {
        // Get string to search
        cout << "===================================================" << endl << "Enter a string: ";
        getline(cin >> ws, S);
        oldString = S;
        // Get pattern
        cout << endl << "Enter a pattern to search in the string: ";
        getline(cin >> ws, Y);
        // Get prefix
        cout << endl << "Enter a prefix for the pattern: ";
        getline(cin >> ws, L);
        // Get Suffix
        cout << endl << "Enter a suffix for the pattern: ";
        getline(cin >> ws, R);

        // Check string L + Y + R exists in S
        if (CheckSubstring(S, Y, L, R)) {
            // Reverse all occurances of substring
            cout << endl << "True: ";
            DNAreverse(S, Y, L, R);
        }
        else {
            cout << endl << "False:\nThe string '" << L << Y << R << "' was not found in '" << S << "'";
        }

        // Reset loop
        cout << endl << endl << "Type 'y' to try another string: ";
        getline(cin >> ws, S);
        LowerCase(&S[0]);
        cout << endl;
    }
}

void LowerCase(char* c) {
    // Make character lowercase
    *c = tolower(*c);
}

void DNAreverse(string S, string Y, string L, string R) {
    int index = 0;
    while ((index = S.find(Y, index)) != string::npos) {
        // Ensure L string is within bounds of string S (prevent error)
        if (L.length() <= S.substr(0, index).length()) {
            // Check the string Y is between string L and R at current index
            if (S.substr(index - L.length(), L.length()) == L && S.substr(index + Y.length(), R.length()) == R) {
                // Reverse string between given index
                string newString = S;
                ReverseString(&newString[index], index, index + Y.length());
                // Output every occurance of the reversed string
                cout << endl << "New string: " << newString;
            }
        }
        index += Y.length();
    }
}

void ReverseString(char* str, int start, int end) {
    char* endstring = str;

    // Move endstring to the end of the string
    while (start + 1 != end) {
        start++;
        endstring++;
    }

    // Reverse string
    char temp;
    while (endstring > str) {
        temp = *str;
        *str = *endstring;
        *endstring = temp;
        endstring--;
        str++;
    }
}

bool CheckSubstring(string S, string Y, string L, string R) {
    // Check string 'S' has at least 1 occurance of string 'L + Y + R'
    int index = 0;
    while ((index = S.find(Y, index)) != string::npos) {
        // Ensure string L is within bounds of string S (prevent error)
        if (L.length() <= S.substr(0, index).length()) {
            // Check Y is between L and R in string S
            if (S.substr(index - L.length(), L.length()) == L && S.substr(index + Y.length(), R.length()) == R) {
                return true;
            }
        }
        index += Y.length();
    }
    return false;
}