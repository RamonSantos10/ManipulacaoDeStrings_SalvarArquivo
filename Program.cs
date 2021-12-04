using System;
using static System.Console;

namespace AtividadeAleatoria_Treino
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "";

            Write("Digite o nome do arquivo a ser salvo: ");
            nome = ReadLine();

            nome = nome.TrimEnd().TrimStart().ToLower();

            // ESPAÇO ---
            if(nome.Contains(' ') == true)
            {
                nome = nome.Replace(' ', '_');
            }
            
            // A ---
            if(nome.Contains('ã') == true)
            {
                nome = nome.Replace('ã', 'a');
            }
            if(nome.Contains('â') == true)
            {
                nome = nome.Replace('â', 'a');
            }
            if(nome.Contains('á') == true)
            {
                nome = nome.Replace('á', 'a');
            }
            if(nome.Contains('à') == true)
            {
                nome = nome.Replace('à', 'a');
            }

            // C ---
            if(nome.Contains('ç') == true)
            {
                nome = nome.Replace('ç', 'c');
            }
            
            // O ---
            if(nome.Contains('ô') == true)
            {
                nome = nome.Replace('ô', 'o');
            }
            if(nome.Contains('ó') == true)
            {
                nome = nome.Replace('ó', 'o');
            }
            if(nome.Contains('ò') == true)
            {
                nome = nome.Replace('ò', 'o');
            }
            if(nome.Contains('õ') == true)
            {
                nome = nome.Replace('õ', 'o');
            }
            // E ---
            if(nome.Contains('é') == true)
            {
                nome = nome.Replace('é', 'e');
            }
            if(nome.Contains('è') == true)
            {
                nome = nome.Replace('è', 'e');
            }
            if(nome.Contains('ê') == true)
            {
                nome = nome.Replace('ê', 'e');
            }
            // I ---
            if(nome.Contains('í') == true)
            {
                nome = nome.Replace('í', 'i');
            }
            if(nome.Contains('ì') == true)
            {
                nome = nome.Replace('ì', 'i');
            }

            //Saída de Dados

            WriteLine($"Arquivo salvo como: {nome}");

        }
    }
}
