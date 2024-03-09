using System;

interface IAnimal {
    void Speak();
}

class Dog : IAnimal {
    public void Speak() {
        Console.WriteLine("Woof");
    }
}

class Cat : IAnimal {
    public void Speak() {
        Console.WriteLine("Meow");
    }
}

interface IAnimalFactory {
    IAnimal CreateAnimal();
}

class DogFactory : IAnimalFactory {
    public IAnimal CreateAnimal() {
        return new Dog();
    }
}

class CatFactory : IAnimalFactory {
    public IAnimal CreateAnimal() {
        return new Cat();
    }
}