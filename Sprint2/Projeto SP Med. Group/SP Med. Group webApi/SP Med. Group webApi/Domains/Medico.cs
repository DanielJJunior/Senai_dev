using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace SP_Med._Group_webApi.Domains
{
    public partial class Medico
    {
        public Medico()
        {
            Consulta = new HashSet<Consulta>();
        }

        public int IdMedico { get; set; }
        
        public int? IdUsuario { get; set; }
        
        public int? IdEspecialidade { get; set; }
        
        public int? IdClinica { get; set; }

        [Required(ErrorMessage = "O CRM do Médico é obrigatório!")]
        public string Crm { get; set; }

        [Required(ErrorMessage = "O Nome do Médico é obrigatório!")]
        public string NomeMedico { get; set; }

        public virtual Clinica IdClinicaNavigation { get; set; }
        public virtual Especialidade IdEspecialidadeNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<Consulta> Consulta { get; set; }
    }
}
