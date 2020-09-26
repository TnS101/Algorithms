from random import randint

class Bike:
    def __init__(self, name, speed, price):
        self.name = name
        self.speed = speed
        self.price = price

class Food:
    def __init__(self, name, amount):
        self.name = name
        self.amount = amount

class Drink:
    def __init__(self, name, amount):
        self.name = name
        self.amount = amount

class Badge:
    def __init__(self, name, region):
        self.name = name
        self.region = region
        

class Player:
    def __init__(self, name, gender):
        self.name = name
        self.gender = gender
        self.badges = []
        self.pokemons = []
        self.balls = []
        self.foods = []
        self.thirst = 10
        self.hunger = 10
        self.drinks = []
        self.bike = None

    def catchPokemon(self, pokemon, ballName):
        for ball in self.balls:
            if ball.name == ballName:
                if ball.use(pokemon):
                    self.balls.remove(ball)
                    self.pokemons.append(pokemon)
                    break
    
    def browseBalls(self):
        for ball in self.balls:
            print(ball.name)

    def takeBadge(self, badge):
        for invBadge in self.badges:
            if invBadge.name == badge.name:
                return
        
        self.badges.append(badge)

    def drink(self, drinkName):
        message = ''
        for drink in self.drinks:
            if drink.name == drinkName:
                message = '{} has drank {} liers of {}!'
                print(message.format(self.name, drink.amount, drinkName))
                self.thirst -= drink.amount
                if self.thirst < 0 : self.thirst = 0
                return
        message = 'Drink with name : {} was not found!'
        print(message.format(drinkName))

    def eat(self, foodName):
        message = ''
        for food in self.foods:
            if food.name == foodName:
                message = '{} has ate {} kilograms of {}!'
                print(message.format(self.name, food.amount, foodName))
                self.hunger -= food.amount
                if self.hunger < 0: self.hunger = 0
                return
        message = 'Food with name : {} was not found!'
        print(message.format(foodName))
        
    def travel(self):
        if self.bike == None:
            print('Cannot travel without Bike!')
            return
        message = '{} has travelled {} km!'
        print(message.format(self.name, self.bike.speed))
class Ball:
    def __init__(self, name, rarity, catchPercentage):
        self.name = name
        self.rarity = rarity
        self.catchPercentage = catchPercentage
        self.pokemon = {}

    def use(self, pokemon):
        if randint(0, 100) <= self.catchPercentage:
            self.pokemon = pokemon
            message = '{} was catched!'
            print(message.format(pokemon.name))
            return True
        else:
            message = '{} was not catched!'
            print(message.format(pokemon.name))
            return False    

class Ability:
    def __init__(self, name, aType, element, power, operator, energy):
        self.name = name
        self.aType = aType
        self.element = element
        self.power = power
        self.operator = operator
        self.energy = energy
    
    def use(self, pokemon):
        self.energy -= 1
        value = pokemon.__getattribute__(self.aType.lower())

        if self.operator == '+':
            pokemon.__setattr__(self.aType.lower(), value + self.power)
        else:
            pokemon.__setattr__(self.aType.lower(), value - self.power)
        
        message = '{} was used on {}'
        print(message.format(self.name, pokemon.name))
     

class Pokemon:
    def __init__(self, name, element, hunger, thirst, attack, health, abilities):
        self.name = name
        self.element = element
        self.hunger = hunger
        self.thirst = thirst
        self.energy = 10
        self.attack = attack
        self.health = health
        self.abilities = abilities

    def feed(self, amount):
        if self.hunger == 0:
            print('Pokemon is not Hungry!')
            return

        self.hunger -= amount
        message = ''
        if self.hunger > 0:
            message = '{} was fed but its still Hungry! Needs {} more food to feel well!'
            print(message.format(self.name, self.hunger))
        else:
            message = '{} was fully fed!'
            print(message.format(self.name))
        self.energy += 1

        if self.energy > 10:
            self.energy = 10

    def info(self):
        message = '\n-----------\n Name : {}\n Element : {}\n Hunger : {}\n Thirst : {}\n Energy : {}\n Attack : {}\n Health : {}\n-----------\n'
        print(message.format(self.name, self.element, self.hunger, self.thirst, self.energy, self.attack, self.health))   

    def irrigate(self, amount):
        if self.thirst == 0:
            print('Pokemon is not Thirsty!')
            return

        self.thirst -= amount
        message = ''
        if self.thirst > 0:
            message = '{} was irrigated but its still Thirsty! Needs {} more liquids to feel well!'
            print(message.format(self.name, self.thirst))
        else:
            message = '{} was fully irrigated!'
            print(message.format(self.name))
        self.energy += 1

        if self.energy > 10:
            self.energy = 10


    def basicAttack(self, pokemon):
        if self.energy == 0:
            print('No enough Energy!')
            return
        if self.hunger > 5:
            print('Pokemon is Hungry!')
            return
        if self.thirst > 5:
            print('Pokemon is Thirsty!')
            return

        pokemon.health -= self.attack
        self.energy -= 1
        self.hunger -= 1
        self.thirst -= 1
        message = '{} was hit by {} for {} Damage!'
        print(message.format(pokemon.name, self.name, self.attack))

    def useAbility(self, pokemon, abilityName):
        if self.energy == 0:
            print('No enough Energy!')
            return

        ability = {}
        for ab in self.abilities:
            if ab.name == abilityName:
                ability = ab
                break
            else:
                message = 'Ability with name {} was not found!'
                raise Exception(message.format(abilityName))
        self.energy -= 1        
        ability.use(pokemon)

player = Player('Ash', 'Male')
superBall = Ball('SuperBall', 1, 100)

player.balls.append(superBall)

thunderBolt = Ability('Thunder Bolt', 'Health', 'Thunder', 5, '-', 10)
pikachu = Pokemon('Pikachu', 'Thunder', 10, 10, 5, 20, [thunderBolt])


player.catchPokemon(pikachu, 'SuperBall')
