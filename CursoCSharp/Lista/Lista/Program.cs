using System.Collections.Generic; ///lib que contem o método de lista
using System;
using System.Net.Http.Headers;
using System.Net.Mail;

namespace Lista
{
     class Program
    {
        static void Main(string[] args)
        {
            List<string> list1 = new List<string>(); //instanciando o obj lista

            list1.Add("Maria");//adicionando elementos a lista, tbm poderia passar um obj como new Produto(valores)
            list1.Add("Thor");
            list1.Add("Bob");
            list1.Add("Ana");
            list1.Add("Carla");
            list1.Add("Gina");
            list1.Add("Lucia");
            list1.Add("Bento");
            list1.Insert(2, "Marco"); //com o método insert podemos dizer em qual posição queremos inserir, nesse caso, na posição 2
            foreach (string obj in list1) //imprimindo cada obj na list para ver se deu certo
            {
                Console.WriteLine(obj); 
            }
            Console.WriteLine("Tamanho da lista: "+ list1.Count);//utilizando método count para contar a quantidade de elementos da lista
            string s1 = list1.Find(Teste); 
            Console.WriteLine("Qual o primeiro elemento da lista que começa com A? " + s1);
            string s2 = list1.Find(x => x[0] == 'B');//ou podemos utilizar uma expressão lambda ao invés de fazer a função fora
            Console.WriteLine("Qual o primeiro elemento da lista que começa com B? " + s2);
            string s3 = list1.FindLast(x => x[0] == 'M');//assim como Find procura pelo primeiro elemento, Findlast procura pelo ultimo elemento
            Console.WriteLine("Qual o último elemento da lista que começa com M? " + s3);
            int s4 = list1.FindIndex(x => x[0] == 'M');//raciocinio similar ao do find, mas nesse caso ele trás a posição
            Console.WriteLine("Qual a posição do primeiro elemento que começa com M? " + s4);
            int s5 = list1.FindLastIndex(x => x[0] == 'M');//raciocinio similar ao do findlast, mas nesse caso ele trás a posição

            Console.WriteLine("--------------------------------------------------------------------------------------------");

            Console.WriteLine("Qual a posição do último elemento que começa com M? " + s5);
            List<string> list2 = list1.FindAll(x => x.Length == 5); //criando uma nova lista que irá conter meu resultado filtrado com a função findall para trazer apenas elemento que tem 5 caracteres
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("--------------------------------------------------------------------------------------------");

            list1.Remove("Thor");// usado para remover um elemento da lista
            foreach(string obj in list1)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("--------------------------------------------------------------------------------------------");

            list1.RemoveAll(x => x[0] == 'M');//usado para remover os elementos que contenham determinado predicato, nesse caso, todos que iniciando com M
            foreach (string obj in list1)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("--------------------------------------------------------------------------------------------");

            list1.RemoveAt(1);//removerá o elmento da lista baseado na posição
            foreach (string obj in list1)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("--------------------------------------------------------------------------------------------");

            list1.RemoveRange(2, 2);//removerá a partir da posição dois, dois elementos
            foreach (string obj in list1)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("--------------------------------------------------------------------------------------------");


        }
        //defindo a função Teste que traz o elemento de determina posição que é igual a A
        static bool Teste(string s)
        {
            return s[0] == 'A';
        }
    }
}