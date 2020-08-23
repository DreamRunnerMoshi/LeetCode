using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ProgramClient
{
    public class _1377FrogPositionAfterTSeconds
    {
        public double FrogPosition(int n, int[][] edges, int t, int target)
        {
            var queue = new Queue();
            var start = new Node(-1, edges[0][0]);
            queue.Enqueue(start);

            var visited = new HashSet<Node>();

            int i = 0;
            while (queue.Count > 0)
            {
                var parent = (Node)queue.Dequeue();
                var childNodes = new List<Node>();

                var visitingPoint = new Node(edges[i]);

                while (!visited.Contains(visitingPoint) && parent.value == visitingPoint.parent)
                {
                    if (i == n) break;

                    childNodes.Add(visitingPoint);
                    i++;
                    visitingPoint = new Node(edges[i]);
                }

                var probability = 1.0 / childNodes.Count();

                foreach (var p in childNodes)
                {

                    p.probability = parent.probability * probability;
                    if (p.value == target) return p.probability;
                    queue.Enqueue(p);
                }

                visited.Add(parent);
            }

            return 0.0;
        }
    }

    public class Node
    {
        public int parent;
        public int value;
        public double probability = 1.0;

        public Node(int x, int y)
        {
            this.parent = x;
            this.value = y;
        }

        public Node(int[] point)
        {
            this.parent = point[0];
            this.value = point[1];
        }

        public override bool Equals(Object p)
        {
            var anotherPoint = (Node)p;
            return (parent == anotherPoint.parent && value == anotherPoint.value);
        }

        public override int GetHashCode()
        {
            return parent ^ value;
        }
    }
}
