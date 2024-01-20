using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace IT_step.Home_Works
{
    internal class HW10
    {
        class MyList<T> : IEnumerable<T>
        {
            private T[] arr;
            private readonly List<int> indexes = new();
            public int Capacity { get { return arr.Length; } }
            public int indexer = 0;
            public int Count { get; private set; }

            public T this[int index]
            {
                get
                {
                    try
                    {
                        return arr[index];
                    }
                    catch (IndexOutOfRangeException err)
                    {
                        Console.WriteLine(err.Message);
                        return default;
                    }
                }
                set
                {
                    try
                    {
                        arr[index] = value;
                        if (!indexes.Contains(index))
                        {
                            indexes.Add(index);
                            Count++;
                        }
                    }
                    catch (IndexOutOfRangeException err)
                    {
                        Console.WriteLine(err.Message);
                        Console.Write("\n\n");
                        Console.WriteLine("Index you Entered was out of index range but we will increase length for you");
                        IncreaseSize(index);
                        arr[index] = value;
                        indexes.Add(index);
                        Count++;
                    }

                }
            }
            public void Pop()
            {
                if (arr.Length > 0)
                {
                    indexes.Sort();
                    var deletedIndex = indexes[0];
                    var newArr = new T[arr.Length - 1];
                    Array.Copy(arr, 0, newArr, 0, deletedIndex);
                    Array.Copy(arr, deletedIndex + 1, newArr, deletedIndex, arr.Length - deletedIndex - 1);
                    indexes.RemoveAt(0);
                    Count--;
                }
            }
            public void RemoveAt(int index)
            {
                if (!indexes.Contains(index))
                {
                    return;
                }


                var newArr = new T[arr.Length - 1];
                Array.Copy(arr, 0, newArr, 0, index);
                Array.Copy(arr, index + 1, newArr, index, arr.Length - index - 1);
                indexes.Remove(index);
                Count--;
            }

            public void add(T item)
            {
                if (indexer >= arr.Length)
                {
                    IncreaseSize();
                }
                while (indexer < arr.Length)
                {
                    if (!indexes.Contains(indexer))
                    {
                        indexes.Add(indexer);
                        Count++;

                        arr[indexer] = item;
                    }
                }
            }
            private void IncreaseSize(int length)
            {
                if (length > arr.Length)
                {
                    var newArr = new T[length];
                    arr.CopyTo(newArr, 0);
                    arr = newArr;
                }
            }
            private void IncreaseSize()
            {
                var newArr = new T[arr.Length * 2];
                arr.CopyTo(newArr, 0);
                arr = newArr;
            }

            public IEnumerator<T> GetEnumerator()
            {
                foreach (var item in arr)
                {
                    yield return item;
                }
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }
    }
}
