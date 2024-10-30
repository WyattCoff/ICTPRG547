using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICTPRG547_Assesment1_WyattCoff
{
    public class SingleLinkedListNode<T>
    {
        public T Value { get; set; }
        public SingleLinkedListNode<T> Next { get; set; }

        public SingleLinkedListNode(T value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return $"Value: {Value}";
        }
    }


}
