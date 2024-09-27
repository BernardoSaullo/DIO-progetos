using System;


namespace Estacionamento
{
    
    public class Program
    {
        static List<string> Estacionamento = new List<string>();

        public static void Main(string[] args)
        {
            while(true){

                // Console.Write("Valor cobrado por estacionar: ");
                // var valorEstacionar = Console.ReadLine();
                // Console.Write("Valor cobrado por hora: ");
                // var valorHora = Console.ReadLine();

                Console.Write(@" ---- MENU ----
1 - Cadastrar novo carro
2 - Excluir novo carro 
3 - Visualizar carros no estacionamento:  ");
                
                var entrada = Console.ReadLine();
                if(entrada == "1")
                {
                    CadastraCarro();
                }
                else if(entrada == "2")
                {
                    ExcluiCarro();
                }
                else if(entrada == "3")
                {
                    ListaCarro();
                }
                else if(entrada == "0")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Opção invalida!");
                }
            }
        }


        static void CadastraCarro()
        {
            Console.Write("Digite a placa do carro: ");
            string placa = Console.ReadLine();
            Estacionamento.Add(placa);
        }

        static int ListaCarro()
        {
            int i = -1;

            Console.WriteLine("=========== CARRO ==============");
            foreach( var carro in Estacionamento)
            {
                i++;
                Console.WriteLine($"{i} - {carro}");
                
            }
            return i;

        }

        static void ExcluiCarro()
        {
            var numeroDeCarros = ListaCarro();
            Console.Write("Digite o Indice do carro: ");
            string entrada = Console.ReadLine();
            

            if(int.TryParse(entrada, out  int indice))
            {  
                if(indice > numeroDeCarros)
                {
                    Console.WriteLine("Indice escolhido fora do range");
                }

                else
                {
                    Estacionamento.RemoveAt(indice);
                }
            }

            else{
                Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
            }
        
        }
}

}