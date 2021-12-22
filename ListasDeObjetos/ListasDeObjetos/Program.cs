using System;
using System.Collections.Generic;

namespace ListasDeObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            var aulaIntro = new Aula("Introdução às Coleções", 20);
            var aulaModelando = new Aula("Modelando a classe aula", 18);
            var aulaSets = new Aula("Trabalhando com conjuntos", 16);

            List<Aula> aulas = new List<Aula>();
            aulas.Add(aulaIntro);
            aulas.Add(aulaModelando);
            aulas.Add(aulaSets);

            Imprimir(aulas);

            //Ordenar a lista
            aulas.Sort();
            Imprimir(aulas);

            aulas.Sort((este, outro) => este.Tempo.CompareTo(outro.Tempo));
            Imprimir(aulas);
        }

        private static void Imprimir(List<Aula> aulas)
        {
            Console.Clear();
            foreach(var aula in aulas)
            {
                Console.WriteLine(aula);
                Console.WriteLine();
            }
        }
    }

    class Aula : IComparable
    {
        private string titulo;
        private int tempo;

        public Aula(string titulo, int tempo)
        {
            this.titulo = titulo;
            this.Tempo = tempo;
        }

        public string Titulo { get => titulo; set => titulo = value; }
        public int Tempo { get => tempo; set => tempo = value; }

        public int CompareTo(object obj)
        {
            Aula aula = obj as Aula;
            return this.titulo.CompareTo(aula.titulo);
        }

        public override string ToString()
        {
            return $"[Título: {titulo}, Tempo: {Tempo}]";
        }
    }
}
