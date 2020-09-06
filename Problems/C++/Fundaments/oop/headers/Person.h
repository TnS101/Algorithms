#pragma once

using namespace std;
#include <string>
#include "Creature.h"

class Person : public Creature
{
private:
    string gender;
    int money;
    int intellect;
    int wisdom;
    int wisdomProgress;
    int professionalExperience;
    int professionalExperienceProgress;

protected:
    void wornOut();

public:
    Person(string name, int age, string gender, int weight);
    ~Person();

    string getGender();

    int getMoney();

    int getIntellect();

    bool Study(int hours);

    bool Work(int hours, int salary, int stress);
};