#pragma once
using namespace std;
#include <string>
#include "Creature.h"

class Person : public Creature
{
    private:
        string gender;
        int money;
        
    public:
        Person(string name, int age, string gender, int weight);

        string getGender();

        int getMoney();
};