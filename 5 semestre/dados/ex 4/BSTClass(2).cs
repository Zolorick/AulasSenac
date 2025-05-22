

namespace senac.jogosdigitais.estruturaDeDados.questao2
{
    class BSTClass
    {
        private Node root; // Raiz da árvore

        public BSTClass()
        {
            root = null;
        }
        public void Insert(int data)
        {
            root = InsertRecursive(root, data);
        }
        private Node InsertRecursive(Node currentNode, int data)
        {
            if (currentNode == null)
            {
                return new Node(data);
            }
            if (data < currentNode.Data)
            {
                currentNode.Left = InsertRecursive(currentNode.Left, data);
            }
            else if (data > currentNode.Data)
            {
                currentNode.Right = InsertRecursive(currentNode.Right, data);
            }
            return currentNode;
        }
        public bool IsEmpty()
        {
            return root == null;
        }

        public Node SearchRecursive(Node currentNode, int data)
        {
            if (currentNode == null)
            {
                return null;
            }
            else if (data < currentNode.Data)
            {
                return SearchRecursive(currentNode.Left, data);
            }
            else if (data > currentNode.Data)
            {
                return SearchRecursive(currentNode.Right, data);
            }
            else
            {
                return currentNode; // Encontrou o nó
            }
        }

    }
}

