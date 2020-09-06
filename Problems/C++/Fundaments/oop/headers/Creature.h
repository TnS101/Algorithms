#pragma once
using namespace std;
#include <string>

class Creature
{
    public:
        string name;
        int age;
        int weight;
        int health;
        int energy;
        int happiness;

        Creature(string name, int age, int weight);

        string getName();

        int getAge();

        int getWeight();

        int getHealth();

        int getEnergy();

        int getHappiness();

        void Eat(int amount);
        void Sleep(int hours);
};