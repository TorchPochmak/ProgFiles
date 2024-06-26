#include <bits/stdc++.h>

using namespace std;
int main()
{
    // одно и то же
    short i00 = INT16_MAX;
    short int i01 = INT16_MIN;
    signed short i02 = INT16_MAX;
    signed short int i03 = INT16_MIN;

    // одно и то же
    int i10 = INT32_MAX;
    signed i11 = INT32_MAX;
    signed int i12 = INT32_MIN;

    // одно и то же
    #ifdef __unix__
    long i20 = INT64_MIN; 
    long int i21 = INT64_MAX; 
    signed long i22 = INT64_MAX; 
    signed long int i23 = INT64_MIN; 
    #endif
    #ifdef _WIN32
    long i20 = INT32_MIN; 
    long int i21 = INT32_MAX; 
    signed long i22 = INT32_MAX; 
    signed long int i23 = INT32_MIN; 
    #endif

    // одно и то же
    long long i30 = INT64_MAX;
    long long int i31 = INT64_MIN;
    signed long long i32 = INT64_MAX;
    signed long long int i33 = INT64_MIN;

    unsigned short a = UINT16_MAX;
    unsigned a1 = UINT32_MAX;
    #ifdef __unix__
    unsigned long a2 = UINT64_MAX;
    #endif
    #ifdef _WIN32
    unsigned long a2 = UINT32_MAX;
    #endif
    unsigned long long a3 = UINT64_MAX;

    float x = .5f;
    double x1 = 1.;

    cout << "Short size: " << sizeof(short) << '\n'; // 2
    cout << "Int size: " << sizeof(int) << '\n'; // 4
    cout << "Long size: " << sizeof(long) << '\n'; // 4(Win) 8(Linux)
    cout << "Long Long size: " << sizeof(long long) << '\n'; // 8
    cout << "Float size: " << sizeof(float) << '\n'; // 4
    cout << "Double size: " << sizeof(double) << '\n'; //8
}