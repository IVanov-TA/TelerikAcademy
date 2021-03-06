﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring
{
    class Hauptklasse
    {
        enum Gender { Man, Lady };

        class Person
        {
            public Gender Gender { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
        }

        public void CreatePerson(int age)
        {
            Person person = new Person();
            person.Age = age;
            if (age % 2 == 0)
            {
                person.Name = "Батката";
                person.Gender = Gender.Man;
            }
            else
            {
                person.Name = "Мацето";
                person.Gender = Gender.Lady;
            }
        }
    }

}
