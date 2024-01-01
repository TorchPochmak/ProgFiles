#include <bits/stdc++.h>

using namespace std;

int main()
{
    bool b = true;
    bool bo{true};
    
    char c = 'a';
    char d {'a'};
    
    wchar_t g = 'Л';
    wcout << g << '\n';
    cout << (int)(c == d) << '\n';
    //cout << true == false << '\n'; error...

    cout << "code of a is: " << (int)(char('a')) << '\n';
    cout << "code of a is: " << (int)'a' << '\n';

    cout << "Size of char is " << sizeof('a') << '\n'; // 1
    cout << "Size of char is " << sizeof(g) << '\n'; // 2

}