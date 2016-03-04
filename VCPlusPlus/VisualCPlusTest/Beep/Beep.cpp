#include<iostream> // no .h
#include<iomanip> // no .h
#include <windows.h> // keep the .h on this
using namespace std;

int main()
{
	Beep(343, 444); // frequency in hurtz, duration in milliseconds
	Beep(422, 322);
	// etc
	return EXIT_SUCCESS; // the program ran successfully! w00t!
}