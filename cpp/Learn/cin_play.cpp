#include <bits/stdc++.h>

using namespace std;

struct Time
{
	int hours, minutes;
};
istream &operator >> (istream &is, Time &t)
{
	is >> t.hours;
	is.ignore(1,':');
	is >> t.minutes;
	return is;
}
ostream &operator << (ostream &os, Time &t)
{
    os << setfill('0') << setw(2) << t.hours;
    os << ":";
    os << setfill('0') << setw(2) << t.minutes;
    return os;
}

int main()
{
    //11:05 is correctly parsed from stdin;
    Time t1;
    cin >> t1;
    cout << "Hours: " << t1.hours << ' ';
    cout << "Minutes: " << t1.minutes << '\n';

    cout << "Time: " << t1 << '\n'; 
}