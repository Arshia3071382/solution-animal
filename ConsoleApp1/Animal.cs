using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    public class Animal
    {
        public string Name { get; set; }
        public int Hand { get; set; }
        public int Feet { get; set; }
   
        public Animal(string name, int hand,int feet)
        {

            Name = name;
            Hand = hand;
            Feet = feet;
        
          
        }
        public void Makesound()
        {

            Console.WriteLine("the animal makes a sound:");
        }


        public void Animaldetails()
        {
            Console.WriteLine("Animal Name:" + Name);
            Console.WriteLine("number of hands:" + Hand);
            Console.WriteLine("number of feet:" + Feet);
         
        }

    }
    public class Cow:Animal
    {
        public Cow(string name , int hand , int feet): base(name, hand ,feet)
        {
            
        }

        public  void Makesound()
        {

            Console.WriteLine("moo!moo!");
        }
        public void Animaldetails()
        {
            Console.WriteLine("Animal Name:" + Name);
            Console.WriteLine("number of hands:" + Hand);
            Console.WriteLine("number of feet:" + Feet);


        }

    }
    public class Cat:Animal
    {
        public Cat(string name , int hand , int feet): base(name, hand ,feet) 
        {
         
        }

       

        public void Makesound()
        {
            Console.WriteLine("meows");
        }
        public void Animaldetails()
        {

            Console.WriteLine("Animal Name:" + Name);
            Console.WriteLine("number of hands:" + Hand);
            Console.WriteLine("number of feet:" + Feet);

        }


    }
    public class Fly:Animal
    {
        public Fly(string name , int hand ,int feet):base(name,hand,feet) 
        { 
        
        
        }
        public void Makesound()
        {
            Console.WriteLine("zzzzzz!");


        }

        public void Animaldetails()
        {
            Console.WriteLine("Animal Name:" + Name);
            Console.WriteLine("number of hands:" + Hand);
            Console.WriteLine("number of feet:" + Feet);



        }
    }
   



}
   
    
    public class Handssection
    {
        public int Count { get; set; }

        public Handssection()
        {

            Count = 0;
        }


    }
    public class Feetsection
    {
        public int Count { get; set; }
        public Feetsection()
        {
            Count = 0;
        }

    }
   
    



