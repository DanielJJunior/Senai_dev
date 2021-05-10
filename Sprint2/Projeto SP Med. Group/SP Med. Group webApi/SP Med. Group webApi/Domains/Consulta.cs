using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace SP_Med._Group_webApi.Domains
{
    public partial class Consulta
    {
        public int IdConsulta { get; set; }
        
        public int? IdPaciente { get; set; }
        
        public int? IdMedico { get; set; }
        
        public int? IdSituacao { get; set; }

        [Required(ErrorMessage = "A Data da Consulta é obrigatório!")]
        [DataType(DataType.Date)]
        public DateTime? DataConsulta { get; set; }

        public virtual Medico IdMedicoNavigation { get; set; }
        public virtual Paciente IdPacienteNavigation { get; set; }
        public virtual Situacao IdSituacaoNavigation { get; set; }
    }
}
