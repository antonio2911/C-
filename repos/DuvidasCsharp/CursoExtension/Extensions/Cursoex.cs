using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoExtension.Extensions
{
  static class Cursoex
  {
    public static string cursoExtension(this DateTime thisObj)
    {
      TimeSpan duration = DateTime.Now.Subtract(thisObj);
      if(duration.TotalHours < 24.00)
      {
        return $"{duration.TotalHours.ToString("F1",CultureInfo.InvariantCulture)}, horas";
      }
      else
      {
        return $"{duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture)}, dias";
      }
    }
  }
}
