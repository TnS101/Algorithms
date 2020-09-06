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
    double energy;
    int stamina;
    int staminaProgress;
    int happiness;
    int stressFree;
    int stressFreeProgress;
    int hunger;
    int thirst;
    int stress;
    bool isAlive;

public:
    Creature(string name, int age, int weight);

    string getName();

    int getAge();

    int getWeight();

    int getHealth();

    double getEnergy();

    int getStamina();

    int getStaminaProgress();

    int getStressFree();

    int getStressFreeProgress();

    int getHappiness();

    int getHunger();

    int getStress();

    int getThirst();

    bool getIsAlive();

    bool Eat(int amount);

    bool Drink(int amount);

    bool Sleep(int hours);

    bool Rest(int hours);

    bool Train(int hours);

    void Die();
};