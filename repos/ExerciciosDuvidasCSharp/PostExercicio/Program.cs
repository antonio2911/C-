using PostExercicio.Entities;
using System;

namespace PostExercicio
{
  class Program
  {
    static void Main(string[] args)
    {
      Comments commentsOne = new Comments("How good");

      Comments commentsTwo = new Comments("Hooow good 2");
      
      Post primaryPost = new Post(DateTime.Now,"Titulo","conteudo", 3);

      primaryPost.AddComments(commentsOne);
      primaryPost.AddComments(commentsTwo);


    }
  }
}
