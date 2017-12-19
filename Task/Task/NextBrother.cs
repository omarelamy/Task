using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class NextBrother
    {
        /*
        Stitch is a function that's used to get the nextbrother(i.e nextright node) for each node, it's implemented using a queue.
        */
        static void Stitch(Node root)
        {
            //Create a queue of nodes to store the tree children in a Breadth first form (This will help get the nextbrother of each node).
            Queue<Node> q = new Queue<Node>();

            //Enqueue the root to the queue
            q.Enqueue(root);

            //Enqueue null to the queue as the root's nextbrother is always NULL
            q.Enqueue(null);

            while (q.Count != 0)
            {
                //Get the node and remove it from the queue
                Node p = q.Dequeue();

                if (p != null)
                {   
                    //The idea basically is that for each node in the tree when it's popped from the queue, this means that the next front element would
                    //be its nextbrother because we're inserting to the queue in Breadth first manner (Level manner)
                    //Also a null is inserted at the end of each level so that the right most child of the level would have a null nextbrother
                    //the front element in the queue is the next brother to the node at the same level
                    //Peek function gets the front of the queue without removing the element itself.
                    p.nextbrother = q.Peek();

                    //Check if there's left child for the node and add to the front of the queue
                    if (p.left != null)
                        q.Enqueue(p.left);
                    //Check if there's right child for the node and add to the front of the queue
                    if (p.right != null)
                        q.Enqueue(p.right);
                }
                else if (q.Count != 0)
                    q.Enqueue(null);
            }
        }
        static void Main(string[] args)
        {
            /*Tree Structure*/
            /*
                   A 
                  / \
                 B   C
                / \   \
               D   E   F
                  /     \
                 G       H
            */
            Node root = new Node("A"); 
            root.left = new Node("B"); 
            root.right = new Node("C");    
            root.left.left = new Node("D"); 
            root.left.right = new Node("E"); 
            root.right.right = new Node("F"); 
            root.left.right.left = new Node("G");
            root.right.right.right = new Node("H");

            //Call our function that sets the NextBrother for each node.
            Stitch(root);

            //Now after calling the Stitch function, check the values of NextBrother for each node
            Console.WriteLine("The NextBrother for each node in the tree is as follows :- ");

            if (root.nextbrother != null)
                Console.WriteLine("NextBrother of " + root.value + " is " + root.nextbrother.value);
            else Console.WriteLine("NextBrother of " + root.value + " is " + "NULL");

            if (root.left.nextbrother != null)
                Console.WriteLine("NextBrother of " + root.left.value + " is " + root.left.nextbrother.value);
            else Console.WriteLine("NextBrother of " + root.left.value + " is " + "NULL");

            if (root.right.nextbrother != null)
                Console.WriteLine("NextBrother of " + root.right.value + " is " + root.right.nextbrother.value);
            else Console.WriteLine("NextBrother of " + root.right.value + " is " + "NULL");

            if (root.left.left.nextbrother != null)
                Console.WriteLine("NextBrother of " + root.left.left.value + " is " + root.left.left.nextbrother.value);
            else Console.WriteLine("NextBrother of " + root.left.left.value + " is " + "NULL");

            if (root.left.right.nextbrother != null)
                Console.WriteLine("NextBrother of " + root.left.right.value + " is " + root.left.right.nextbrother.value);
            else Console.WriteLine("NextBrother of " + root.left.right.value + " is " + "NULL");


            if (root.right.right.nextbrother != null)
                Console.WriteLine("NextBrother of " + root.right.right.value + " is " + root.right.right.nextbrother.value);
            else Console.WriteLine("NextBrother of " + root.right.right.value + " is " + "NULL");

            if (root.left.right.left.nextbrother != null)
                Console.WriteLine("NextBrother of " + root.left.right.left.value + " is " + root.left.right.left.nextbrother.value);
            else Console.WriteLine("NextBrother of " + root.left.right.left.value + " is " + "NULL");

            if (root.right.right.right.nextbrother != null)
                Console.WriteLine("NextBrother of " + root.right.right.right.value + " is " + root.right.right.right.nextbrother.value);
            else Console.WriteLine("NextBrother of " + root.right.right.right.value + " is " + "NULL");
        
        }
    }
}
