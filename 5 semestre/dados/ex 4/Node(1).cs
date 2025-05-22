namespace senac.jogosdigitais.estruturaDeDados.questao2
{
    public class Node
    {
        public int Data { get; set; }
        public Node Left { get; set; }  // Filho esquerdo
        public Node Right { get; set; } // Filho direito

        public Node(int data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
    }
}


