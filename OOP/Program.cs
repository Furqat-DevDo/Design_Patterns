﻿using Abstraction;
using Encaplsulation;
using Inheritance;

public class Program
{
    public static void Main(string[] args)
    { 
        /// <summary>
        /// Abstraction with CoffeeMachine Example
        /// </summary>
    
        // var coffee = new Coffee(1.5, "Espresso", CoffeeType.Espresso);
        // CoffeeMachine.MakeCoffeeAsync(coffee).Wait();

        /// <summary>
        /// Encapsulation with Airplane,Helicopter Example
        /// </summary>

        // var airport = new Airport();
        // var airplane = new Airplane();
        // var helicopter = new Helicopter();
        // airport.Flying(airplane);
        // airport.Landing(airplane);
        // airport.Flying(helicopter);
        // airport.Landing(helicopter);

        /// <summary>
        /// Inheritance with Cat,Horse Example
        /// </summary>

        var cat = new Cat();
        var horse = new Horse();
        cat.Sound();
        cat.Eat();
        cat.Sleep();
        cat.Move();
        horse.Sound();
        horse.Eat();
        horse.Sleep();
        horse.Move();

    }
}