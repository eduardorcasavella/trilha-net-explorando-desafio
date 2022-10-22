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
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // FEITO
            int numHospedes = 0;
            numHospedes = hospedes.Count();
            if(Suite.Capacidade >= numHospedes)
            {
                Hospedes = hospedes;
            }            
            else
            {
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                // FEITO
                throw new Exception("O númeo de hospedes não pode ser maior que a capacidade");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // FEITO
            int quantidadeHospedes = Hospedes.Count();
            if(quantidadeHospedes < 1)
            {
                return 0;
            }
            else{
                return quantidadeHospedes;
            }            
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // FEITO
            decimal valor = 0;
            valor = DiasReservados * Suite.ValorDiaria;

            
            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // FEITO
            if(DiasReservados >= 10)
            {
                valor = valor * 0.90M; //descontando 10%
            }
            
            return valor;
        }
    }
}