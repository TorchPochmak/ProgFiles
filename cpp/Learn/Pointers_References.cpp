#include <bits/stdc++.h>

using namespace std;

struct Smth
{
    public:
        Smth()
        {
            private_data = 10;
        }
        int Get()
        {
            return private_data;
        }
        void Set(int value)
        {
            private_data = value;
        }

    private:
        int private_data;
};

void foo1_change(Smth *change) { change->Set(-1); } //changes!
void foo1_nochange(Smth* change) 
{ 
    Smth n;
    change = &n;
    n.Set(-1);
} //you should not change the pointer...
void foo10_change(Smth* change)
{
    Smth n;
    
    //*change = n; copy...., so it returns 10
    n.Set(-10);
    *change = n; //now it returns -10, as expected 
}
void foo2_change(Smth &change) { change.Set(-2); } //changes!
void foo20_change(Smth &change)
{
    Smth n;
    //change = n; copy...., so it returns 10
    n.Set(-20);
    change = n; //now it returns -20, as expected
}
void foo3_nochange(Smth no_change) { no_change.Set(-3); } //copying, no changes

int main()
{
    #pragma region nvm
    Smth sm;
    int g = sm.Get();//10
    sm.Set(5);
    cout << sm.Get() << '\n';
    #pragma endregion

    #pragma region playing references pointers

    Smth object1, object2;
    Smth *pointer;
    //cout << pointer->Get() << '\n'; Segmentation fault
    pointer = nullptr;
    //cout << pointer->Get() << '\n'; Segmentation fault
    Smth &reference = object1; //should always be initiallized
    //reference = nullptr; ERROR: reference is not a pointer to the memory, you should use it like other object
    cout << reference.Get() << '\n';
    reference.Set(3);
    cout << object1.Get() << '\n';//5
    object1.Set(4);
    cout << reference.Get() << '\n';//4
    
    pointer = &object2;
    *pointer = reference;//копирует поля одного объекта в другой
    reference.Set(6);
    cout << pointer->Get() << '\n';//поэтому выдаст 4

    pointer = &reference;//а вот здесь полноценное ссылка на reference, которая указывает на object1
    cout << pointer->Get() << '\n';//поэтому 6

    //а теперь в обратную сторону
    object1.Set(1);
    object2.Set(2);
    pointer = &object1;
    reference = object2; // КОПИРОВАНИЕ ОБЪЕКТА В ССЫЛКУ
    cout << reference.Get() << '\n'; //выдаст 2
    object1.Set(1);
    object2.Set(2);
    cout << reference.Get() << '\n'; //выдаст 1
    
    pointer = &object2;
    reference = *pointer; //И СНОВА КОПИРОВАНИЕ
    pointer->Set(1);
    cout << reference.Get() << '\n'; //выдаст 2

    //&reference = pointer; запись не валидна
    #pragma endregion
    
    #pragma region playing references pointers functions
    cout << "Functions:\n";

    //----------------------------------------------------
    object1.Set(1);
    foo1_change(&object1);
    cout << object1.Get() << '\n';

    object2.Set(2);
    foo2_change(object2);
    cout << object2.Get() << '\n';

    //----------------------------------------------------
    object1.Set(1);
    object2.Set(2);

    reference = object1;
    foo1_change(&reference); //разницы никакой
    cout << object1.Get() << '\n';

    //reference = object2; WARNING произойдет копирование object2 в ссылку, изначально она была создана на object1, so...
    Smth &reference2 = object2;
    foo2_change(reference2);
    cout << object2.Get() << '\n';
    //----------------------------------------------------
    object1.Set(1);
    object2.Set(2);

    pointer = &object1;
    foo1_change(pointer); //разницы никакой
    cout << object1.Get() << '\n';

    pointer = &object2;
    foo2_change(*pointer);
    cout << object2.Get() << '\n';
    //----------------------------------------------------
    #pragma endregion


    object1.Set(1);
    object2.Set(2);
    Smth &ref1 = object1;
    Smth &ref2 = ref1;
    
    ref2 = object2;
    object2.Set(0);
    cout << object1.Get() << ref1.Get() << ref2.Get() << '\n'; //везде 222, произошло великое копирование, проброс через две ссылки
    //через поинтеры тоже можно так делать, но их можно отвязать от объекта, а ссылки никак, вотб


    //Вывод: эти ваши ссылки просто имба, поинтеры срань, 
    //но поля структур данных без них никак :(
    //ссылки имба как параметры в функциях, а то пишешь эти ****************
    return 0;
}