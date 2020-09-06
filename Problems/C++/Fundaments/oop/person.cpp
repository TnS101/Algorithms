using namespace std;
#include <iostream>
#include <string>
#include  <cstdlib>
#include "Person.h"

Person::Person(string name, int age, string gender, int weight)
{
    this->name = name;
    this->age = age;
    this->gender = gender;
    this->weight = weight;
    this->health = 100;
    this->energy = 10;
    this->happiness = 10;
    this->money = 1000;
}

string Person::getName(){return this->name;}

int Person::getAge(){return this->age;}

string Person::getGender(){return this->gender;}

int Person::getWeight(){return this->weight;}

int Person::getHealth(){return this->health;}

int Person::getEnergy(){return this->energy;}

int Person::getHappiness(){return this->happiness;}

void Person::Eat(int amount)
{
    cout << this->name << " has ate " << amount << " food" << endl;
    this->weight += amount;
    this->energy++; 
}

void Person::Sleep(int hours)
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

