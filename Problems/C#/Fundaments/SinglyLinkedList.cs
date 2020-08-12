namespace Interview_Prep.Fundaments
{
    using System.Text;

    public class SinglyLinkedList
    {
        private Node first;
        public bool IsEmpty() 
        {
            return (first == null);
        }

        public void InsertFirst(int data) 
        {
            Node newNode = new Node
            {
                data = data,
                next = first
            };
            first = newNode;
        }

        public Node RemoveFirst() 
        {
            Node temp = first;
            first = first.next;
            return temp;
        }

        public string DisplayList() 
        {
            var sb = new StringBuilder();
            sb.AppendLine("All nodes...");

            Node current = first;
            while (current != null)
            {
                sb.AppendLine(current.Display());
                current = current.next;
            }
            sb.AppendLine("");

            return sb.ToString();
        }

        public void InsertLast(int data) 
        {
            Node current = first;

            while (current.next != null)
            {
                current = current.next;
            }

            Node newNode = new Node();
            newNode.data = data;
            current.next = newNode;
        }

    }

    public class Node
    {
        public int data;
        public Node next;

        public string Display()
        {
            return $"<{data}>";
        }
    }
}
