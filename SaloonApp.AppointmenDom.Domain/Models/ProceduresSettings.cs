using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SaloonApp.AppointmentDom.Domain.Models
{
    public class ProceduresSettings
    {
        [Key]
        public int IdProceduresSettings { get; set; }
        public bool Male { get; set; }
        public int AmountForHairCut { get; set; }
        public int AmountForDying { get; set; }
        public int AmountForWashing { get; set; }
        public int AmountForHairstyle { get; set; }
        public int AmountForBlowing { get; set; }
        public int AmountForPartialDying { get; set; }
        public int AmountForManicure { get; set; }
        public int AmountForPedicure { get; set; }
        public int AmountForMakeUp { get; set; }

        public int DurationForHairCut { get; set; }
        public int DurationForDying { get; set; }
        public int DurationForWashing { get; set; }
        public int DurationForHairstyle { get; set; }
        public int DurationForBlowing { get; set; }
        public int DurationForPartialDying { get; set; }
        public int DurationForManicure { get; set; }
        public int DurationForPedicure { get; set; }
        public int DurationForMakeUp { get; set; }

        public ProceduresSettings()
        {

        }
    }
}
