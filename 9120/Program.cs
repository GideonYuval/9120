using System;
//using System.Collections.Generic;
using Unit4New;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9120
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        // 1
        // sum of elements in list
        // param : Node<int>
        // return : int
        // example: param: ->1->2->3, return: 6
        // example: param: ->10->20->30, return: 60
        public static int sum(Node<int> lst)
        {
            // Your implementation here
            return 0;
        }

        // 2
        // find the maximum element in the list
        // param : Node<int>
        // return : int
        // example: param: ->1->2->3, return: 3
        // example: param: ->10->20->30, return: 30
        public static int findMax(Node<int> lst)
        {
            // Your implementation here
            return 0;
        }

        // 3
        // find a specific element in the list
        // param1 : IntNode
        // param2 : int (value to find)
        // return : IntNode
        // example: param1: ->1->2->3, param2: 2, return: Node with value 2
        // example: param1: ->10->20->30, param2: 20, return: Node with value 20
        public static IntNode FindInList(IntNode first, int lookFor)
        {
            // Your implementation here
            return null;
        }

        // 4
        // check if an element is in the list
        // param1 : IntNode
        // param2 : int (value to check)
        // return : bool
        // example: param1: ->1->2->3, param2: 2, return: true
        // example: param1: ->10->20->30, param2: 25, return: false
        public static bool IsInList(IntNode first, int lookFor)
        {
            // Your implementation here
            return false;
        }

        // 5
        // insert an element at a specific position in the list
        // param1 : Node<int>
        // param2 : int (position)
        // param3 : int (value)
        // return : Node<int>
        // example: param1: ->1->2->4, param2: 2, param3: 3, return: ->1->2->3->4
        // example: param1: ->1->3->4, param2: 1, param3: 2, return: ->1->2->3->4
        public static Node<int> insertAtPosition(Node<int> lst, int position, int value)
        {
            // Your implementation here
            return lst;
        }

        // 6
        // remove the element at a specific position in the list
        // param1 : Node<int>
        // param2 : int (position)
        // return : Node<int>
        // example: param1: ->1->2->3->4, param2: 2, return: ->1->3->4
        // example: param1: ->1->2->3->4, param2: 1, return: ->1->3->4
        public static Node<int> removeAtPosition(Node<int> lst, int position)
        {
            // Your implementation here
            return lst;
        }
    }
}
