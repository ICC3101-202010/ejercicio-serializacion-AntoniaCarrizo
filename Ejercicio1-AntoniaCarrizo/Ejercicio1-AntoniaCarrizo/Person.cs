using System;
using System.Runtime.Serialization;
namespace Ejercicio1AntoniaCarrizo
{
    [Serializable]
    public class Person
    {
        private string name;
        private string lastname;
        private int age;
        

        public Person(string name, string lastname, int age)
        {
            this.name = name;
            this.lastname = lastname;
            this.age = age;
        }

        
    }
}
