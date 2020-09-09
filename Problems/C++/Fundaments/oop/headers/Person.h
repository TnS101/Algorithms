#pragma once

using namespace std;
#include <string>
#include "Creature.h"
#include "Animal.h"

class Person : public Creature
{
    string gender;
    int money;
    int intellect;
    int wisdom;
    int wisdomProgress;
    int professionalExperience;
    int professionalExperienceProgress;
    Animal *pets[5];

public:
    Person(string name, int age, string gender, int weight);
    ~Person();

    string getGender();

    int getMoney();

    int getIntellect();

    bool Study(int hours);

    bool Work(int hours, int salary, int stress);

    void PlayWithPet(string petName);
};