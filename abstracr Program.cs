using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
     /*class University
    {
        public virtual void Method1() { }
        public virtual void Method2() { }

        public void Method3()
        {

        }
        
    }

   abstract  class MyClass : University
    {

        abstract public  void Method4();
        public override  void Method1()
        {
            
        }

        public override  void Method2()
        {
            
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            University u = new University();
            MyClass my = new MyClass();
        }
    }*/
     class One
    {
       public void OneMethod()
        {

        }

        void AnimalSound()
        {

        }
    }

    class Two
    {
        public void OneMethod()
        {

        }
    }
    interface IAnimal
    {
               
          void AnimalSound();
                
    }

    interface IAnimalProperties
    {
        void AnimalMovement();
    }

    class Dog : One,IAnimal   
    {
        public void AnimalSound()
        {
          // dog barking sound   
        }

       public  void AnimalMovement()
        {

        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            
        }
    }
}
