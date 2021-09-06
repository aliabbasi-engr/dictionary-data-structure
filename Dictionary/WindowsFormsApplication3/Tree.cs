using System;
using System.Collections.Generic;

namespace WindowsFormsApplication3
{
    class Tree
    {
        public CellNode Root { get; set; }

        private List<int> preOrder = new List<int>();

        public List<int> GetPreOrder(CellNode root)
        {
            preOrder.Clear();
            PreOrder(root);
            return preOrder;
        }

        private void PreOrder(CellNode current)
        {
            if (current != null)
            {
                preOrder.Add(current.IntValue);
                PreOrder(current.LeftChild);
                PreOrder(current.RightChild);
            }
        }

        private List<CellNode> nodesInInOrder = new List<CellNode>();

        public List<CellNode> GetNodesInInOrder(CellNode root)
        {
            nodesInInOrder.Clear();
            NodesInInOrder(root);
            return nodesInInOrder;
        }

        private void NodesInInOrder(CellNode current)
        {
            if (current != null)
            {
                NodesInInOrder(current.LeftChild);
                nodesInInOrder.Add(current);
                NodesInInOrder(current.RightChild);
            }
        }

        private List<int> postOrder = new List<int>();

        public List<int> GetPostOrder(CellNode root)
        {
            postOrder.Clear();
            PostOrder(root);
            return postOrder;
        }

        private void PostOrder(CellNode current)
        {
            if (current != null)
            {
                PostOrder(current.LeftChild);
                PostOrder(current.RightChild);
                postOrder.Add(current.IntValue);
            }
        }

        private CellNode InsertTreeNode(int value)
        {
            CellNode current = Root;
            CellNode currentParent = null;
            while (current != null)
            {
                currentParent = current;
                if (current.IntValue == value)
                    return null;
                else if (current.IntValue < value)
                    current = current.RightChild;
                else if (current.IntValue > value)
                    current = current.LeftChild;
            }
            CellNode newItem = new CellNode(value);
            if (Root == null)
                Root = newItem;
            else if (value < currentParent.IntValue)
            {
                currentParent.LeftChild = newItem;
                newItem.Parent = currentParent;
            }
            else
            {
                currentParent.RightChild = newItem;
                newItem.Parent = currentParent;
            }
            return newItem;
        }

        public void InsertKeyNode(double value, string key)
        {
            CellNode temp = FindTreeNodeByValue(value);
            if (temp == null)
                temp = InsertTreeNode(Helper.GetIntValue(value));
            var createdNode = new CellNode(temp.IntValue, Helper.GetDoubleValue(value) , key);
            if (temp.NextNode == null)
            {
                createdNode.PreviousNode = temp;
                temp.NextNode = createdNode;
            }
            else
            {
                var previous = temp;
                while (temp != null && temp.DoubleValue <= Helper.GetDoubleValue(value))
                {
                    previous = temp;
                    temp = temp.NextNode;
                }
                if (temp == null)
                {
                    previous.NextNode = createdNode;
                    createdNode.PreviousNode = previous;
                }
                else
                {
                    createdNode.PreviousNode = previous;
                    createdNode.NextNode = temp;
                    previous.NextNode = createdNode;
                    temp.PreviousNode = createdNode;
                }
                FindTreeNodeByValue(value).Count++;
            }
        }

        public CellNode FindTreeNodeByValue(double doubleValue)
        {
            CellNode current = this.Root;
            int value = Helper.GetIntValue(doubleValue);
            while (current != null && current.IntValue != value)
            {
                if (current.IntValue < value)
                    current = current.RightChild;
                else if (current.IntValue > value)
                    current = current.LeftChild;
            }
            return current;
        }

        public void DeleteKeyNodeByValue(double value)
        {
            CellNode temp = FindKeyNodeByValue(value);
            CellNode head = temp;
            if (temp != null)
            {
                while (head.PreviousNode != null)
                    head = head.PreviousNode;
                if (head.Count == 1)
                    DeleteTreeNode(Helper.GetIntValue(value));
                else
                {
                    temp.PreviousNode.NextNode = temp.NextNode;
                    if (temp.NextNode != null)
                        temp.NextNode.PreviousNode = temp.PreviousNode;
                    head.Count--;
                }
            }
        }

        private void DeleteTreeNode(int intValue)
        {
            CellNode current = FindTreeNodeByValue(intValue);
            if (!current.IsRoot)
            {
                if(current.IsLeaf)
                {
                    if(current.IsLeftChild)
                        current.Parent.LeftChild = null;
                    else
                        current.Parent.RightChild = null;
                    current.Parent = null;
                }
                else if(current.HasOneChild)
                {
                    var currentChild = current.HasLeftChild ? current.LeftChild : current.RightChild;
                    if (current.IsLeftChild)
                        current.Parent.LeftChild = currentChild;
                    else
                        current.Parent.RightChild = currentChild;
                    currentChild.Parent = current.Parent;
                    current.Parent = null;
                    current.LeftChild = null;
                    current.RightChild = null;
                    current.NextNode = null;
                }
                else if (current.HasTwoChildren)
                {
                    var candidate = FindCandidate(current);
                    DeleteTreeNode(candidate.IntValue);
                    current.IntValue = candidate.IntValue;
                    current.Count = candidate.Count;
                    current.NextNode = candidate.NextNode;
                }
            }
            else
            {
                if(current.IsLeaf)
                    this.Root = null;
                else if(current.HasOneChild)
                {
                    var currentChild = current.HasLeftChild ? current.LeftChild : current.RightChild;
                    if (currentChild.IsLeftChild)
                        current.LeftChild = null;
                    else
                        current.RightChild = null;
                    this.Root = currentChild;
                    currentChild.Parent = null;
                }
                else if(current.HasTwoChildren)
                {
                    var candidate = FindCandidate(current);
                    DeleteTreeNode(candidate.IntValue);
                    current.IntValue = candidate.IntValue;
                    current.Count = candidate.Count;
                    current.NextNode = candidate.NextNode;
                }
            }
        }

        public CellNode FindKeyNodeByValue(double value)
        {
            CellNode current = FindTreeNodeByValue(value);
            while (current.DoubleValue != Helper.GetDoubleValue(value))
                current = current.NextNode;
            if (current == null)
                throw new Exception("There is not following value in the tree!");
            return current;
        }

        public CellNode FindKeyNodeByKey(string key)
        {
            foreach (CellNode node in GetNodesInInOrder(this.Root))
            {
                CellNode temp = node;
                while (temp != null)
                {
                    if (temp.Key == key)
                        return temp;
                    temp = temp.NextNode;
                }
            }
            throw new Exception("There is not following word in dictionary!");
        }

        private CellNode FindCandidate(CellNode current)
        {
            current = current.LeftChild;
            while (current.RightChild != null)
                current = current.RightChild;
            return current;
        }

        public List<CellNode> FindKeysWithCertainIntegerValue(int intValue)
        {
            List<CellNode> nodes = new List<CellNode>();
            CellNode temp = FindTreeNodeByValue(intValue);
            try
            {
                while (temp != null)
                {
                    if (temp.Key != "")
                        nodes.Add(temp);
                    temp = temp.NextNode;
                }
                return nodes;
            }
            catch
            {
                throw new Exception("Dictionary doesn't contain following value!");
            }
        }

        private int GetTreeHeight(CellNode root)
        {
            if (root == null)
                return -1;
            else
                return Math.Max(GetTreeHeight(root.LeftChild), GetTreeHeight(root.RightChild)) + 1;
        }

        public int Height
        {
            get
            {
                return GetTreeHeight(this.Root);
            }
        }

        public CellNode MostLoadedNode
        {
            get
            {
                return FindMostLoadedNode(this.Root);
            }
        }

        private CellNode FindMostLoadedNode(CellNode root)
        {
            CellNode maximum = new CellNode();
            maximum.Count = 1;
            foreach (CellNode node in GetNodesInInOrder(root))
            {
                if (node.Count > maximum.Count)
                    maximum = node;
            }
            return maximum;
        }
    }
}
