namespace GenericListTask
{
    using System;
    using System.Text;

    public class GenericList<T>
    {
        #region FIELDS

        private const int DefaultSize = 16;

        private T[] data;
        private int indexer;

        #endregion

        #region CONSTRUCTORS

        public GenericList()
            : this(DefaultSize)
        {
        }

        public GenericList(int size)
        {
            if (size < 4)
            {
                throw new ArgumentException("Lenght must be atleast 4 elements");
            }

            this.data = new T[size];
            this.indexer = 0;
        }

        #endregion

        #region PROPERTIES

        public int Count
        {
            get
            {
                return this.indexer;
            }
        }

        public int Capacity
        {
            get
            {
                return this.data.Length;
            }
        }

        public T this[int index]
        {
            get
            {
                if (index >= this.indexer || index < 0)
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }

                T result = this.data[index];
                return result;
            }

            set 
            {
                if (index >= this.indexer || index < 0)
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }

                this.data[index] = value;
            }
        }

        #endregion

        #region METHODS

        public void Add(T element)
        {
            if (this.indexer == this.Capacity)
            {
                this.ResizeList();
            }

            this.data[this.indexer] = element;
            this.indexer++;
        }

        public void InsertAt(int position, T value)
        {
            if (position >= this.indexer || position < 0)
            {
                throw new IndexOutOfRangeException("Index out of range");
            }

            int newSize = this.Capacity + 1;

            if (newSize >= this.Capacity)
            {
                newSize = this.Capacity * 2;
            }

            var tmpArray = new T[newSize];

            for (int j = 0, i = 0; i < this.Count; i++, j++)
            {
                T tmp = this.data[i];

                if (i == position)
                {
                    j++;
                    tmpArray[i] = value;
                }

                tmpArray[j] = tmp;
            }

            this.data = tmpArray;
            this.indexer++;
        }

        public void FindElement(T value)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this.data[i].Equals(value))
                {
                    Console.WriteLine("Position: {0}", i);
                    return;
                }
            }

            Console.WriteLine("Nothing found");
        }

        public T Min<T>() where T : IComparable<T>, IComparable
        {
            var min = this.data[0];

            for (int i = 1; i < this.Count; i++)
            {
                T item = (dynamic)this.data[i];
                if (item.CompareTo(min) < 0)
                {
                    min = this.data[i];
                }
            }

            return (dynamic)min;
        }

        public T Max<T>() where T : IComparable<T>, IComparable
        {
            var max = this.data[0];

            for (int i = 1; i < this.Count; i++)
            {
                T item = (dynamic)this.data[i];
                if (item.CompareTo(max) > 0)
                {
                    max = this.data[i];
                }
            }

            return (dynamic)max;
        }

        public void RemoveAt(int position)
        {
            if (position >= this.Count || position < 0)
            {
                throw new IndexOutOfRangeException("Index out of range");
            }

            int newSize = this.Capacity;
            var tmpArray = new T[newSize];

            for (int j = 0, i = 0; i < tmpArray.Length; i++, j++)
            {
                if (i == position)
                {
                    j++;
                }

                if (j == this.Capacity)
                {
                    break;
                }

                tmpArray[i] = this.data[j];
            }

            this.data = tmpArray;
            this.indexer--;
        }

        public void Clear()
        {
            this.data = new T[this.Capacity];
            this.indexer = 0;
        }

        public override string ToString()
        {
            var toStr = new StringBuilder();

            foreach (var item in this.data)
            {
                toStr.Append(item).AppendLine();
            }

            return toStr.ToString();
        }

        // auto-grow functionality
        private void ResizeList()
        {
            int newSize = this.Capacity * 2;
            T[] newData = new T[newSize];

            for (int i = 0; i < this.Capacity; i++)
            {
                newData[i] = this.data[i];
            }

            this.data = newData;
        }

        #endregion
    }
}
