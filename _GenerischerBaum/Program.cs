﻿using System;
using System.Collections.Generic;

namespace _GenerischerBaum
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var tree = new TreeNode<String>();
            var root = tree.CreateNode("root");
            var child1 = tree.CreateNode("child1");
            var child2 = tree.CreateNode("child2");
            root.AppendChild(child1);
            root.AppendChild(child2);
            var grand11 = tree.CreateNode("grand11");
            var grand12 = tree.CreateNode("grand12");
            var grand13 = tree.CreateNode("grand13");
            child1.AppendChild(grand11);
            child1.AppendChild(grand12);
            child1.AppendChild(grand13);
            var grand21 = tree.CreateNode("grand21");
            child2.AppendChild(grand21);
            child1.RemoveChild(grand12);

            root.PrintTree(); */

            var a = Test.testString.GetEnumerator();

            //Console.WriteLine(a);  

            while(a.MoveNext())
            {
                Console.WriteLine(a.Current); 
            }

            //root.ForEach(Func);
        }
        /*static void Func(Node node)
        {
            Console.Write(node + " | ");
        } 
        }*/
    }
}

//root.addListener("AppandChild", HandleAppandChild); 
//root.addListener("RemoveChild", HandleRemoveChild); 

/*public static void HandleAppandChild()
{
    Console.writeLine("AppandChild"); 
}

public static void HandleRemoveChild()
{
    Console.WriteLine("RemoveChild"); 
}*/
