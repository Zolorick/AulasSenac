using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Estacionamento_poo
{
    public class Estacionamento
    {
        protected Carro[] Estacionados = new Carro[10];
        bool lotacao;
        protected int ordem;
            
        public void NovoCarro(int ordem) 
        {

            bool Lotacao(Carro[] Estacionados)
            {

                foreach (Carro carro in Estacionados)
                {
                    if (carro != null)
                    {
                        lotacao = true;
                        return lotacao; 
                    }

                }

                lotacao = false;
                return lotacao;
            }
            if (lotacao) 
            {

                for (int i = 0; i < Estacionados.Length; i++)
                {
                    if (Estacionados[i] == null) // Verifica se o espaço está vazio
                    {
                        Estacionados[i] = new Carro(ordem); // Adiciona o novo elemento
                        break;
                    }
                }

            }
            else 
            {
                Console.WriteLine("O estacionamento está cheio, volte mais tarde");
                ordem--;
            }

        }

        public void CarrosAtuais() 
        {
            for (int i = 0;i < Estacionados.Length; i++)
            { 
                Console.WriteLine(Estacionados[i]);
            }
        }
    }
}
