using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICTPRG547_Assessment1_WyattCoff
{
    public class BinaryTree
    {
        public BinaryTreeNode Root { get; private set; }

        // Add method to add a new node to the tree
        public bool Add(int value)
        {
            if (Root == null)
            {
                Root = new BinaryTreeNode(value);
                return true;
            }
            return AddTo(Root, value);
        }

        private bool AddTo(BinaryTreeNode node, int value)
        {
            if (value < node.Data)
            {
                if (node.LeftNode == null)
                {
                    node.LeftNode = new BinaryTreeNode(value);
                    return true;
                }
                return AddTo(node.LeftNode, value);
            }
            else if (value > node.Data)
            {
                if (node.RightNode == null)
                {
                    node.RightNode = new BinaryTreeNode(value);
                    return true;
                }
                return AddTo(node.RightNode, value);
            }
            return false; // Duplicate value not added
        }

        public BinaryTreeNode Find(int value)
        {
            return Find(value, Root);
        }

        private BinaryTreeNode Find(int value, BinaryTreeNode parent)
        {
            if (parent != null)
            {
                if (value == parent.Data) return parent;
                if (value < parent.Data) return Find(value, parent.LeftNode);
                else return Find(value, parent.RightNode);
            }
            return null;
        }

        public void Remove(int value)
        {
            Root = Remove(Root, value);
        }

        private BinaryTreeNode Remove(BinaryTreeNode parent, int key)
        {
            if (parent == null) return null;

            if (key < parent.Data) parent.LeftNode = Remove(parent.LeftNode, key);
            else if (key > parent.Data) parent.RightNode = Remove(parent.RightNode, key);
            else
            {
                if (parent.LeftNode == null) return parent.RightNode;
                if (parent.RightNode == null) return parent.LeftNode;

                parent.Data = MinValue(parent.RightNode);
                parent.RightNode = Remove(parent.RightNode, parent.Data);
            }
            return parent;
        }

        private int MinValue(BinaryTreeNode node)
        {
            int minv = node.Data;
            while (node.LeftNode != null)
            {
                minv = node.LeftNode.Data;
                node = node.LeftNode;
            }
            return minv;
        }

        // Updated traversal methods to accept an Action<int> callback

        public void TraversePreOrder(BinaryTreeNode node, Action<int> action)
        {
            if (node != null)
            {
                action(node.Data);
                TraversePreOrder(node.LeftNode, action);
                TraversePreOrder(node.RightNode, action);
            }
        }

        public void TraverseInOrder(BinaryTreeNode node, Action<int> action)
        {
            if (node != null)
            {
                TraverseInOrder(node.LeftNode, action);
                action(node.Data);
                TraverseInOrder(node.RightNode, action);
            }
        }

        public void TraversePostOrder(BinaryTreeNode node, Action<int> action)
        {
            if (node != null)
            {
                TraversePostOrder(node.LeftNode, action);
                TraversePostOrder(node.RightNode, action);
                action(node.Data);
            }
        }
    }
}

