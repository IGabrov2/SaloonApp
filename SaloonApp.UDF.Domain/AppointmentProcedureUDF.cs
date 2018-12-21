using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SaloonApp.UDF.Domain
{
    public class AppointmentProcedureUDF
    {
        public AppointmentProcedureUDF()
        {

        }

        [Key]
        public int ID { get; set; }

        public bool Male { get; set; }

        //public int AppointmentUDF1Amount { get; set; }
        //public int AppointmentUDF1Time { get; set; }
        public bool AppointmentUDF1Checked { get; set; }

        public bool AppointmentUDF2Checked { get; set; }

        public bool AppointmentUDF3Checked { get; set; }

        public bool AppointmentUDF4Checked { get; set; }

        public bool AppointmentUDF5Checked { get; set; }

        public bool AppointmentUDF6Checked { get; set; }

        public bool AppointmentUDF7Checked { get; set; }

        public bool AppointmentUDF8Checked { get; set; }

        public bool AppointmentUDF9Checked { get; set; }

        public bool AppointmentUDF10Checked { get; set; }

        public string ToString(AdminUDF udf)
        {
            string s = udf.Male == true ? "Male: ":"Female: ";

            if (udf.AppointmentUDFChek1Enabled && AppointmentUDF1Checked)
                s += udf.AppointmentUDFChek1Label + ", ";
            if (udf.AppointmentUDFChek2Enabled && AppointmentUDF2Checked)
                s += udf.AppointmentUDFChek2Label + ", ";
            if (udf.AppointmentUDFChek3Enabled && AppointmentUDF3Checked)
                s += udf.AppointmentUDFChek3Label + ", ";
            if (udf.AppointmentUDFChek4Enabled && AppointmentUDF4Checked)
                s += udf.AppointmentUDFChek4Label + ", ";
            if (udf.AppointmentUDFChek5Enabled && AppointmentUDF5Checked)
                s += udf.AppointmentUDFChek5Label + ", ";
            if (udf.AppointmentUDFChek6Enabled && AppointmentUDF6Checked)
                s += udf.AppointmentUDFChek6Label + ", ";
            if (udf.AppointmentUDFChek7Enabled && AppointmentUDF7Checked)
                s += udf.AppointmentUDFChek7Label + ", ";
            if (udf.AppointmentUDFChek8Enabled && AppointmentUDF8Checked)
                s += udf.AppointmentUDFChek8Label + ", ";
            if (udf.AppointmentUDFChek9Enabled && AppointmentUDF9Checked)
                s += udf.AppointmentUDFChek9Label + ", ";
            if (udf.AppointmentUDFChek10Enabled && AppointmentUDF10Checked)
                s += udf.AppointmentUDFChek10Label + ", ";
            return s;
        }
    }
}
