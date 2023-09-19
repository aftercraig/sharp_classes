using System;
using System.Collections.Generic;

public class Character {
    private string name;
    private double speed;

    public Character(string name, double speed) {
        this.name = name;
        this.speed = speed;
    }

    public void DisplayInfo() {
        Console.WriteLine("Персонаж: " + name);
        Console.WriteLine("Скорость: " + speed);
    }
}

public class Side {
    public static void Main(string[] args) {
        Character character = new Character("The Shape", 4.6);
        character.DisplayInfo();
    }
}