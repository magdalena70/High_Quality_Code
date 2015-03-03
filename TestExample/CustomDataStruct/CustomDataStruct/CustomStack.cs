
namespace CustomDataStruct
{
    using System;

    public class CustomStack<T>
    {
        private const int DefaultCapacity = 4;

        private T[] elements;
        private int index;

        public CustomStack(int capacity = DefaultCapacity)
        {
            this.elements = new T[capacity];
            // this.index = 0; // by default
        }

        public int Count
        {
            get { return this.index; }
        }

        /// <summary>
        /// Add new element
        /// </summary>
        /// <param name="element"></param>
        public void Push(T element)
        {
            if (this.index == this.elements.Length)
            {
                this.Resize();
            }
            this.elements[this.index] = element;
            this.index++;
        }

        /// <summary>
        /// Resizing array length
        /// </summary>
        private void Resize()
        {
            T[] newElements = new T[this.elements.Length * 2];

            for (int i = 0; i < this.elements.Length; i++)
            {
                newElements[i] = this.elements[i];
            }

            this.elements = newElements;
        }

        /// <summary>
        ///  Remove last element
        /// </summary>
        /// <returns>Return this element</returns>
        public T Pop()
        {
            if (this.index == 0)
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            var element = this.elements[this.index - 1];
            this.elements[this.index - 1] = default(T);
            this.index--;

            return element;
        }

        /// <summary>
        /// Return last element
        /// </summary>
        /// <returns></returns>
        public T Peek()
        {
            if (this.index == 0)
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            var element = this.elements[this.index - 1];

            return element;
        }

        /// <summary>
        /// Chack if stack contains some element
        /// </summary>
        /// <param name="element"></param>
        /// <returns>true or false</returns>
        public bool Contains(T element)
        {
            for (int i = 0; i < this.index; i++)
            {
                if (this.elements[i].Equals(element))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
