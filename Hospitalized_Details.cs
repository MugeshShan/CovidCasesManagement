//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CovidCaseManagement
{
    using System;
    using System.Collections.Generic;
    
    public partial class Hospitalized_Details
    {
        public int Id { get; set; }
        public int Patient_Id { get; set; }
        public string Ward_Name { get; set; }
        public string Ward_Number { get; set; }
        public string Bed_Id { get; set; }
    
        public virtual Patient_Details Patient_Details { get; set; }
    }
}
