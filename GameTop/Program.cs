using System;
using GameTop.lib;

namespace GameTop
{
    class Program
    { 
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            var jogo = new JogoFODA(
                 new Jogador1(),
                 new Jogador3()
                 );
            jogo.IniciarJogo();
            
        }
    }

}
