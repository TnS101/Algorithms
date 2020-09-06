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
    this->wisdomProgress = 0;
    this->wisdom = 1;
}

Person::~Person()
{

};

string Person::getGender() { return this->gender; }

int Person::getMoney() { return this->money; }

int Person::getIntellect() { return this->intellect; }

bool Person::Study(int hours)
{
    this->thirst -= hours/2;
    this->hunger -= hours/2;
    this->happiness -= hours;
    this->energy -= hours;

    this->intellect += hours * this->wisdom;

    this->wisdomProgress++;

    if (this->wisdomProgress == 50)
    {
        this->wisdomProgress = 0;
        this->wisdom++;
    }
    
    if (this->thirst < 0 )
    {

    }
    

}

void wornOut(Person person)
{
    
}