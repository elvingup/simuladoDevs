using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simuladobludevs
{
    internal class Program
    {/*Escreva um programa que implemente o jogo da forca.
      * O programa deve gerar uma palavra aleatória para ser adivinhada pelo jogador,
      * e permitir que o jogador insira uma letra por vez para tentar adivinhar a palavra.
      * O programa deve exibir a palavra com os espaços em branco para as letras não adivinhadas. */

        /*Crie um programa em C# que recebe uma string e verifica se ela é um palíndromo,
         * ou seja, se pode ser lida da mesma forma tanto da esquerda para a direita quanto da direita para a esquerda.
         * Desconsidere espaços em branco e letras maiúsculas ou minúsculas. Se a string for um palíndromo, 
         * exiba a mensagem "A string X é um palíndromo"; caso contrário, exiba a mensagem "A string X não é um palíndromo",
         * em que X é a string recebida como entrada.*/

        /*Ordenar uma lista de números sem utilizar os métodos da linguagem.
        Crie um programa em C# que recebe uma lista de números inteiros e ordena essa lista em ordem crescente.
        Exiba a lista ordenada na tela.*/
        static void Main(string[] args)
        {
            Console.WriteLine("desafio 3 programasa");
            Console.WriteLine("1- jogo da forca");
            Console.WriteLine("2- decubra se palindromo");
            Console.WriteLine("3- ordenar uma lista");
            Console.WriteLine("Digite a opção desejada");
            string op = Console.ReadLine();
            switch (op)
            {
                case "1":
                    Prog01();
                    break;
                    case "2":
                   Prog02();
                    break;
                    case "3":
                   Prog03();
                    break;
                    default:
                    break;


            }
        }
        static void Prog01()
        {   Console.Clear();
            Console.WriteLine("jogo da Forca");
            
            List<string> palavrasAleatoria = new List<string>();
            palavrasAleatoria.Add("carro");
            palavrasAleatoria.Add("aviao");
            palavrasAleatoria.Add("barco");
            Random rdn = new Random();
            char[] forca = palavrasAleatoria[rdn.Next(0,palavrasAleatoria.Count())].ToCharArray();
            char[] forcaPronta = new char[forca.Length];
            for (int i = 0; i < forca.Length; i++)
			{
                forcaPronta[i] = '_';
			}
            bool vencedor = true;
            while (vencedor)
            {
                Console.WriteLine("Digite uma letra");
                char letra = char.Parse(Console.ReadLine());
                int cont = 0;
                for (int i = 0; i < forca.Length; i++)
			{
                    if(letra == forca[i]) { forcaPronta[i] = forca[i];cont ++; } 
			}
             if(cont== 0) { Console.WriteLine("Errou!  tente novamente" ); };
             int contV =0;   
             for (int i = 0; i < forca.Length; i++)
                {
                    if (forca[i] == forcaPronta[i]) { contV++; } 

			      }
             if(contV == forcaPronta.Length) {
                 vencedor=false;
                 Console.WriteLine("voce venceu!");}
             Console.WriteLine(new string(forcaPronta));


            }

            Console.ReadKey();
	}
        static void Prog02()
        {Console.WriteLine("descubra se palindromo");
            Console.WriteLine(" digite uma palavra ou frase");
            List<char> palavra = new List<char>(Console.ReadLine().ToCharArray().ToList());
            List<char> palavra2 = new List<char>(palavra);
            palavra2.Reverse();
            int cont =0;
            for (int i = 0; i < palavra.Count; i++)
            {
                if (palavra[i]== palavra2[i]) { cont++;}
                //Console.WriteLine(cont);
			}
            if (cont == palavra.Count()) {Console.WriteLine($"A string {new string(palavra.ToArray())} é um palíndromo"); } 
            else { Console.WriteLine($"A string {new string(palavra.ToArray())} não é um palíndromo");};

Console.ReadKey();
        }
        static void Prog03()
        {
            Console.WriteLine(" programa 03 ordernar uma lista ");
            Console.WriteLine("digite uma lista de numeros");
            Console.WriteLine("digite s para organizar a lista");
       
            List<int> listn1 = new List<int>();
            while (true)
            {Console.WriteLine("digite proximo numero");
                string opN = Console.ReadLine();
                if(opN == "s") { break;}
                int n1= int.Parse(opN);
                
                listn1.Add(n1);


            }
            int[] arrayN= listn1.ToArray();
            Console.WriteLine("organizando a lista!");
            
            while (true)
            {   int check = 0;
                int contN = 1;
                for (int i = 0; i < arrayN.Length; i++)
			        {   
                        if((contN != arrayN.Length)&&(arrayN[i] > arrayN[contN]) )
                        {
                        int temp = arrayN[i];
                        arrayN[i]= arrayN[contN];    
                        arrayN[contN] = temp;
                        check ++;
                        Console.WriteLine("teste");
                        }
                        contN++;
                        
                    }
                    
			        
                if(check == 0) { break;}
			}
                string listFinal = " ordenado a lista = ";

                for (int i = 0; i < arrayN.Length; i++)
                {
                    listFinal = listFinal +"-"+arrayN[i];

			}
                Console.WriteLine(listFinal);
                Console.ReadKey();

            }




        }

	}








        

