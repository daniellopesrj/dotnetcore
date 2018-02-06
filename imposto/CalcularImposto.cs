namespace designpatterns
{
      internal class CalcularImposto
      {

            public double Calcular(double valor, IImposto imposto)
            {
                  
                  return imposto.Calcular(valor);

            }

      }
}