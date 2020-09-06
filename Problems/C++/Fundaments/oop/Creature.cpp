#pragma once

using namespace std;
#include <iostream>
#include <string>
#include <cstdlib>
#include "./headers/Creature.h"

Creature::Creature(string name, int age, int weight)
{
    this->name = name;
    this->age = age;
    this->weight = weight;
    this->happiness = 10;
};

void Creature::Eat(int amount)
{
    cout << this->name << " ate " << amount << " food" << endl;
    this->weight += amount;
    this->energy++; 
}

void Creature::Sleep(int hours)
{
    if (hours == 8)
    {
        this->energy = 10;
        this->happiness++;
    }
    else
    {
        this->energy = 10 - abs(hours - 8);
    }
}