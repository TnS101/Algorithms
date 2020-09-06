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
    this->isAlive = true;
};

string Creature::getName() { return this->name; }

int Creature::getWeight() { return this->weight; }

int Creature::getHealth() { return this->health; }

int Creature::getEnergy() { return this->energy; }

int Creature::getHappiness() { return this->happiness; }

int Creature::getAge() { return this->age; }

bool Creature::getIsAlive() { return this->isAlive; }

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

    cout << this->name << " slept for " << hours << " hours " << endl;
}

void Creature::Die()
{
    cout << this->name << " has died..." << endl;
    this->isAlive = false;
}