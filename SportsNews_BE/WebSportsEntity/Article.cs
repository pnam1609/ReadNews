//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebSportsEntity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Article
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Article()
        {
            this.Comments = new HashSet<Comment>();
        }
    
        public int id_article { get; set; }
        public string nameArticle { get; set; }
        public string author { get; set; }
        public Nullable<System.DateTime> datetime_article { get; set; }
        public string contentArticle { get; set; }
        public string desciption { get; set; }
        public string img { get; set; }
        public Nullable<int> views { get; set; }
        public Nullable<int> id_category { get; set; }
    
        public virtual category category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
