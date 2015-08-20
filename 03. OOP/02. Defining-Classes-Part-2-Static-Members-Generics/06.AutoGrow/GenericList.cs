using System;
using System.Collections.Generic;

namespace AutoGrow
{
    public class GenericList<T>
    {
        //Field
        private int capacity;
        private T[] elements;
        private int count = 0;

        //Property
        public int Capacity
        {
            get
            {
                return this.capacity;
            }
        }

        public int Count
        {
            get
            {
                return this.count;
            }
        }

        //Constructor

        public GenericList(int Capacity)
        {
            elements = new T[Capacity];
            this.capacity = Capacity;
        }

        //Methods

        public void AddElement(T element)
        {
            this.elements[count] = element;
            count++;
        }

        public T GetElement(int index)
        {
            if (index < 0)
            {
                throw new ArgumentException("Index should be positive number!");
            }
            if (index > count)
            {
                throw new ArgumentException("No such element, elements are less than the number you have entered");
            }
            return this.elements[index];
        }

        public T[] RemoveElement(int index)
        {
            if (index < 0)
            {
                throw new ArgumentException("Index should be positive number!");
            }
            if (index > count - 1)
            {
                throw new ArgumentException("No such element, elements are less than the number you have entered");
            }

            for (int i = 0; i < count; i++)
            {
                if (i == index)
                {
                    while (i != count)
                    {
                        elements[i] = elements[i + 1];
                        i++;
                    }
                    count--;
                }
            }
            return elements;
        }

        public T[] InsertElement(T element, int index)
        {
            if (index < 0)
            {
                throw new ArgumentException("Index should be positive number!");
            }

            if (index >= count)
            {
                count = index + 1;
            }

            this.elements[index] = element;

            return elements;
        }

        public T[] Clear()
        {
            for (int i = 0; i < count; i++)
            {
                elements[i] = default(T);
            }
            count = 0;
            return elements;
        }

        public int GetIndexOf(T element)
        {
            int result = 0;

            for (int i = 0; i < count; i++)
            {
                if (elements[i].Equals(element))
                {
                    result = i;
                    break;
                }
                else
                {
                    result = -1;
                }
            }

            if (result == -1)
            {
                throw new ArgumentException("No such element!");
            }

            return result;
        }

        public void AutoGrow ()
        {
            capacity *= 2;

            T[] newElements = new T[capacity];

            for (int i = 0; i < elements.Length; i++)
            {
                newElements[i] = elements[i];
            }
            elements = newElements;
        }
    }
}
