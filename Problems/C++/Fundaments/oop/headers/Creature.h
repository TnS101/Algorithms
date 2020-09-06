#pragma once

using namespace std;
#include <string>

class Creature
{
protected:
    string name;
    int age;
    int weight;
    int health;
    int energy;
    int happiness;
    bool isAlive;

public:
    Creature(string name, int age, int weight);

    string getName();

    int getAge();

    int getWeight();

    int getHealth();

    int getEnergy();

    int getHappiness();

    bool getIsAlive();

    void Eat(int amount);

    void Sleep(int hours);

    void Die();
};