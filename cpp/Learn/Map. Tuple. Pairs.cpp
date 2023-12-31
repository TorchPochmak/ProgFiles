#include <bits/stdc++.h>

using namespace std;
typedef long long ll;

bool pred(vector<ll> a, vector<ll> b) 
{
    if (a[1] == b[1]) 
    {
        return a[0] >= b[0];
    }
    else
    {
        return a[1] <= b[1];
    }
}

bool pred2(tuple<ll, string, bool> a, tuple<ll, string, bool> b) 
{
    if (get<2>(a) != get<2>(b)) 
    {
        return get<2>(a) > get<2>(b);
    }
    else if (get<1>(a) != get<1>(b)) 
    {
        return get<1>(a) < get<1>(b);
    }
    else 
        return get<0>(a) <= get<0>(b);
}
int main()
{
    //for example: value and index, you should sort by indexes, then values
    vector<vector<ll>> vec = { {324,1}, {235,0}, {43,2} };
    sort(vec.begin(), vec.end());
    //{ {43,2}, {235,0}, {324,1}}
    sort(vec.begin(), vec.end(), pred);//отсортил, типа крутой
    //Аналог с tuple
    vector<tuple<ll, string, bool>> data = 
    {
        {1, "sdfg", true},
        {1, "abc", false},
        {2, "abb", false},
        {3, "abb", false}
    };
    sort(data.begin(), data.end(), pred2);
    //сначала отсортим по bool с конца, потом по строкам с начала, потом по числам с начала
    auto [score, name, haslicense] = data[0];//геттер
    data[0] = make_tuple(score, name, haslicense);//сеттер
    data[0] = { score, name, haslicense };//сеттер2

    map<int, tuple<string, string>> id_data;
    bool t2 = id_data.contains(3);

    id_data[3] = { "4", "dsf" };//даже если не существует, он вставит
    cout << id_data.size();
    id_data.insert(make_pair(4, id_data[3]));
    id_data.erase(3);

    // unordered_map<int,int> mp; //really faster
    // mp.reserve(1024);
    // mp.max_load_factor(0.25);

}
