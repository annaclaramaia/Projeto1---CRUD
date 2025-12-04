namespace Projeto1.Models
{
    public class PessoaFisica : Pessoa
    {
        public DateTime Nascimento {get; set;}

        public string? Celular {get; set;}

        public string? Cpf {get; set;}

        public string? Rg {get; set;}

        public string? Cnh {get; set;}

        public string? Cnh_Categoria {get; set;}

        public PessoaFisica()
        {

        }

    }

}