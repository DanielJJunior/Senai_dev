using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace SP_Med._Group_webApi.Domains
{
    public partial class Situacao
    {
        public Situacao()
        {
            Consulta = new HashSet<Consulta>();
        }

        public int IdSituacao { get; set; }

        [Required(ErrorMessage = "O Estado da Situação é obrigatório!")]
        public string Estado { get; set; }

        public virtual ICollection<Consulta> Consulta { get; set; }
    }
}
