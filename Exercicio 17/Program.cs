using Exercicio_17.Entities;
using System;

namespace Exercicio_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instacia um comentario já com uma mensagem
            Comment comment = new Comment("Have a nice trip");
            //Instancia um post com a data, titulo, conteudo, e quantidade de likes
            Post post = new Post(DateTime.Parse("21/06/2018"), "Title", "Content", 12);
            //Chama a variavel post e a função AddComment passando como argumento o comentario
            post.AddComment(comment);

            Console.WriteLine(post);

            Console.WriteLine("Press any key to finish");
            Console.ReadKey();  
        }
    }
}
