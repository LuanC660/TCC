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
    
    public partial class Pedido
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pedido()
        {
            this.Pedido_Produto = new HashSet<Pedido_Produto>();
        }
    
        public int Id_Pedido { get; set; }
        public string CPF { get; set; }
        public Nullable<System.DateTime> Data_Compra { get; set; }
        public Nullable<int> Qtde_Itens { get; set; }
        public Nullable<decimal> Valor_Total { get; set; }
        public Nullable<System.DateTime> Data_Entrega { get; set; }
        public Nullable<System.TimeSpan> Horario_Entrega { get; set; }
        public Nullable<decimal> Taxa_Entrega { get; set; }
        public string Status_Entrega { get; set; }
        public Nullable<System.DateTime> Data_Pagamento { get; set; }
        public string Forma_Pagamento { get; set; }
        public string Status_Pagamento { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pedido_Produto> Pedido_Produto { get; set; }
    }
}
