using common.Enums;
using System;

namespace domain
{
    public class Cliente
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public ESexo Sexo { get; set; }
        public string Cep { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public EEstado? Estado { get; set; }
        public string Cidade { get; set; }
    }
}
