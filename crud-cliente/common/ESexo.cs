using System;
using System.ComponentModel;

namespace common
{
    public enum ESexo
    {
        [Description("Feminino")]
        Feminino = 0,

        [Description("Masculino")]
        Masculino = 1,

        [Description("Não Informado")]
        NaoInformado = 2,
    }
}
