namespace designpatterns
{
      internal class ICMS : IImposto
      {
            private const double aliquota = 0.7;
            public double Calcular(double valor)
            {
                  return valor * aliquota;
            }            
      }
}