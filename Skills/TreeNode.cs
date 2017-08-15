

using System.Collections;
using System.Collections.Generic;

namespace Skills
{
    class TreeNode
    {
        private int value;
        private TreeNode left;
        private TreeNode right;

        public TreeNode(int value)
        {
            this.value = value;
        }

        public void addNode(int value)
        {
            if(value <= this.value)
            {
                if (this.left == null)
                {
                    this.left = new TreeNode(value);
                }
                else
                {
                    this.left.addNode(value);
                }
            }
            else
            {
                if (this.right == null)
                {
                    this.right = new TreeNode(value);
                }
                else
                {
                    this.right.addNode(value);
                }
            }
        }

        public IList<int> getSortedValues()
        {
            var values = new List<int>();
            if(this.left != null)
            {
                values.AddRange(this.left.getSortedValues());
            }

            values.Add(this.value);

            if (this.right != null)
            {
                values.AddRange(this.right.getSortedValues());
            }

            return values;
        }
    }
}
