using System;
using System.Collections.Generic;
using System.Text;

namespace BiweeklyContest
{
    public class CinemaSeatAllocation
    {
        private HashSet<Point> reservedSet;

        public int MaxNumberOfFamilies(int n, int[][] reservedSeats)
        {
            reservedSet = GetSet(reservedSeats);
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    var point = new Point(i, j);

                    if (!reservedSet.Contains(point))
                    {
                        int localCount = 0;
                        for (int c = j; c < j + 4; c++)
                        {
                            point = new Point(i, c);

                            if (localCount == 0 && c == 3) break;
                            if (reservedSet.Contains(point)) break; 
                            localCount++;
                        }

                        if (localCount >= 4) count++;
                    }
                }
            }

            return count;
        }

        private HashSet<Point> GetSet(int[][] reservedSeats)
        {
            var set = new HashSet<Point>();

            for (int i = 0; i < reservedSeats.Length; i++)
            {
                set.Add(new Point(reservedSeats[i][0], reservedSeats[i][1]));
            }

            return set;
        }
    }

    public class Point
    {
        private int x;
        private int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override bool Equals(object obj)
        {
            var other = (Point)obj;
            return (x == other.x && y == other.y);
        }

        public override int GetHashCode()
        {
            return x ^ y;
        }
    }
}
