//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Quitanda.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Produto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Produto()
        {
            this.Pedido_Produto = new HashSet<Pedido_Produto>();
        }
    
        public int Id_Produto { get; set; }

        [Display (Name="Nome")]
        [Required(ErrorMessage= "Informe o Nome do produto")]
        public string Nome_Produto { get; set; }

        [Display(Name = "Valor")]
        [Required(ErrorMessage = "Informe o Valor do Produto")]
        public decimal Valor_Produto { get; set; }

        [Display(Name = "Tamanho")]
        [Required(ErrorMessage = "Informe o tamanho da marmita")]
        public string Tamanho_Marmita { get; set; }

        [Display(Name = "Descrição")]
        public string Descrição_Produto { get; set; }
        public string Categoria { get; set; }

        [Display(Name = "Status")]
        public string Status_Produto { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pedido_Produto> Pedido_Produto { get; set; }
    }
}
