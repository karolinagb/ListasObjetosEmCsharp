using System;
using System.Collections.Generic;

namespace ListaSomenteLeitura
{
    class Program
    {
        static void Main(string[] args)
        {
            Curso csharpColecoes = new Curso("C# Collections", "Marcelo Oliveira");
            csharpColecoes.Adiciona(new Aula("Trabalhando com listas", 21));
            Imprimir(csharpColecoes.Aulas);

            //Adicionar 2 aulas
            csharpColecoes.Adiciona(new Aula("Criando uma Aula", 20));
            csharpColecoes.Adiciona(new Aula("Modelando com coleções", 19));

            //imprimir
            Imprimir(csharpColecoes.Aulas);

            //Ordenar a lista de aulas
            //csharpColecoes.Aulas.Sort() = a interface IList não dá suporte ao método Sort

            //Copiar a lista para outra lista
            List<Aula> aulasCopiadas = new List<Aula>(csharpColecoes.Aulas);

            //Ordenar a cópia
            aulasCopiadas.Sort();

            Imprimir(aulasCopiadas);

            //Totalizar o tempo do curso
            Console.WriteLine(csharpColecoes.TempoTotal);

            //Imprimir os cursos
            Console.WriteLine(csharpColecoes);
        }

        private static void Imprimir(IList<Aula> aulas)
        {
            Console.Clear();
            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
                Console.WriteLine();
            }
        }
    }
}
