//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MigraineData
{
    using System;
    using System.Collections.Generic;
    
    public partial class migraine
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public migraine()
        {
            this.migraine_drinks = new HashSet<migraine_drinks>();
            this.migraine_foods = new HashSet<migraine_foods>();
            this.migraine_location = new HashSet<migraine_location>();
            this.migraine_meds = new HashSet<migraine_meds>();
            this.migraine_physical_activities = new HashSet<migraine_physical_activities>();
        }
    
        public int id { get; set; }
        public System.DateTime date { get; set; }
        public int pain_level { get; set; }
        public string audio_file { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<migraine_drinks> migraine_drinks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<migraine_foods> migraine_foods { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<migraine_location> migraine_location { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<migraine_meds> migraine_meds { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<migraine_physical_activities> migraine_physical_activities { get; set; }
    }
}
