using System;
using TecNM.Practica1.Core.Entities;
using TecNM.Practica1.Core.Managers;
using TecNM.Practica1.Core.Services;

namespace TecNM.Practica1.App;  

public static class Program{

    public static void Main(string[] args){

        float weight = 0;

        System.Console.WriteLine("Please, enter your weight (in kilograms):");
        Single.TryParse(System.Console.ReadLine(), out weight);
        System.Console.WriteLine("Weight registered: " + weight + " Kilograms.");

        var person = new Person{Weight = weight};
        
        var service = new MarsService();
        var manager = new MarsManager(service);

        Mars mars = manager.GetMars(person);

        System.Console.WriteLine("Gravity constant on Mars: 3.721 m/s².");
        System.Console.WriteLine("Your weight on Mars is: " + mars.Weight + " Newtons.");


    }

}

