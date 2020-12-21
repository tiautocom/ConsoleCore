using GameTop.Interface;

namespace GameTop.lib
{
    public class Jogador2 : iJogador
    {
        public string Corre()
        {
            return ("Maradona está chutando \n");
        }

        public string Chuta()
        {
            return ("Maradona está correndo \n");
        }
        public string Passe()
        {
            return ("Maradonaestá passando \n");
        }
    }
}