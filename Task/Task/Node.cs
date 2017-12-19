using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Node
    {
        public string value;
        public Node left;
        public Node right;
        public Node nextbrother;
    
        public Node(string val)
        {
            this.value = val;
            this.left = null;
            this.right = null;
            this.nextbrother = null;
        }
    
    }

}
