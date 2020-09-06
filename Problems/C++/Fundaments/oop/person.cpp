using namespace std;
#include <iostream>
#include <string>
#include  <cstdlib>
#include "./headers/Person.h"
#include "Creature.cpp"

Person::Person(string name, int age, string gender, int weight):Creature(name, age, weight)
{
    this->name = name;
    this->age = age;
    this->gender = gender;
    this->weight = weight;
    this->health = 100;
    this->energy = 10;
    this->money = 1000;
}

string Person::getName(){return this->name;}

int Person::getAge(){return this->age;}

string Person::getGender(){return this->gender;}

int Person::getWeight(){return this->weight;}

int Person::getHealth(){return this->health;}

int Person::getEnergy(){return this->energy;}

int Person::getHappiness(){return this->happiness;}