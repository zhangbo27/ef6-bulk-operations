//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tanneryd.BulkOperations.EF6.NET47.ModelFirst.Tests.Models.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Level1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Level1()
        {
            this.Level2 = new Level2();
        }
    
        public int Id { get; set; }
        public string Level1Name { get; set; }
    
        public Level2 Level2 { get; set; }
    }
}
