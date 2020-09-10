from random import randint

class Player:
    def __init__(self, name, gender):
        self.name = name
        self.gender = gender
        self.badges = 0
        self.pokemons = []
        self.balls = []

    def catchPokemon(self, pokemon, ballName):
        targetBall = {}
        for ball in self.balls:
            if ball.name == ballName:
                targetBall = ball
                break
        
        if targetBall.use(pokemon):
            self.balls.remove(targetBall)
            self.pokemons.append(pokemon)

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
     

thunderBolt = Ability('Thunder Bolt', 'Health', 'Thunder', 5, '-', 10)
pikachu = Pokemon('Pikachu', 'Thunder', 10, 10, 5, 20, [thunderBolt])

peepLup = Pokemon('Peeplup', 'Water', 10, 10, 5, 10, [])

pikachu.useAbility(peepLup, 'Thunder Bolt')

print(peepLup.info())
print(pikachu.info())
