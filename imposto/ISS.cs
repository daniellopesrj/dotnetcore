namespace designpatterns
{
      internal class ISS : IImposto
      {
            private const double aliquota = 0.3;
            public double Calcular(double valor)
            {
                  return valor * aliquota;
            }
      }
}