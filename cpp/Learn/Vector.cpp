#include <bits/stdc++.h>

using namespace std;

//Вывод вектора. Полезная штука
template <typename T>
void cout_vec(vector<T>& x) {
	for (int i = 0; i < x.size(); i++) {
		cout << x[i] << ' ';
	}
	cout << '\n';
}

//хеш-функция для vector<int>
namespace std {
    template <>
    struct hash<vector<int>> {
        std::size_t operator()(const vector<int>& vec) const {
            std::size_t seed = vec.size();
            for (auto x : vec) {
                x = ((x >> 16) ^ x) * 0x45d9f3b;
                x = ((x >> 16) ^ x) * 0x45d9f3b;
                x = (x >> 16) ^ x;
                seed ^= x + 0x9e3779b9 + (seed << 6) + (seed >> 2);
            }
            return seed;
        }
    };
}

int main()
{
    vector<int> vec;
    vec.assign(4, 10);//= {10,10,10,10}

    vec = { 1,2,3,4,5,6,7,8,9,10,10 };

    int v = vec[0]; // достает первый элемент, т о есть единицу
    int size = vec.size(); //длина массива
    vec[0] = 0; //присвоение
    auto p1 = find(vec.begin(), vec.begin() + 3, 2);//нашел в интервале число 2 интервал [a,b)
    //p1 == vec.begin() + 1;
    auto p2 = find(vec.begin(), vec.end(), 20);//а тут не нашел, должно вернуть итератор конца интервала
    //разыменовать никак, будет выход за рамки массива
    vec.insert(vec.begin(), { 1,2 });//вставили перед первым элементом 1 и 2
    vec.push_back({ 11 });//вставил в конец 11
    for (int i = 0; i < vec.size(); i++) cout << vec[i] << ' ';
    cout << '\n';
    vec.erase(vec.begin(), vec.begin() + 2);//стер первые два элемента, а именно {1,2}
    //remove(vec.begin(), vec.end(), 10);//какая-то кринжатина, не юзать
    vec.resize(100, 100); //new size = 100 elements, empty places are 100;
    cout << vec.size();
    //векторы равны, если все его элементы (по-индексно и попарно) равны
    cout << "\n\nMAPS\n\n";
    unordered_map<vector<int>, int> mp;
    mp = 
    {
      {{1,2,3}, 4},
      {{1,2,4}, 9},
      {{1,2,6}, 5},
      {{1,2,8,0}, 7}
    };
    cout << mp.contains({1,2,4}) << '\n';//1 (true)
    cout << mp.contains({}) << '\n';//0 (false)
    cout << mp[{1,2,8,0}] << '\n';//7
    
}