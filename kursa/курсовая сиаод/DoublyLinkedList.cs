using System;

namespace курсовая_сиаод
{
    public class DoublyLinkedList
    {
        public class Node
        {
            public int data;
            public Node prev;
            public Node next;

            public Node(int data, Node prev = null, Node next = null)
            {
                this.data = data;
                this.prev = prev;
                this.next = next;
            }
        }

        public Node FirstNode = null;
        public Node LastNode = null;
        public int Length = 0;

        public void AddLast(Node node)
        {
            if (FirstNode == null)
            {
                FirstNode = node;
                LastNode = node;
            }
            else
            {
                LastNode.next = node;
                node.prev = LastNode;
                LastNode = node;
            }
            Length++;
        }

        public void AddAfter(int index, Node node)
        {
            if (index >= Length || index < 0) throw new ArgumentException(nameof(index));
            if (node.next != null || node.prev != null) throw new ArgumentException(nameof(node));

            Node tmp = GetNode(index);
            node.next = tmp.next;
            node.prev = tmp;
            if (tmp.next != null)
            {
                tmp.next.prev = node;
            }
            tmp.next = node;
            Length++;
        }

        public Node GetNode(int index)
        {
            if (index >= Length || index < 0) throw new ArgumentException(nameof(index));

            Node node;
            if (index < Length / 2)
            {
                node = FirstNode;
                for (int i = 0; i < index; i++)
                {
                    node = node.next;
                }
            }
            else
            {
                node = LastNode;
                for (int i = Length - 1; i > index; i--)
                {
                    node = node.prev;
                }
            }
            return node;
        }

        public void Swap(int index1, int index2)
        {
            if (index1 >= Length || index1 < 0) throw new ArgumentException(nameof(index1));
            if (index2 >= Length || index2 < 0) throw new ArgumentException(nameof(index2));

            Node node1 = GetNode(index1);
            Node node2 = GetNode(index2);

            Node prev1 = node1.prev;
            Node next1 = node1.next;
            Node prev2 = node2.prev;
            Node next2 = node2.next;

            if (prev1 != null)
            {
                prev1.next = node2;
            }
            else
            {
                FirstNode = node2;
            }

            if (next1 != null)
            {
                next1.prev = node2;
            }
            else
            {
                LastNode = node2;
            }

            if (prev2 != null)
            {
                prev2.next = node1;
            }
            else
            {
                FirstNode = node1;
            }

            if (next2 != null)
            {
                next2.prev = node1;
            }
            else
            {
                LastNode = node1;
            }

            node1.prev = prev2;
            node1.next = next2;
            node2.prev = prev1;
            node2.next = next1;
        }

        public Node Remove(int index)
        {
            if (index >= Length || index < 0) throw new ArgumentException(nameof(index));

            Node node = GetNode(index);

            if (node.prev != null)
            {
                node.prev.next = node.next;
            }
            else
            {
                FirstNode = node.next;
            }

            if (node.next != null)
            {
                node.next.prev = node.prev;
            }
            else
            {
                LastNode = node.prev;
            }

            node.prev = null;
            node.next = null;
            Length--;

            return node;
        }

        public static DoublyLinkedList GetRandomUnorderedList(int size)
        {
            DoublyLinkedList list = new DoublyLinkedList();
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                list.AddLast(new Node(rnd.Next(0, size)));
            }
            return list;
        }

        public static DoublyLinkedList GetRandomOrderedList(int size)
        {
            DoublyLinkedList list = new DoublyLinkedList();
            Random rnd = new Random();
            int last = 0;
            for (int i = 0; i < size; i++)
            {
                int current = last + rnd.Next(0, 5);
                list.AddLast(new Node(current));
                last = current;
            }
            return list;
        }

        public static DoublyLinkedList GetRandomOrderedInReverseOrderList(int size)
        {
            DoublyLinkedList list = GetRandomOrderedList(size);
            for (int i = 0; i < size / 2; i++)
            {
                int tmpInt = list.GetNode(i).data;
                list.GetNode(i).data = list.GetNode(size - i - 1).data;
                list.GetNode(size - i - 1).data = tmpInt;
            }
            return list;
        }

        public static DoublyLinkedList GetRandomPartlyOrderedList(int size, int percentOfOrder)
        {
            DoublyLinkedList list = new DoublyLinkedList();
            Random rnd = new Random();
            int last = 0;
            for (int i = 0; i < size * percentOfOrder / 100; i++)
            {
                int current = last + rnd.Next(0, 5);
                list.AddLast(new Node(current));
                last = current;
            }
            for (int i = size * percentOfOrder / 100; i < size; i++)
            {
                list.AddLast(new Node(rnd.Next(0, size)));
            }
            return list;
        }
    }
}