using System;
using System.ComponentModel.DataAnnotations;

namespace SaloonApp.UDF.Domain
{
    public class AdminUDF
    {
        [Key]
        public int ID { get; set; }
        public bool Male { get; set; }

        //UDF1
        public string AppointmentUDFChek1Label { get; set; }
        public int AppointmentUDFChek1Amount { get; set; }
        public int AppointmentUDFChek1Time { get; set; }
        public bool AppointmentUDFChek1Enabled { get; set; }

        //UDF2
        public string AppointmentUDFChek2Label { get; set; }
        public int AppointmentUDFChek2Amount { get; set; }
        public int AppointmentUDFChek2Time { get; set; }
        public bool AppointmentUDFChek2Enabled { get; set; }

        //UDF3
        public string AppointmentUDFChek3Label { get; set; }
        public int AppointmentUDFChek3Amount { get; set; }
        public int AppointmentUDFChek3Time { get; set; }
        public bool AppointmentUDFChek3Enabled { get; set; }

        //UDF4
        public string AppointmentUDFChek4Label { get; set; }
        public int AppointmentUDFChek4Amount { get; set; }
        public int AppointmentUDFChek4Time { get; set; }
        public bool AppointmentUDFChek4Enabled { get; set; }

        //UDF5
        public string AppointmentUDFChek5Label { get; set; }
        public int AppointmentUDFChek5Amount { get; set; }
        public int AppointmentUDFChek5Time { get; set; }
        public bool AppointmentUDFChek5Enabled { get; set; }

        //UDF6
        public string AppointmentUDFChek6Label { get; set; }
        public int AppointmentUDFChek6Amount { get; set; }
        public int AppointmentUDFChek6Time { get; set; }
        public bool AppointmentUDFChek6Enabled { get; set; }

        //UDF7
        public string AppointmentUDFChek7Label { get; set; }
        public int AppointmentUDFChek7Amount { get; set; }
        public int AppointmentUDFChek7Time { get; set; }
        public bool AppointmentUDFChek7Enabled { get; set; }

        //UDF8
        public string AppointmentUDFChek8Label { get; set; }
        public int AppointmentUDFChek8Amount { get; set; }
        public int AppointmentUDFChek8Time { get; set; }
        public bool AppointmentUDFChek8Enabled { get; set; }

        //UDF9
        public string AppointmentUDFChek9Label { get; set; }
        public int AppointmentUDFChek9Amount { get; set; }
        public int AppointmentUDFChek9Time { get; set; }
        public bool AppointmentUDFChek9Enabled { get; set; }

        //UDF10
        public string AppointmentUDFChek10Label { get; set; }
        public int AppointmentUDFChek10Amount { get; set; }
        public int AppointmentUDFChek10Time { get; set; }
        public bool AppointmentUDFChek10Enabled { get; set; }

    }
}