using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICTPRG547_Assesment1_WyattCoff
{
    public class SingleLinkedList<T> : ICollection<T>
    {
        public SingleLinkedListNode<T> Head { get; private set; }
        public SingleLinkedListNode<T> Tail { get; private set; }
        public int Count { get; private set; }
        public bool IsReadOnly => false;

        // Add an item to the start of the list
        public void AddFirst(T value)
        {
            AddFirst(new SingleLinkedListNode<T>(value));
        }

        private void AddFirst(SingleLinkedListNode<T> node)
        {
            SingleLinkedListNode<T> temp = Head;
            Head = node;
            Head.Next = temp;
            Count++;

            if (Count == 1)
            {
                Tail = Head;
            }
        }

        // Add an item to the end of the list
        public void AddLast(T value)
        {
            AddLast(new SingleLinkedListNode<T>(value));
        }

        private void AddLast(SingleLinkedListNode<T> node)
        {
            if (Count == 0)
            {
                Head = node;
            }
            else
            {
                Tail.Next = node;
            }
            Tail = node;
            Count++;
        }

        // Removes the first item in the list
        public void RemoveFirst()
        {
            if (Count != 0)
            {
                Head = Head.Next;
                Count--;
                if (Count == 0)
                {
                    Tail = null;
                }
            }
        }

        // Removes the last item in the list
        public void RemoveLast()
        {
            if (Count != 0)
            {
                if (Count == 1)
                {
                    Head = null;
                    Tail = null;
                }
                else
                {
                    SingleLinkedListNode<T> current = Head;
                    while (current.Next != Tail)
                    {
                        current = current.Next;
                    }
                    current.Next = null;
                    Tail = current;
                }
                Count--;
            }
        }

        // Adds an item at the beginning of the list (ICollection<T> requirement)
        public void Add(T item)
        {
            AddFirst(item);
        }

        // Checks if the list contains a specific item
        public bool Contains(T item)
        {
            SingleLinkedListNode<T> current = Head;
            while (current != null)
            {
                if (EqualityComparer<T>.Default.Equals(current.Value, item))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        // Copies the list items to an array starting at a specific index
        public void CopyTo(T[] array, int arrayIndex)
        {
            SingleLinkedListNode<T> current = Head;
            while (current != null)
            {
                array[arrayIndex++] = current.Value;
                current = current.Next;
            }
        }

        // Removes the first occurrence of a specific item
        public bool Remove(T item)
        {
            SingleLinkedListNode<T> previous = null;
            SingleLinkedListNode<T> current = Head;

            while (current != null)
            {
                if (EqualityComparer<T>.Default.Equals(current.Value, item))
                {
                    if (previous == null)
                    {
                        RemoveFirst();
                    }
                    else
                    {
                        previous.Next = current.Next;
                        if (current.Next == null)
                        {
                            Tail = previous;
                        }
                        Count--;
                    }
                    return true;
                }
                previous = current;
                current = current.Next;
            }
            return false;
        }

        // Clears the list
        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        // Enumerator to iterate through the list
        public IEnumerator<T> GetEnumerator()
        {
            SingleLinkedListNode<T> current = Head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
