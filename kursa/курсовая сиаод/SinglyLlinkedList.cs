using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace курсовая_сиаод
{

    public class SinglyLlinkedList
    {
        public class Node
        {
            public int data;
            public Node next;
            public Node() { }
            public Node(int data, Node next = null)
            {
                this.data = data;
                this.next = next;
            }

        }
        public Node FirstNode = null;
        public int Length = 0;
        public void AddLast(Node node)
        {
            if (FirstNode == null)
            {
                FirstNode = node;
            }
            else
            {
                Node tmp = FirstNode;
                while (tmp.next != null)
                {
                    tmp = tmp.next;
                }
                tmp.next = node;
            }
            Length++;
        }
        public void AddAfter(int index, Node node)
        {
            if (index >= Length || index < 0) throw new ArgumentException(nameof(index));
            if (node.next != null) throw new ArgumentException(nameof(node));
            Node tmp = this.GetNode(index);
            node.next = tmp.next;
            tmp.next = node;
            Length++;
        }
        public Node GetNode(int index)
        {
            if (index >= Length || index < 0) throw new ArgumentException(nameof(index));
            Node node = FirstNode;
            for (int i = 0; i < index; i++)
            {
                node = node.next;
            }
            return node;
        }
        public void swap(int index1, int index2)
        {
            if (index1 >= Length || index1 < 0) throw new ArgumentException(nameof(index1));
            if (index2 >= Length || index2 < 0) throw new ArgumentException(nameof(index2));
            if (index1 == 0)
            {
                Node tmp1 = FirstNode;
                Node node = tmp1.next.next;
                Node tmp2 = this.GetNode(index2 - 1);
                tmp1.next.next = tmp2.next.next;
                Node nodeindex2 = tmp2.next;
                tmp2.next = tmp1.next;
                nodeindex2.next = node;
                tmp1.next = nodeindex2;
            }
            else if (index2 == 0)
            {
                Node tmp1 = this.GetNode(index1 - 1);
                Node node = tmp1.next.next;
                Node tmp2 = FirstNode;
                tmp1.next.next = tmp2.next.next;
                Node nodeindex2 = tmp2.next;
                tmp2.next = tmp1.next;
                nodeindex2.next = node;
                tmp1.next = nodeindex2;
            }
            else
            {
                Node tmp1 = this.GetNode(index1 - 1);
                Node node = tmp1.next.next;
                Node tmp2 = this.GetNode(index2 - 1);
                tmp1.next.next = tmp2.next.next;
                Node nodeindex2 = tmp2.next;
                tmp2.next = tmp1.next;
                nodeindex2.next = node;
                tmp1.next = nodeindex2;
            }

        }
        public Node remove(int index)
        {
            if (index >= Length || index < 0) throw new ArgumentException(nameof(index));
            Node node = null;
            if (index != 0)
            {
                Node tmp = this.GetNode(index - 1);
                node = tmp.next;
                tmp.next = node.next;
                node.next = null;
            }
            else
            {
                node = FirstNode;
                FirstNode = node.next;
            }
            return node;
        }
        public static SinglyLlinkedList GetRandomUnorderedList(int size)
        {
            SinglyLlinkedList tmp = new SinglyLlinkedList();
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                tmp.AddLast(new Node(rnd.Next(0, size)));
            }
            return tmp;
        }
        public static SinglyLlinkedList GetRandomOrderedList(int size)
        {
            SinglyLlinkedList tmp = new SinglyLlinkedList();
            Random rnd = new Random();
            int last = 0;
            for (int i = 0; i < size; i++)
            {
                int current = last + rnd.Next(0, 5);
                tmp.AddLast(new Node(current));
                last = current;
            }
            return tmp;
        }
        public static SinglyLlinkedList GetRandomOrderedInReverseOrderList(int size)
        {
            SinglyLlinkedList tmp = SinglyLlinkedList.GetRandomOrderedList(size);
            for (int i = 0; i < size/2; i++)
            {
                int tmpInt = tmp.GetNode(i).data;
                tmp.GetNode(i).data = tmp.GetNode(size - i - 1).data;
                tmp.GetNode(size - i - 1).data= tmpInt;
            }
            return tmp;
        }
        public static SinglyLlinkedList GetRandomPartlyOrderedList(int size,int PercentOfOrder)
        {
            SinglyLlinkedList tmp = new SinglyLlinkedList();
            Random rnd = new Random();
            int last = 0;
            for (int i = 0; i < size*PercentOfOrder/100; i++)
            {
                int current = last + rnd.Next(0, 5);
                tmp.AddLast(new Node(current));
                last = current;
            }
            for(int i = size * PercentOfOrder / 100;i<size;i++) 
                tmp.AddLast(new Node(rnd.Next(0, size)));
            return tmp;
        }
    }
}
