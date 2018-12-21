using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SaloonApp.AppointmentDom.Domain.Models
{
    public class Procedures
    {
        [Key]
        public int IdProcedure { get; set; }
        public bool Male { get; set; }
        public bool HairCut { get; set; }
        public bool Dying { get; set; }
        public bool Washing { get; set; }
        public bool Hairstyle { get; set; }
        public bool Blowing { get; set; }
        public bool PartialDying { get; set; }
        public bool Manicure { get; set; }
        public bool Pedicure { get; set; }
        public bool MakeUp { get; set; }

        public Procedures() { }

        public override string ToString()
        {
            var str = "";
            str += Male ? "Male: " : "Woman: ";
            if (HairCut) str += "Haircut, ";
            if (Dying) str += "Dying, ";
            if (Washing) str += "Washing, ";
            if (Hairstyle) str += "Hairstyle, ";
            if (Blowing) str += "Blowing, ";
            if (PartialDying) str += "PartialDying, ";
            if (Manicure) str += "Manicure, ";
            if (Pedicure) str += "Pedicure, ";
            if (MakeUp) str += "MakeUp, ";
            return str;
        }
        public decimal CalculateAmount(ProceduresSettings pc)
        {
            var amount = 0m;

            amount += HairCut ? pc.AmountForHairCut : 0;
            amount += Dying ? pc.AmountForDying : 0;
            amount += Washing ? pc.AmountForWashing : 0;
            amount += Hairstyle ? pc.AmountForHairstyle : 0;
            amount += PartialDying ? pc.AmountForPartialDying : 0;
            amount += Blowing ? pc.AmountForBlowing : 0;
            amount += Manicure ? pc.AmountForManicure : 0;
            amount += Pedicure ? pc.AmountForPedicure : 0;
            amount += MakeUp ? pc.AmountForMakeUp : 0;

            return amount;
        }

        public int CalculateDuration(ProceduresSettings pc)
        {
            var duration = 0;

            duration += HairCut ? pc.DurationForHairCut : 0;
            duration += Dying ? pc.DurationForDying : 0;
            duration += Washing ? pc.DurationForWashing : 0;
            duration += Hairstyle ? pc.DurationForHairstyle : 0;
            duration += PartialDying ? pc.DurationForPartialDying : 0;
            duration += Blowing ? pc.DurationForBlowing : 0;
            duration += Manicure ? pc.DurationForManicure : 0;
            duration += Pedicure ? pc.DurationForPedicure : 0;
            duration += MakeUp ? pc.DurationForMakeUp : 0;

            var dec = duration / 30;
            duration = ++dec * 30;

            // Hard code 30 mins 
            return 30;
        }
    }
}
