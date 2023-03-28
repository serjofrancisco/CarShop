using System;
namespace CarShop
{
public class Flex : Car
{
    public int NumeroDePortas { get; set; }
    public int Cilindradas { get; set; }

    public Flex(double custoDeProducao)
    {
        
        Imposto = ((20 / 100) * custoDeProducao);
      
    }
    } 
}
