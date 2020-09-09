using namespace std;
#include <iostream>
#include <string>
#include <cstdlib>
#include "./headers/Person.h"
#include "Creature.cpp"

Person::Person(string name, int age, string gender, int weight) : Creature(name, age, weight)
{
    this->gender = gender;
    this->creatureType = "Human";
    this->health = 100;
    this->energy = 10;
    this->money = 0;
    this->intellect = 0;
    this->wisdom = 1;
    this->wisdomProgress = 0;
    this->professionalExperience = 0;
    this->professionalExperienceProgress = 0;
}

Person::~Person(){};

string Person::getGender() { return this->gender; }

int Person::getMoney() { return this->money; }

int Person::getIntellect() { return this->intellect; }

bool Person::Study(int hours)
{
    if (this->energy - hours >= 0)
    {
        this->thirst -= hours / 2;
        this->hunger -= hours / 2;
        this->happiness -= hours;
        this->energy -= hours;

        this->intellect += hours * this->wisdom;

        this->wisdomProgress++;

        if (this->wisdomProgress == 50)
        {
            this->wisdomProgress = 0;
            this->wisdom++;

            cout << this->name << " has Leveled Up their Wisdom Potential to level : " << this->wisdom << endl;
        }

        this->Dehydrate();
        this->Starve();
        this->Depress();
        this->Exhaust();

        return true;
    }
    else
    {
        cout << this->name << " will be too exhausted from that much studying!" << endl;
        return false;
    }
}

bool Person::Work(int hours, int salary, int stress)
{
    if (this->energy - hours >= 0)
    {
        int experience = this->professionalExperience + 1;

        this->thirst -= hours / experience;
        this->hunger -= hours / experience;
        this->energy -= hours / experience;
        this->money += salary * hours;
        this->happiness -= hours / experience;

        this->professionalExperienceProgress += hours;

        if (this->professionalExperienceProgress >= 100)
        {
            this->professionalExperienceProgress -= 100;
            this->professionalExperience++;

            cout << this->name << " has Leveled Up their Professional Experience Potential to level : " << this->wisdom << endl;
        }

        this->Dehydrate();
        this->Starve();
        this->Depress();
        this->Exhaust();

        return true;
    }
    else
    {
        cout << this->name << " will be too exhausted from that much work!" << endl;
        return false;
    }
}

void Person::PlayWithPet(string petName)
{
    if (this->pets == 0)
    {
        cout << this->name << " has no pets!" << endl;
        return;
    }

    int len = sizeof(this->pets) / sizeof(this->pets[0]);

    for (int i = 0; i < len; i++)
    {
        if (pets[i]->getName() == petName)
        {
            this->happiness += pets[i]->Play();

            if (this->happiness > 10)
            {
                this->happiness = 10;
            }

            return;
        }
    }

    cout << "Pet with name : " << petName << " was not found!" << endl;
}