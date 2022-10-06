using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoExtension.Extensions
{
  static class StringExtensionTeste
  {
    public static string Cut(this string thisObj, int count)
    {
      if(thisObj.Length <= count)
      {
        return $"O valor do corte e maior que o tamanho da string";
      }
      else
      {
        return $"{thisObj.Substring(0,count)} ...";
      }
    }
  }
}
