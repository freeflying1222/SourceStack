using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    public class DLinkNode
    {
        public DLinkNode Previous { get; set; }
        public DLinkNode Next { get; set; }

        public int Value { get; set; }

        public void AddAfter(DLinkNode node)
        {

            if (this.Next != null)
            {
                node.Next = this.Next;
            }
            node.Previous = this;
            this.Next = node;
                this.Next.Previous = node;
        }

        //public void AddBefore()

        public void Delete() { }
        public void Swap() { }
        //public void Delete() { }
    }
}
