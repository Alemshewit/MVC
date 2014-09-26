using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Patients_Donors.Models
{
    [MetadataType(typeof(PatientForm))]
    public class PatientForm
    {

    }

    public class PatientFormValidation
    {
        [Required]  
        public string PatientName { get; set; }
        [Required]
        public string PatientBloodGroup { get; set; }
        [Required]
        public string PatientDisease { get; set; }
    }  
}