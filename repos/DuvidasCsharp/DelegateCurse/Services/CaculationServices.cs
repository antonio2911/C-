namespace DelegateCurse.Services
{
  delegate double OperacaoNumericaBinaria(double n1, double n2);
  class CaculationServices
  {
    public static double Max(double x, double y)
    {
      return (x > y)  ? x : y; 
    }

    public static double Sum(double x, double y)
    {
      return x + y;
    }

    public static double Square(double x)
    {
      return x * x;
    }

  }
}
