#include <iostream>
#include <string>
#include <vector>
using namespace std;

void pointers(int num)
{
    int *pointer = &num;
    cout << "Pointer : " << pointer << endl;
    cout << "Value (with Dereferencing) : " << *pointer << endl;
}   

void stringOperations(string input)
{
    cout << "Index of the first occurence of 'i' : " << input.find("i") << endl;
    cout << "Will substring from given index to the end of the string : " << input.substr(3) << endl;
    cout << "Works like a normal substring : " << input.substr(1, 5) << endl;
}

void mathOperations()
{
    int left;
    string mathOperator;
    int right;

    cout << "First Integer : ";
    cin >> left;

    cout << "Math Operator : ";
    cin >> mathOperator;

    cout << "Second Integer : ";
    cin >> right;

    if (mathOperator == "+")
    {
        cout << left + right << endl;
    }else if (mathOperator == "-")
    {
        cout << left - right << endl;
    }else if (mathOperator == "*")
    {
        cout << left * right << endl;
    }else
    {
        cout << left / right << endl;
    }
}

void vectorOperations()
{
    vector<string> names;

    names.push_back("Name1");
    names.push_back("Name2");
    names.push_back("Name3");

    names.pop_back();

    cout << names.at(1) << endl;

    names.insert(names.begin() + 2, "NameN");

    cout << names.size();
}

int main()
{
    vectorOperations();

    return 0;
}