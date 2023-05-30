using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Math;

namespace PEDRAPAPELTESOURA
{
    class Program   
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputcpu;
            int randomInt;
            bool playAgain = true;
            while (playAgain)
            {
                int scoreplayer = 0;
                int scorecpu = 0;
            }
            while (scoreplayer > 3 && scorecpu <3)
            {
                
                
                Console.WriteLine("Escolha entre Pedra, Papel ou Tesoura:  ");
                inputPlayer = Console.Readline();
                inputPlayer = inputPlayer.ToUpper();

                Random rnd =  new Random();
                randomInt = rnd.Next(1,4);
                switch(randomInt)
                {
                    case 1:
                    inputcpu = "Pedra";
                    Console.WriteLine("Computador escolheu Pedra");
                
                    if(inputPlayer == "PEDRA")
                    {
                        console.WriteLine("EMPATE");
                    }
                    else if( inputPlayer == "PAPEL")
                    {
                        console.WriteLine("O jogador ganhou!");
                        scoreplayer++;           
                    }
                    else if( inputPlayer == "TESOURA")
                    {
                        console.WriteLine("O Computador ganhou!");
                        scorecpu++;           
                    }
                    break;
                    case 2:
                    inputcpu = "Papel";
                    Console.WriteLine("Computador escolheu Papel");
                
                    if(inputPlayer == "PEDRA")
                    {
                        console.WriteLine("O computador ganhou!");
                        scorecpu++;
                    }
                    else if( inputPlayer == "PAPEL")
                    {
                        console.WriteLine("Empate");          
                    }
                    else if( inputPlayer == "TESOURA")
                    {
                        console.WriteLine("O Jogador ganhou!");
                        scoreplayer++;           
                    }
                    break;
                    case 3:
                    inputcpu = "Tesoura";
                    Console.WriteLine("Computador escolheu tesoura");
                
                    if(inputPlayer == "PEDRA")
                    {
                        console.WriteLine("O Jogador ganhou!");
                        scoreplayer++;
                    }
                    else if( inputPlayer == "PAPEL")
                    {
                        console.WriteLine("O computador ganhou"); 
                        scorecpu++;         
                    }
                    else if( inputPlayer == "TESOURA")
                    {
                        console.WriteLine("EMPATE");
                    }
                    break;
                    default:
                    Console.WriteLine("Entrada inválida");
                    break;
                }
                if(scoreplayer ==3 )
                {   
                    Console.WriteLine("Jogador Ganhou!");
                }
                else if(scorecpu ==3 )
                {
                    Console.WriteLine("Computador ganhou!");
                }
                else
                {

                }
                Console.Writeline("Voce quer jogar denovo? [S/N]");
                string loop = Console.Readline();
                if (loop == "S")
                {
                    playAgain == true;
                }
              
                else if(loop == "N");
                {
                    playAgain = false;
                }
            }
            
            
        }
    }
}