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

            public Node() { }

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

        // Остальные методы добавления, удаления, получения узла и т.д. аналогично реализации для односвязного списка, но с учетом работы с двумя ссылками на предыдущий и следующий элементы.

        // Примеры статических методов для создания различных видов списка аналогично реализации для односвязного списка.

        public static DoublyLinkedList GetRandomUnorderedList(int size)
        {
            DoublyLinkedList tmp = new DoublyLinkedList();
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                tmp.AddLast(new Node(rnd.Next(0, size)));
            }
            return tmp;
        }

        public static DoublyLinkedList GetRandomOrderedList(int size)
        {
            DoublyLinkedList tmp = new DoublyLinkedList();
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

        // Другие методы создания списков и операции с ними могут быть реализованы аналогично предыдущей реализации, но с учетом работы с двумя ссылками на предыдущий и следующий элементы.
    }
}