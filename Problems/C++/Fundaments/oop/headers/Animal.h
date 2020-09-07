#pragma once

using namespace std;
#include <string>
#include "Creature.h"
#include "Person.h"

class Animal : public Creature
{
    string animalType;
    Person owner;
    int buyPrice;
public:
    Animal(string name, string animalType, int age, int weight, int buyPrice, Person owner);
    ~Animal();

    int Play();
};