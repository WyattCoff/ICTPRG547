using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICTPRG547_Assessment1_WyattCoff
{
    public class DoublyLinkedList<T> : ICollection<T>
    {
        public DoublyLinkedListNode<T> Head { get; private set; }
        public DoublyLinkedListNode<T> Tail { get; private set; }
        public int Count { get; private set; }
        public bool IsReadOnly => false;

        // Add item to the beginning
        public void AddFirst(T value)
        {
            AddFirst(new DoublyLinkedListNode<T>(value));
        }

        private void AddFirst(DoublyLinkedListNode<T> node)
        {
            DoublyLinkedListNode<T> temp = Head;
            Head = node;
            Head.Next = temp;

            if (Count == 0)
            {
                Tail = Head;
            }
            else
            {
                temp.Previous = Head;
            }
            Count++;
        }

        // Add item to the end
        public void AddLast(T value)
        {
            AddLast(new DoublyLinkedListNode<T>(value));
        }

        private void AddLast(DoublyLinkedListNode<T> node)
        {
            if (Count == 0)
            {
                Head = node;
            }
            else
            {
                Tail.Next = node;
                node.Previous = Tail;
            }
            Tail = node;
            Count++;
        }

        // Remove the first item
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
                else
                {
                    Head.Previous = null;
                }
            }
        }

        // Remove the last item
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
                    Tail = Tail.Previous;
                    Tail.Next = null;
                }
                Count--;
            }
        }

        // Adds an item at the beginning (ICollection<T> requirement)
        public void Add(T item)
        {
            AddFirst(item);
        }

        // Checks if the list contains a specific item
        public bool Contains(T item)
        {
            DoublyLinkedListNode<T> current = Head;
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

        // Copies the list items to an array
        public void CopyTo(T[] array, int arrayIndex)
        {
            DoublyLinkedListNode<T> current = Head;
            while (current != null)
            {
                array[arrayIndex++] = current.Value;
                current = current.Next;
            }
        }

        // Removes a specific item
        public bool Remove(T item)
        {
            DoublyLinkedListNode<T> current = Head;

            while (current != null)
            {
                if (EqualityComparer<T>.Default.Equals(current.Value, item))
                {
                    if (current.Previous != null)
                    {
                        current.Previous.Next = current.Next;
                    }
                    else
                    {
                        Head = current.Next;
                    }

                    if (current.Next != null)
                    {
                        current.Next.Previous = current.Previous;
                    }
                    else
                    {
                        Tail = current.Previous;
                    }

                    Count--;
                    return true;
                }
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
            DoublyLinkedListNode<T> current = Head;
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
