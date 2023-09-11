﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace practice_TrekCompany.Models.spares.sparesGroopset
{
    [Table( "Carriage",
            Schema = "sparesGroopset")]
    public class Carriage
    {
        //Модель для таблицы sparesGroopset.Carriage
        [Key]
        public int CarriageId { get; set; }

        [DataType(DataType.Text)]
        [StringLength(30)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Поле має бути заповненим.")]
        public string CarriageName { get; set; }

        [DataType(DataType.Text)]
        [StringLength(4)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Поле має бути заповненим.")]
        public int CarriageQuantity { get; set; }
    }
}