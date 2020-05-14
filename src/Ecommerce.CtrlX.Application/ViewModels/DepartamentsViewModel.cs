using System;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.CtrlX.Application.ViewModels
{
    public class DepartamentsViewModel
    {
        [Key]
        public int DepartamentsId { get; set; }
        public string Name { get; set; }
        public DateTime? DataCadastro { get; set; }
        public bool Ativo { get; set; }
    }
}
