using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICTPRG547_Assessment1_WyattCoff
{
    public class BinaryTreeNode
    {
        public BinaryTreeNode LeftNode { get; set; }
        public BinaryTreeNode RightNode { get; set; }
        public int Data { get; set; }

        public BinaryTreeNode(int data)
        {
            Data = data;
            LeftNode = null;
            RightNode = null;
        }
    }
}


