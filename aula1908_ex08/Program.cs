using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula1908_ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //Byte é um tipo de dado, ele tem um intervalo que vai de 0 á 255
            byte dia;

            //o "Console.WriteLine" é a forma que se inseri uma frase na tela do programa
            //para que o usuário possa ver 
            Console.WriteLine("Digite um número de 1 a 7, para te dizer qual dia da semana corresponde: ");
            dia = Convert.ToByte(Console.ReadLine()); //Aqui você atribui o dado que o usuario
                                                      //inseriu na variável

            switch (dia) /*Um laço condicional na qual tem que executa uma unica entrada, 
                          * ou seja, ele avalia uma afirmação e executa conforme o case */
            {
                case 1: /*"case" se usa para mostra um dos casos da afirmação, 
                         * o valor ao lado é a opção de afirmação que vai ser avaliada */
                    Console.WriteLine("Domingo");/* a linha que vai ser executada caso a afirmação seja 
                                                  * correta */
                    break; /*caso a afirmação seje certa e tenha executado a linha da afirmação o 
                            * "break" é o comando que faz com que ele saia do laço e prossiga no 
                            * codigo ao invés de analisar todos os case. */
                case 2:
                    Console.WriteLine("Segunda-Feira");
                    break ;
                case 3:
                    Console.WriteLine("Terça-Feira");
                    break;
                case 4:
                    Console.WriteLine("Quarta-Feira");
                    break;
                case 5:
                    Console.WriteLine("Quinta-Feira");
                    break;
                case 6:
                    Console.WriteLine("Sexta-Feira");
                    break;
                case 7:
                    Console.WriteLine("Sabado");
                    break;
                default:
                    Console.WriteLine("Desculpe mas o número digitado não corresponde a um dia da semana");
                    break;
            }
            /*
            if(dia == 1) //o "if" é a condição "se" na qual faz uma comparação de uma condição, ela pega um valor e compara com outro que vc queira
            {
                Console.WriteLine("Domingo"); //a linha que vai ser executada caso a afirmação seja 
                                                  correta
            }else if(dia == 2) // o "else if" é o encadeamento do laço de repetição, é uma forma sucinta de encadear o laço.
            {
                Console.WriteLine("Segunda-Feira");
            }else if(dia == 3)
            {
                Console.WriteLine("Terça-Feira");
            }else if (dia == 4)
            {
                Console.WriteLine("Quarta-Feira");
            }else if(dia == 5)
            {
                Console.WriteLine("Quinta-Feira");
            }else if(dia == 6)
            {
                Console.WriteLine("Sexta-Feira");
            }else if(dia == 7)
            {
                Console.WriteLine("Sabado");
            }else //o "else" é a uma condição do laço que vc queira executar 
                  //caso a as condições anteriores não sejam verdadeiras.
            {
                Console.WriteLine("Não corresponde a nenhum dia da semana");
            }
            */

            Console.ReadKey(); //é uma forma se fazer com que a tela não seja fechada imediatamente
                               //após a execução do codigo, é uma gambiarra na verdade, o comando a pricipio
                               //é utilizado para outra finalizadade, mas por enquanto é o que temos.
        }
    }
}
