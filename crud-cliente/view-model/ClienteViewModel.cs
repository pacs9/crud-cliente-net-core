using common.CustomAttributes;
using common.Enums;
using System;

namespace view_model
{
    public class ClienteViewModel
    {
        public Guid Id { get; set; }

        [RequiredValidation(FieldType: typeof(string), ErrorMessage = "O campo Nome é obrigatório")]
        public string Nome { get; set; }

        [RequiredValidation(FieldType: typeof(DateTime), ErrorMessage = "O campo Data de Nascimento é obrigatório")]
        public DateTime DataNascimento { get; set; }

        [RequiredValidation(FieldType: typeof(int), ErrorMessage = "O campo Sexo é obrigatório")]
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
