﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TREK_Web_Diploma.Models.spares.sparesWheelset
{
    [Table( "Rim",
            Schema = "sparesWheelset")]
    public class Rim
    {
        //Модель для таблицы sparesWheelset.Rim
        [Key]
        public int RimId { get; set; }

        [DataType(DataType.Text)]
        [StringLength(64)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Поле має бути заповненим.")]
        public string RimName { get; set; }

        [DataType(DataType.Text)]
        [StringLength(64)]
        [Required(AllowEmptyStrings = true)]
        public string RimDescription { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Поле має бути заповненим.")]
        public int RimQuantity { get; set; }
    }
}
