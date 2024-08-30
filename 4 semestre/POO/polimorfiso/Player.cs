using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_polimorfismo
{
    public class Player
    {
        public string nome { get; set; }
        public string lingua { get; set; }
        public float vidaMaxima {  get; set; } 
        public float dano { get; set; }

        public Player(string nome, string lingua, float vidaMaxima, float dano) 
        {
            nome = nome;
            lingua = lingua;
            vidaMaxima = vidaMaxima;
            dano = dano;
        }

        //metodos
        public void Morrer(string lingua, string nome)
        {
            Console.WriteLine($"Eu morri! Disse {nome} em {lingua}");
        }

        public virtual void Falar() 
        { }

        public virtual void Atacar() 
        {
            
        }

        public virtual void VidaAtual()
        {

        }
        public virtual int ReceberDanoInt()
        { 
            return PontosDeDano;
        }

        public virtual float ReceberDanoFloat()
        {
            return PontosDeDano;
        }


     

    }
}
