using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace LeetCode.Algorithms
{
    public class PriorityQueue
    {
        private readonly int _capacity;
        private int _size;
        private int[] _items;

        public PriorityQueue(int capacity = 1000, int[] items = null)
        {
            _capacity = capacity;
            _items = new int[capacity];
            _size = 0;

            if (items != null)
            {
                for (int i = 0; i < items.Length; i++)
                {
                    Insert(items[i]);
                }
            }
        }

        public int GetMax()
        {
            return _items[0];
        }

        public bool Insert(int value)
        {
            if (_size == _capacity) return false;
            _items[_size] = value;
            _size++;
            Heapify();
            return true;
        }

        public int Pop()
        {
            var parentIndex = 0;

            var rootItem = _items[parentIndex];
            var lastIndex = _size - 1;

            var first = _items[parentIndex];
            _items[parentIndex] = _items[lastIndex];
            _items[lastIndex] = -1;

            _size--;

            var leftIndex = GetLeftIndex(parentIndex);
            var rightIndex = GetRightIndex(parentIndex);

            var minIndex = Math.Min(leftIndex, rightIndex);

            if (minIndex >= _size)
                return rootItem;

            int biggerItemIndex = GetBiggerItemIndex(leftIndex, rightIndex);

            while (biggerItemIndex < _size && _items[biggerItemIndex] > _items[parentIndex])
            {
                var parentItem = _items[parentIndex];
                _items[parentIndex] = _items[biggerItemIndex];
                _items[biggerItemIndex] = parentItem;
                parentIndex = biggerItemIndex;
                leftIndex = GetLeftIndex(parentIndex);
                rightIndex = GetRightIndex(parentIndex);
                biggerItemIndex = GetBiggerItemIndex(leftIndex, rightIndex);
            }

            return rootItem;
        }

        private int GetBiggerItemIndex(int leftIndex, int rightIndex)
        {
            if (rightIndex >= _size) return leftIndex;

            return _items[leftIndex] > _items[rightIndex]
                ? leftIndex : rightIndex;
        }

        private void Heapify()
        {
            if (_size <= 1) return;
            var childIndex = _size - 1;
            var parentIndex = GetParentIndex(childIndex);

            while (parentIndex >= 0 && _items[parentIndex] < _items[childIndex])
            {
                var parent = _items[parentIndex];
                var child = _items[childIndex];

                _items[parentIndex] = child;
                _items[childIndex] = parent;

                childIndex = parentIndex;
                parentIndex = GetParentIndex(parentIndex);
            }
        }

        private int GetParentIndex(int i) { return i % 2 == 0 ? i / 2 - 1 : i / 2; }
        private int GetLeftIndex(int i) { return 2 * i + 1; }
        private int GetRightIndex(int i) { return 2 * i + 2; }

    }
}
