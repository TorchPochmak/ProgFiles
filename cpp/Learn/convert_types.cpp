#include <bits/stdc++.h>

using namespace std;
typedef unsigned long long ull;

int main() {
	bool a = true; // bool
	int a_int = a; //bool -> int
	string a_string = to_string(a); // bool -> int -> string

	int b = 4; // int
	bool b_bool = b; // int -> bool
	string b_string = to_string(b); // int -> string
	char b_ASCII = char(b); // int -> char
	char b_symbol = char('0' + b); // int -> char (digit value)

	string c = "56"; // string
	bool c_bool = c.size(); 
	int c_int = stoi(c); // string -> int
	long long c_long = stoll(c); // string -> long long
	const char* c_char_pointer = c.c_str(); // string -> char*
    //c style
	vector<char> c_char_arr(c.c_str(), c.c_str() + c.size()); // string -> vector<char>
    //cpp style
	vector<char> vec2(c.size());
	vec2.assign(c.begin(), c.end()); // string -> vector<char>

	char d = '6'; // char
	bool d_bool = d; //char -> int -> bool
	int d_int = d - '0'; //char -> int (digit value)
	string d_string(1, d); // char -> string
}
