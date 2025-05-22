namespace senac.jogosdigitais.estruturaDeDados.questao2
{
    public class Queue
    {
        public Node front; // Referência para o primeiro nó da fila
        public Node rear;  // Referência para o último nó da fila
        public Queue()
        {
            front = null;
            rear = null;
        }

        /*
        public void Enqueue(int data)
        {
            Node newNode = new Node(data);
            if (IsEmpty())
            {
                front = newNode;
                rear = newNode;
            }
            else
            {
                rear.Next = newNode;
            }
        }
        */

        
        public void Enqueue(int data)
        {
            Node newNode = new Node(data);
            if (IsEmpty())
            {
                front = newNode;
                rear = newNode;
            }
            else
            {
                rear.Next = newNode;
                rear = newNode; // Atualiza o rear para o novo nó
            }
        }
        
        public int Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("A fila está vazia.");
            }

            int data = front.Data;
            front = front.Next;
            if (front == null)
            {
                rear = null;
            }
            return data;
        }
        public bool IsEmpty()
        {
            return front == null;
        }
    }
}
