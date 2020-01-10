using System;

namespace domain
{
    public class Cliente
    {        
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public short Sexo { get; set; }
        public string Cep { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public int Estado { get; set; }
        public string Cidade { get; set; }
    }
}
