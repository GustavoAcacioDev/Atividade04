using System;

namespace Atividade04
{
    class Program
    {
        static void Main(string[] args)
        {
            Celular galaxy = new Celular();
            galaxy.modelo = "Galaxy S9";
            galaxy.cor = "Branco";
            galaxy.tamanho = 14.7f;


            Console.WriteLine("Você deseja ligar o celular?");
            galaxy.retorno = galaxy.TraduzirConsole( Console.ReadLine() );
            Console.WriteLine(galaxy.LigandoCelular());
            if(galaxy.retorno == true){


                Console.WriteLine("Você deseja fazer uma ligação?");
                galaxy.retorno = galaxy.TraduzirConsole( Console.ReadLine() );
                Console.WriteLine(galaxy.FazendoLigacao());


                Console.WriteLine("Você deseja enviar uma mensagem?");
                galaxy.retorno = galaxy.TraduzirConsole( Console.ReadLine() );
            
                if(galaxy.retorno){

                    Console.WriteLine(galaxy.MandandoMensagem());
                    string mensagemArmazenada = Console.ReadLine();
                    Console.WriteLine("Você enviou a seguinte mensagem: "+mensagemArmazenada);
                }else{
                    Console.WriteLine("Você não enviou nenhuma mensagem");
                }

                Console.WriteLine("Você deseja desligar o celular?");
                galaxy.retorno = galaxy.TraduzirConsole( Console.ReadLine() );
                Console.WriteLine(galaxy.Desligando());
            
            }else{
                Console.WriteLine("O celular está desligado");
            }
        }
    }
}
