//#include <bits/stdc++.h>
#include <iostream>
#include <vector>
#include <algorithm>
#include <string>

using namespace std;

int main()
{
    string s1, s2 = "", s3{}, s4{""}; 
    cout << s1 << s2 << s3 << s4 << "eh" << '\n'; 
    char c = '!';
    s1 += s2 += "hello";
    cout << s1 << s2 << '\n'; //hellohello
    s3 = s1 + c; //I can concatenate string + string and string + char
    cout << s3 << '\n';//hello!


    try
    {
        char h = s1[10];//restricted! undefined behavior! nothing can catch it
        cout << h << '\n';
        cout << "Catch doesn't work" << '\n';
        //instead it's more safe to use .at(), but more expensive... so... я не знаю че выбрать
        //ну это ниже отловится
        h = s1.at(10);
        cout << "Catch doesn't work" << '\n';
    }
    catch(const exception& e)
    {
        cerr << "Damn! Catch works" << '\n';
    }
    
    s1 = "hey";
    //check is equal
    int tr = s1 == "hey";//1
    s1 = "";
    tr = s1 == "";//1
    tr = s1.empty();//1
    s1 = "hey";
    int len = s1.size(); //equal to s1.length();
    //getline(cin, s2);
    const char* str_old = s1.c_str();//readonly c style...


    s1 = "hello bro";
    string sub = s1.substr(0, 5);//"hello"
    sub = s1.substr(0, 0);//""
    sub = s1.substr(0, 20);//"hello bro" exception
    try
    {
        sub = s1.substr(20, 10);//"" exception!
    }
    catch(const std::exception& e)
    {
        //std::cerr << e.what() << '\n';
    }
    
    int tryfind = s1.find("hell");//returns positiion of foundstr[0] if found or npos(другими словами -1)
    if(tryfind != string::npos)
    {
        cout << "not found...";
    }
    //OR
    //use just contains bro if u need bool
    bool found = s1.contains("bro");//c++ 23 !!!
    //есть еще search, но это совсем такое себе. Можно strstr, но там какой-то косяк с NUL есть
    cout << "End of program.";
    cout << "Before sorting: " << s1 << '\n';
    sort(s1.begin(), s1.end(), [](const char a, const char b) { return a > b; });
    cout << "Sorted string desc: " << s1 << '\n';

    string strange {"h\0\0\0yeah?\0"};//its only "h"...
    cout << strange.size() << '\n';//1
    cout << (int) ("" == "\0") << '\n';//!0 FALSE FALSE FALSE
    string ss1 = "";
    string ss2 = "\0";
    cout << (int) (ss1 == ss2) << '\n';//!1 TRUE TRUE TRUE
    return 0;
}