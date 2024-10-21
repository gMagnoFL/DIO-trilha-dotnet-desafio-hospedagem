namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // compara a quantidade de hóspedes (método) com a capacidade da suíte (atributo Suite)
            if (hospedes.Count() <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                Console.WriteLine("Número de hóspedes excede capacidade do quarto");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            try
            {
                return Hospedes.Count();
            }
            catch
            {
                return 0;
            }
        }

        public decimal CalcularValorDiaria(){
            decimal valor = 0;
                if (ObterQuantidadeHospedes() > 0){
                    valor = Suite.ValorDiaria * DiasReservados;
                    if (DiasReservados >= 10){
                        valor = valor-(valor*10/100);
                }
            }
            return valor;
        }
    }
}