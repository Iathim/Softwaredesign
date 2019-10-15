using System;
using static System.Console;

public class SimplePerson
{
   public string FirstName;
   public string LastName;
   public DateTime DateOfBirth;
}

namespace Debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            Person root = Familytree.BuildTree();

            Person found = Familytree.Find(root);
            //Debugger: Dad: Philip Battenberg, Mum: Alice Battenberg; Charlie Wales; Dad: Schorsch-Albert York, Mum: Elese Windsor; Lisbeth Bowes-Lyon; Willi Cambridge

            WriteLine(found);
        }
    }
}
