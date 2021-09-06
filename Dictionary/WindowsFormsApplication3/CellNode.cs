using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    class CellNode
    {
        public CellNode()
        {
            IntValue = 0;
            DoubleValue = 0;
            Key = "";
            Count = 1;
            Parent = null;
            PreviousNode = null;
            NextNode = null;
            LeftChild = null;
            RightChild = null;
        }

        public CellNode(int intValue)
        {
            IntValue = intValue;
            DoubleValue = 0;
            Key = "";
            Count = 1;
            Parent = null;
            PreviousNode = null;
            NextNode = null;
            LeftChild = null;
            RightChild = null;
        }

        public CellNode(int intValue, double doubleValue, string key)
        {
            IntValue = intValue;
            DoubleValue = doubleValue;
            Key = key;
            Count = 1;
            Parent = null;
            PreviousNode = null;
            NextNode = null;
            LeftChild = null;
            RightChild = null;
        }

        public bool IsRoot
        {
            get
            {
                return this.Parent == null;
            }
        }

        public bool HasLeftChild
        {
            get
            {
                return this.LeftChild != null;
            }
        }

        public bool HasRightChild
        {
            get
            {
                return this.RightChild != null;
            }
        }

        public bool IsLeftChild
        {
            get
            {
                return this.Parent.LeftChild == this;
            }
        }

        public bool IsLeaf
        {
            get
            {
                return this.LeftChild == null && this.RightChild == null;
            }
        }

        public bool HasOneChild
        {
            get
            {
                return (this.LeftChild != null && this.RightChild == null) || (this.LeftChild == null && this.RightChild != null);
            }
        }

        public bool HasTwoChildren
        {
            get
            {
                return this.LeftChild != null && this.RightChild != null;
            }
        }

        public int IntValue { get; set; }

        public double DoubleValue { get; set; }

        public string Key { get; set; }

        public CellNode Parent { get; set; }

        public CellNode PreviousNode { get; set; }

        public CellNode NextNode { get; set; }

        public CellNode LeftChild { get; set; }

        public CellNode RightChild { get; set; }

        public int Count { get; set; }
    }
}
