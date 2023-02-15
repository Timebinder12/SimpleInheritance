using System;

namespace Inheritance
{

    // base class
    class Animal
    {
        public string name;

        // constructor
        public Animal()
        {
            name = "";

        }
        //parameterized constructor
        public Animal(string name)
        {
            this.name = name;
        }

        public virtual void display()
        {
            Console.WriteLine($"I am an animal, my name is {name}");
        }

    }
    class Monkey : Animal
    {
        public string talk;
        public string swing;
        public string eat;

        public Monkey()
            :base()
        {
            talk = "";
            swing = "";
            eat = "";
        }
        public Monkey(string name, string talk, string swing, string eat)
            :base(name)
        {
            this.talk = talk;
            this.swing = swing;
            this.eat = eat;
        }
        public override void display()
        {
            Console.WriteLine($"I am a monkey and my name is {name}, I talk by {talk}, I move by {swing}, and I love to eat {eat}!");
        }
    }
    class Bird : Animal
    {
        protected string fly;
        protected string caw;
        protected string beak;

        public Bird()
            :base()
        {
            fly = "";
            caw = "";
            beak = "";
        }
        public Bird(string name, string fly, string caw, string beak)
            :base(name)
        {
            this.fly = fly;
            this.caw = caw;
            this.beak = beak;
        }
        public override void display()
        {
            Console.WriteLine($"I am a bird and my name is {name}, I talk by {caw}, I move by {fly}, and I have a {beak}");
        }

    }
    // derived class of Animal 


    class Program
    {
        static void Main(string[] args)
        {
            // object of base class
            Animal myPet = new Animal();
            myPet.name = "Sparky";
            myPet.display();



            // derived class object using default constructor
            Monkey anotherMonkey = new Monkey();
            anotherMonkey.name = "Curious George";
            anotherMonkey.talk = "Ooh Ooh Aah Aah!";
            anotherMonkey.swing = "swinging";
            anotherMonkey.eat = "Bananas";
            anotherMonkey.display();


            //derived class object using parameterized constructor

            Monkey aMonkey = new Monkey("Monkey", "Ooh Ooh Aah Aah!", "swinging", "bananas");
            aMonkey.display();

            //Create a new object from the base class
            Animal mySecondPet = new Animal();
            mySecondPet.name = "Scooby";
            mySecondPet.display();

            //Create an object from the derived class
            Bird myBird = new Bird("Bird", "flight", "caw caw!", "beak");
            myBird.display();

        }

    }
}
