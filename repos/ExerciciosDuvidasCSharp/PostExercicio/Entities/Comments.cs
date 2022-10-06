using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostExercicio.Entities
{
  public class Comments
  {
    public string Text { get; private set; }

    public Comments() { }

    public Comments(string text)
    {
      Text = text;
    }

  }
}
