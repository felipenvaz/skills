using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skills
{
    public static class Searching
    {
        /// <summary>
        /// Returns a step map (shows the best path to go from one point to another)
        /// </summary>
        /// <param name="map">a map to search the path. 1 is the starting point, 2 is the end point, 3 are obstacles and the rest should be 0's</param>
        /// <returns>If a map has a startpoint and endpoint, returns the path map, otherwise returns null</returns>
        public static int[,] AStarSearch(int[,] map)
        {
            List<Tuple<int, int>> openNodes = new List<Tuple<int, int>>();
            List<Tuple<int, int>> closedNodes = new List<Tuple<int, int>>();
            Tuple<int, int> startPoint = null;
            Tuple<int, int> endPoint = null;

            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int y = 0; y < map.GetLength(1); y++)
                {
                    if (map[i, y] == 1)
                    {
                        startPoint = new Tuple<int, int>(i, y);
                    }
                    else if (map[i, y] == 2)
                    {
                        endPoint = new Tuple<int, int>(i, y);
                    }
                }
            }

            if (startPoint == null || endPoint == null)
            {


                return null;
            }

            var validatePoint = new Func<Tuple<int, int>, bool>((currentPoint) => {
                if(currentPoint.Item1 < 0 || currentPoint.Item1 >= map.GetLength(0)
                || currentPoint.Item2 < 0 || currentPoint.Item2 >= map.GetLength(1))
                {
                    return false;
                }

                return true;
            });
            var analizeCurrentPoint = new Func<Tuple<int, int>, List<Tuple<int, int>>>((currentPoint) =>
            {
                int diffX = endPoint.Item1 - currentPoint.Item1;
                int diffY = endPoint.Item2 - currentPoint.Item2;
                if (Math.Abs(diffX) >= Math.Abs(diffY))
                {

                }
                else
                {

                }

                return null;
            });
            openNodes.Add(startPoint);
            int[,] pathMap = new int[map.GetLength(0), map.GetLength(1)];

            while (openNodes.Count > 0)
            {

            }

            return pathMap;
        }
    }
}
