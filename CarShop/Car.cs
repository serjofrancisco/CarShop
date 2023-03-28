namespace CarShop
{
    public class Car
    {
        public int Id { get; set; }
        public string NumeroDoChasse { get; set; }

        public string NumeroDoMotor { get; set; }

        public double CustoDeProducao { get; set; }

        public double Imposto { get; set; }

        public double PrecoDeVenda
        {
            get
            {
                double custo = CustoDeProducao + Imposto;
                double valorDeVenda = (custo * 100) / 75;
                return valorDeVenda;
            }
        }
    }
    }