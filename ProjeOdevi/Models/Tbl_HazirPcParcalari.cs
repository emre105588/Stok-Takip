//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjeOdevi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Tbl_HazirPcParcalari
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_HazirPcParcalari()
        {
            this.Tbl_Zimmet = new HashSet<Tbl_Zimmet>();
        }

        public int HazirPcParcalariId { get; set; }
        [Required(ErrorMessage = "�r�n Ad� Bo� b�rak�lamaz")]
        public string ParcaAdi { get; set; }
        [Required(ErrorMessage = "�r�n Ad� Bo� b�rak�lamaz")]
        public Nullable<int> UrunID { get; set; }
        public Nullable<int> KategoriID { get; set; }
        public Nullable<int> BarkotNo { get; set; }

        public virtual Tbl_Kategori Tbl_Kategori { get; set; }
        public virtual Tbl_Urun Tbl_Urun { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Zimmet> Tbl_Zimmet { get; set; }
    }
}
