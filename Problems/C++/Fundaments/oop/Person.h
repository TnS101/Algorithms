#pragma once
using namespace std;
#include <string>

class Person
{
    private:
        string name;
        int age;
        string gender;
        int weight;
        int health;
        int energy;
        int money;
        int happiness;
    public:
        Person(string name, int age, string gender, int weight);
        
        string getName();

        int getAge();

        string getGender();

        int getWeight();

        int getHealth();

        int getEnergy();

        int getMoney();

        int getHappiness();

        void Eat(int amount);

        void Sleep(int hours);
};