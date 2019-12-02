using System;
using System.Collections.Generic;

namespace _GenerischerBaum
{
    public class TreeNode<T>
    {
        public T TreeContent;
        public List<TreeNode<T>> Children;
        
        public TreeNode()
        {
            this.Children = new List<TreeNode<T>>();
        }


        public TreeNode(T contents)
        {
            this.Children = new List<TreeNode<T>>();
            
            this.TreeContent = contents;
        }



        public TreeNode<T> CreateNode(T newObject)
        {
            return new TreeNode<T>(newObject);
        }


        public void AppendChild(TreeNode<T> child)
        {
            TreeNode<T> newChildNode = child;
            
            Children.Add(newChildNode);
        }


        public void RemoveChild(TreeNode<T> childNode)
        {
            for (int i = 0; i < Children.Count; i++)
            {
                if (Children[i].Equals(childNode))
                {
                    Children.RemoveAt(i);
                }
            }
        }


        private void PrintChildren(TreeNode<T> parent, string generationIndex)
        {
            generationIndex = generationIndex + "*";

            foreach(TreeNode<T> child in parent.Children)
            {
                Console.WriteLine(generationIndex + child.TreeContent.ToString());

                PrintChildren(child, generationIndex);
            }
        }

        
        public void PrintTree()
        {
            Console.WriteLine(this.TreeContent.ToString());

            PrintChildren(this, "*");
        }


        public void ClearTree()
        {
            this.Children.Clear();
        }
    }
}
