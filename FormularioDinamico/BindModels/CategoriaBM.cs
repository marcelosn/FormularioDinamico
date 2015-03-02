﻿
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace FormularioDinamico.BindModels
{
    public class CategoriaBM
    {
        public int Id { get; set; }
        
        [StringLength(60, ErrorMessage="Descrição não deve ultrapassar {0} caracteres")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        
        [StringLength(60, ErrorMessage = "Slug não deve ultrapassar {0} caracteres")]
        [Display(Name = "Slug")]
        public string Slug { get; set; }
        public virtual ICollection<SubCategoriaBM> SubCategorias { get; set; }
    }
}