using System;

namespace exercise_03
{
    class ToDo
    {
        public class Person
        {
            public string FirstName;
            public string LastName;
            public DateTime Age;
            
            
            public override string ToString() 
            { 
                string person = FirstName + LastName + ", Date of Birth: " + Age; 

                return person;
            }


            public Person[] createPersons(int numberOfPersons) 
            {
                Person[] personArray = new Person[numberOfPersons];

                for(int i = 0; i < numberOfPersons; i++) 
                {
                    personArray[i] = new Person();
                }

                return personArray;
            }


            public void setPersons(Person[] personArray) 
            {
                Person person0 = personArray[0];
                person0.FirstName = "Alistair";
                person0.LastName = "Morton";
                person0.Age = new DateTime(1981, 8, 7);
                
                Person person1 = personArray[1];
                person1.FirstName = "James";
                person1.LastName = "Spencer";
                person1.Age = new DateTime(1982, 5, 20);
                
                Person person2 = personArray[2];
                person2.FirstName = "Anthony J.";
                person2.LastName = "Crowley";
                person2.Age = new DateTime(1941, 1, 1);
                
                Person person3 = personArray[3];
                person3.FirstName = "A. Z.";
                person3.LastName = "Fell";
                person3.Age = new DateTime(1942, 5, 1);
                
                Person person4 = personArray[4];
                person4.FirstName = "Armitage";
                person4.LastName = "Hux";
                person4.Age = new DateTime(2000, 12, 7);
                
                Person person5 = personArray[5]; 
                person5.FirstName = "Percy"; 
                person5.LastName = "Weasley"; 
                person5.Age = new DateTime(1976, 8, 22); 
            }

            public void ageOfPersons (Person[] personArray) 
            {
                DateTime currentDate = DateTime.Now;
                DateTime personAge;
                TimeSpan differenceGes;
                int years;

                for(int i = 0; i < personArray.Length; i++) 
                {
                    personAge = personArray[i].Age;
                    differenceGes = currentDate - personAge;
                    years = differenceGes.Days/365;
                    if(years > 42) 
                    {
                        Console.WriteLine(personArray[i].FirstName + " " + personArray[i].LastName + " is older than 42 years");
                    } 
                    else 
                    {
                        Console.WriteLine(personArray[i].FirstName + " " + personArray[i].LastName + " is younger than 42 years");
                    }
                }
            
            }
        
            public static void Main(string[] args) 
            {
                Person persons = new Person();

                Person[] personArray = persons.createPersons(5);

                persons.setPersons(personArray);
                persons.ageOfPersons(personArray);
            }
        }
    }
}