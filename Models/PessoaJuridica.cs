namespace Projeto1.Models
{
    public class PessoaJuridica : Pessoa
    {

        public string? Razao_Social {get; set;}

        public string? Nome_Fantasia {get; set;}
        
        public string? Cnpj {get; set;}
        
        public string? Inscricao_Estadual {get; set;}
        
        public string? Inscricao_Municipal {get; set;}
        
        public string? Telefone {get; set;}

        public PessoaJuridica()
        {

        }

    }

}