using System;

namespace MetodosCS
{
    public class Curso
    {
        static void Main(string[] args)
        {
            Curso curso = new Curso();
            curso.CriarCurso("GTI", "Raphael Risos", 1);
            Console.WriteLine(curso.Codigo);
            Console.WriteLine(curso.NomeCurso);
            Console.WriteLine(curso.NomeInstrutor);
            Console.Read();
        }
        

        int Codigo;
        string NomeCurso;
        string NomeInstrutor;
        int cargaHorario;
        int minimoAlunos;
        int maximoALunos;
        public void CriarCurso(string nome, string instrutor, int codigo)
        {
            this.NomeCurso = nome;
            this.NomeInstrutor = instrutor;
            this.Codigo = codigo;
        }

    }
}   
