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

string Person::getGender(){return this->gender;}

int Person::getMoney(){return this->money;}