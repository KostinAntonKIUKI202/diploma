﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TREK_Web_Diploma.Models.spares.sparesTransmition;

namespace TREK_Web_Diploma.Models.spares.sparesGroopset
{
    [Table( "Transmition",
            Schema = "sparesGroopset")]
    public class Transmition
    {
        //Модель для таблицы sparesGroopset.Transmition
        [Key]
        public int TransmitionId { get; set; }
        //Подключение модели
        [ForeignKey("Cassette")]
        public int CassetteId { get; set; }
        public Cassette Cassette { get; set; }
        //Подключение модели
        [ForeignKey("Switch")]
        public int SwitchId { get; set; }
        public Switch Switch { get; set; }
        //Подключение модели
        [ForeignKey("Shifter")]
        public int ShifterId { get; set; }
        public Shifter Shifter { get; set; }
        //Подключение модели
        [ForeignKey("FrontGear")]
        public int FrontGearId { get; set; }
        public FrontGear FrontGear { get; set; }

    }
}
