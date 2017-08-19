using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skills
{
    public static class Sorting
    {
        public static IList<int> treeSort(IList<int> input)
        {
            TreeNode node = null;
            if (input.Count > 0)
            {
                node = new TreeNode(input[0]);
                for (int i = 1; i < input.Count; i++)
                {
                    node.addNode(input[i]);
                }
            }
            return node == null ? new int[0] : node.getSortedValues();
        }

        public static IList<int> quickSort(IList<int> elements)
        {
            if (elements.Count > 1)
            {
                IList<int> before = new List<int>();
                var pivot = elements.Last();
                IList<int> after = new List<int>();

                for(var i = 0; i < elements.Count - 1; i++)
                {
                    if(elements[i] > pivot)
                    {
                        after.Add(elements[i]);
                    }else
                    {
                        before.Add(elements[i]);
                    }
                }
                before = quickSort(before);
                after = quickSort(after);

                List<int> result = new List<int>();
                result.AddRange(before);
                result.Add(pivot);
                result.AddRange(after);

                return result;
            }
            else
            {
                return elements;
            }
        }
    }
}
