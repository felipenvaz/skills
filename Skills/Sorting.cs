using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skills
{
    public class Sorting
    {
        public IList<int> treeSort(int[] input)
        {
            TreeNode node = null;
            if (input.Length > 0)
            {
                node = new TreeNode(input[0]);
                for (int i = 1; i < input.Length; i++)
                {
                    node.addNode(input[i]);
                }
            }
            return node == null ? new int [0] : node.getSortedValues();
        }
    }
}
