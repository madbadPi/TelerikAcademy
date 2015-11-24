namespace Generics
{
    using System;
    using System.Collections.Generic;
    public class GenericList<T> //: IComparable<T> , but i have to implement the method CompateTo()
        where T : IComparable
    {
        private const int IniSize = 8;

        private T[] data;
        private int index; // starts from 1

        public GenericList()
        {
            this.data = new T[IniSize];
        }

        public GenericList(uint initialSize)
        {
            this.data = new T[initialSize];
            this.index = 0;
        }

        public int Count
        {
            get
            {
                return this.index;
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
                if (index <0 || index >= this.Count)
                {
                    throw new IndexOutOfRangeException("The index is ot of range");
                }
                return this.data[index];
            }        
        }

        public void Add(T element)
        {
            if (this.index == this.Capacity)
            {
                this.ResizeArray();
            }
            this.data[this.index] = element; 
            this.index++;           
        }        

        public T AccessAt(uint position) //position starts from 0
        {            
            if (position >= this.index)
            {
                throw new ArgumentOutOfRangeException("Positions is out of the range ");
            }           
            return this.data[position];
        }

        public void RemoveAt(int position) //position starts from 0
        {
            T[] newData = new T[this.Capacity];
            int newIndex = this.index - 1;

            if (position >= this.index || position < 0)
            {
                throw new ArgumentOutOfRangeException("Positions is out of the range ");
            }
            for (int i = 0; i < position; i++)
            {
                newData[i] = this.data[i];
            }
            for (int i = position; i < this.Count-1; i++)
            {
                newData[i] = this.data[i + 1];
            }
            this.data = newData;
            this.index = newIndex;
        }

        public void InsertAt(T element, int position) //position starts from 0
        {
            if (position < 0)
            {
                throw new ArgumentOutOfRangeException("Positions is out of the range ");
            }
            if (position >= this.Capacity)
            {
                this.ResizeArray();       
            }

            T[] newData = new T[this.Capacity];
            int newIndex = this.index + 1;

            for (int i = 0; i < position; i++)
            {
                newData[i] = this.data[i];
            }
            for (int i = position; i < this.Count + 1; i++)
            {
                if (i == position)
                {
                    newData[i] = element;
                }
                else
                {
                    newData[i] = this.data[i - 1];
                }
            }           
            this.data = newData;
            this.index = newIndex;
        }

        public int FindEl(T element) // return the index of the element starting from 0
        {
            for (int i = 0; i < this.Count; i++)
			{
			    if (this.data[i].Equals(element))
                {
                    return i; 
                }
			}
            return -1;
        }

        public T Min()
        {
            T bestResult = this.data[0];
            for (int i = 1; i < this.Count; i++)
            {
                if (this.data[i].CompareTo(bestResult) < 0)
                {
                    bestResult = this.data[i];
                }
                //if ((dynamic)this.data[i] < (dynamic)bestResult)
                //{
                //    bestResult = this.data[i];
                //}
            }

            return bestResult;
        }

        public T Max()
        {
            T bestResult = this.data[0];
            for (int i = 1; i < this.Count; i++)
            {
                if (this.data[i].CompareTo(bestResult) > 0)
                {
                    bestResult = this.data[i];
                }
                //if ((dynamic)this.data[i] > (dynamic)bestResult)
                //{
                //    bestResult = this.data[i];
                //}
            }
            return bestResult;
        }

        public void Clear()
        {
            T[] newData = new T[this.Capacity];
            int newIndex = 0;
            this.data = newData;
            this.index = newIndex;
        }

        public override string ToString()
        {
            string result = String.Empty;
            if (this.Count == 0)
            {
                return "Empty String";
            }
            for (int i = this.Count - 1; i >= 0; i--)
            {
                result = this.data[i] + "\n" + result;
            }
            return result;
        }

        private void ResizeArray()
        {
            T[] newData = new T[this.Capacity * 2];
            int newIndex = this.index;

            for (int i = 0; i < this.Capacity; i++)
            {
                newData[i] = this.data[i];
            }
            data = newData;
            index = newIndex;
        }
    }
}
