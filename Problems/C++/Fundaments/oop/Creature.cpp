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
    this->hunger = 10;
    this->thirst = 10;
    this->stamina = 1;
    this->staminaProgress = 0;
    this->stressFree = 0;
    this->stressFreeProgress = 0;
    this->stress = 0;
};

Creature::~Creature()
{
    
};

string Creature::getName() { return this->name; }

int Creature::getWeight() { return this->weight; }

int Creature::getHealth() { return this->health; }

double Creature::getEnergy() { return this->energy; }

int Creature::getStamina() { return this->stamina; }

int Creature::getStaminaProgress() { return this->staminaProgress; }

int Creature::getStressFree() { return this->stressFree; }

int Creature::getStressFreeProgress() { return this->stressFreeProgress; }

int Creature::getHappiness() { return this->happiness; }

int Creature::getStress() { return this->stress; }

int Creature::getAge() { return this->age; }

bool Creature::getIsAlive() { return this->isAlive; }

bool Creature::Eat(int amount)
{
    if (this->hunger < 10)
    {
        cout << this->name << " ate " << amount << " food" << endl;

        this->weight += amount;
        this->energy++;
        this->hunger++;

        if (this->energy > 10)
        {
            this->energy = 10;
        }

        return true;
    }
    else
    {
        cout << this->name << " is not hungry!" << endl;

        return false;
    }
}

bool Creature::Drink(int amount)
{
    if (this->thirst < 10)
    {
        cout << this->name << " drank " << amount << " liquids" << endl;

        this->weight += amount;
        this->energy++;
        this->thirst++;

        if (this->energy > 10)
        {
            this->energy = 10;
        }

        return true;
    }
    else
    {
        cout << this->name << " is not thirsty!" << endl;

        return false;
    }
}

bool Creature::Sleep(int hours)
{
    if (hours == 8 - this->stressFree)
    {
        this->energy = 10;
        this->happiness++;
        this->stressFreeProgress += this->happiness / 3;

        if (this->happiness > 10)
        {
            this->happiness = 10;
        }

        if (this->stressFreeProgress == 100)
        {
            this->stressFreeProgress = 0;
            this->stressFree++;

            cout << this->name << " has Leveled Up their Stress Free Potential to level : " << this->stressFree << endl;
        }
    }
    else
    {
        this->energy = 10 - abs(hours - 8);
    }

    cout << this->name << " slept for " << hours << " hours " << endl;

    return true;
}

bool Creature::Rest(int hours)
{
    this->energy += hours;
    this->stressFreeProgress += this->happiness / 3;

    if (this->energy > 10)
    {
        this->energy = 10;
    }

    cout << this->name << " rested for " << hours << " hours " << endl;

    if (this->stressFreeProgress == 100)
    {
        this->stressFreeProgress = 0;
        this->stressFree++;

        cout << this->name << " has Leveled Up their Stress Free Potential to level : " << this->stressFree << endl;
    }

    return true;
}

bool Creature::Train(int hours)
{
    if (this->energy > 0)
    {
        if (this->weight > 60 - hours)
        {
            this->energy -= hours / this->stamina;
            this->weight -= hours;
            this->staminaProgress++;

            if (this->staminaProgress == 30)
            {
                this->staminaProgress = 0;
                this->stamina++;

                cout << this->name << " has Leveled Up their Stamina Potential to level : " << this->stamina << endl;
            }

            return true;
        }
        else
        {
            cout << this->name << " is in perfect shape!" << endl;
            return false;
        }
    }
    else
    {
        cout << this->name << " is too exhausted to train!" << endl;
        return false;
    }
}

void Creature::Die()
{
    cout << this->name << " has died..." << endl;
    this->isAlive = false;
}