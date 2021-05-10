using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace SP_Med._Group_webApi.Domains
{
    public partial class Clinica
    {
        public Clinica()
        {
            Medicos = new HashSet<Medico>();
        }

        
        public int IdClinica { get; set; }

        [Required(ErrorMessage = "O CNPJ da Clínica é obrigatório!")]
        public string Cnpj { get; set; }

        [Required(ErrorMessage = "O endereço da Clínica é obrigatório!")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "A Razão Social da Clínica é obrigatório!")]
        public string RazaoSocial { get; set; }

        [Required(ErrorMessage = "O Nome Fantasia da Clínica é obrigatório!")]
        public string NomeFantasia { get; set; }

        public virtual ICollection<Medico> Medicos { get; set; }
    }
}