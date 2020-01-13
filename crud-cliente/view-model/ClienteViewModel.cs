using common.CustomAttributes;
using common.Enums;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace view_model
{
    public class ClienteViewModel
    {
        public Guid Id { get; set; }

        [RequiredValidation(FieldType: typeof(string), ErrorMessage = "O campo Nome é obrigatório")]
        public string Nome { get; set; }

        [RequiredValidation(FieldType: typeof(DateTime), ErrorMessage = "O campo Data de Nascimento é obrigatório")]
        [DisplayName("Data de Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataNascimento { get; set; }

        [RequiredValidation(FieldType: typeof(int), ErrorMessage = "O campo Sexo é obrigatório")]
        public ESexo Sexo { get; set; }
        public string Cep { get; set; }

        [DisplayName("Endereço")]
        public string Endereco { get; set; }

        [DisplayName("Número")]
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }

        [DisplayName("UF")]
        public EEstado? Estado { get; set; }
        public string Cidade { get; set; }

        public string DataNascimentoFormatada
        {
            get
            {
                return DataNascimento.ToString("dd/MM/yyyy");
            }
        }
    }    
}
