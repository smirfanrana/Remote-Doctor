﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Doctor.Models
{
    public class Doctors
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Enter Doctor Name")]
        public string DoctorName { get; set; }

        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        [Display(Name = "Date Of Birth")]
        public DateTime DoctorBirthDate { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string DoctorEmail { get; set; }

        [Display(Name = "Upload Image")]
        public string DoctorImagePath { get; set; }

        [NotMapped]
        [Required]
        public HttpPostedFileBase DoctorImagefile { get; set; }

        [Display(Name = "Degree")]
        [Required(AllowEmptyStrings = false)]
        [StringLength(200)]
        public string DoctorDegree { get; set; }

        [Required]
        [Display(Name = "Registration No")]
        public string RegNo { get; set; }

        [Required(AllowEmptyStrings = false)]
        [StringLength(200)]
        [Display(Name = "Details")]
        public string DoctorDetails { get; set; }

        [Required(AllowEmptyStrings = false)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [StringLength(200)]
        [MinLength(6, ErrorMessage = "Password minimum 6 character required")]
        public string DoctorPassword { get; set; }

        [Required(AllowEmptyStrings = false)]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [MinLength(6, ErrorMessage = "Password minimum 6 character required")]
        [Compare("DoctorPassword", ErrorMessage = "Password Doesn't Match")]
        [NotMapped]
        public string DoctorConfirmPassword { get; set; }

        public bool IsEmailVarified { get; set; }

        public Guid ActivationCode { get; set; }

        public Department Department { get; set; }
        [Display(Name = "Department")]
        [Required] public int DepartmentId { get; set; }
    }
}