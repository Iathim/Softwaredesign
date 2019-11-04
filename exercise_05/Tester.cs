using System;

namespace exercise_05
{
     class Tester
    {
        public static void Main(string[] args) 
        {
            Person person0 = new Person {Name = "Fenris Elgara", Alter = 22}; 

            Person person1 = new Person {Name = "Percy Morton", Alter = 37}; 
            
            Person person2 = new Person {Name = "Gabriel König", Alter = 17}; 

            Person person3 = new Mitarbeiter {Name = "Garukh", Alter = 33, Personalnummer = 610902}; 

            Person person4 = new Person {Name = "Alaric Hawke", Alter = 28}; 

            Frau frau1 = new Frau {Name = "Emi Martinius", Alter = 20}; 

            Mann mann1 = new Mann {Name = "James Spencer", Alter = 36}; 

            Person [] personenArray = new Person [7]; 
            personenArray[0] = person0; 
            personenArray[1] = person1; 
            personenArray[2] = person2; 
            personenArray[3] = person3; 
            personenArray[4] = person4;
            personenArray[5] = frau1; 
            personenArray[6] = mann1; 


            Container.MyContainer container = new Container.MyContainer();
            container.Add(personenArray);
            container.GetAt(0);

            for (int i = 0; i < personenArray.Length; i++)
            {
                Person platzhalter; 
                platzhalter = personenArray[i]; 
                Console.WriteLine(platzhalter.GetAnrede()); 
            }
        }
    }
}
