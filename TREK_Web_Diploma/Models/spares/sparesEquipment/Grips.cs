﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace practice_TrekCompany.Models.spares.sparesEquipment
{
    [Table( "Grips",
            Schema = "sparesEquipment")]
    public class Grips
    {
        //Модель для таблицы sparesEquipment.Brake
        [Key]
        public int GripsId { get; set; }

        [DataType(DataType.Text)]
        [StringLength(40)]
        [Required(ErrorMessage = "Поле має бути заповненим.")]
        public string GripsName { get; set; }

        [DataType(DataType.Text)]
        [StringLength(4)]
        [Required(ErrorMessage = "Поле має бути заповненим.")]
        public int GripsQuantity { get; set; }
    }
}
