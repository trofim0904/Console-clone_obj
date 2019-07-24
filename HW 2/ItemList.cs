using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HW_2
{
    class ItemList<T> : ICollection<T>, IList<T> where T : Item
    {
        T[] arr = new T[4];
        int length = 0;
        int capacity = 4;
        int currentIndex = 0;

        public ItemList() { }
        public ItemList(T[] item)
        {
            for(int i = 0; i < item.Length; i++)
            {
                Add(item[i]);
                //length++;
                //currentIndex++;
            }
        }

        public T this[int index]
        {
            get => arr[index];
            set
            {
                if (index == currentIndex)
                {
                    arr[index] = value; currentIndex++; length++;
                }
            }
        }
        public void RemoveAt(int index)//видалення по індексу
        {
            if (index < currentIndex)
            {
                for (int i = index - 1; i < length; i++)
                {
                    arr[i] = arr[i + 1];
                }
                arr[length] = null;
                length--;
                currentIndex--;
            }

        }

        public void Add(T item)
        {
            if (length == capacity)
            {

                T[] temp = new T[arr.Length * 2];
                Array.Copy(arr, temp, arr.Length);
                arr = temp;
                capacity *= 2;
            }

            arr[currentIndex++] = item;
            length = currentIndex;

        }
        public T[] create_Array()
        {
           T[] clone_arr = new T[length];
          
            for (int i = 0; i < length; i++)
            {
                clone_arr[i] = (T)arr[i].Clone();
            }
            return clone_arr;
        }

        public int Count => length;
        public int Capacity => capacity;






        public bool IsReadOnly => throw new NotImplementedException();

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(T item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, T item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        
    }
}
