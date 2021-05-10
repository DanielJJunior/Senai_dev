using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace SP_Med._Group_webApi.Domains
{
    public partial class Paciente
    {
        public Paciente()
        {
            Consulta = new HashSet<Consulta>();
        }

        public int IdPaciente { get; set; }
        
        public int? IdUsuario { get; set; }

        [Required(ErrorMessage = "O Nome do Paciente é obrigatório!")]
        public string NomePaciente { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DataNascimento { get; set; }
        
        public string Telefone { get; set; }

        [Required(ErrorMessage = "O RG do Paciente é obrigatório!")]
        public string Rg { get; set; }

        [Required(ErrorMessage = "O CPF do Paciente é obrigatório!")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "O Endereço do Paciente é obrigatório!")]
        public string Endereço { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<Consulta> Consulta { get; set; }
    }
}
