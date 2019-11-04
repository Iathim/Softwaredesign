using System;

namespace exercise_05
{
     class Person
    {
        public string Name;
        public int Alter;

        public virtual string GetAnrede()
        {
        if (Alter < 18)
            return "Hey " + Name;
        else
            return "Sehr geehrte(r) " + Name;
        }
    }
    
    class Frau : Person
    {
        public override string GetAnrede()
        {
            return "Sehr geehrte Frau " + Name;
        }
    }

    class Mann : Person
    {
        public override string GetAnrede()
        {
            return "Sehr geehrter Herr " + Name;
        }
    }
}
