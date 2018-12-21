using Microsoft.EntityFrameworkCore;
using SaloonApp.DB;
using SaloonApp.UDF.Domain;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace SaloonApp.UDF
{
    public class UDFManager
    {
        private readonly AppDbContext _ctx;

        public UDFManager()
        {
            this._ctx = new AppDbContext();
        }

        public async Task<AdminUDF> GetAdminUDFAsync(bool m) => await _ctx.ProcedireUDF.Where(u => u.Male == m).FirstOrDefaultAsync();


        public int CalculateAmount(AdminUDF admUDF, AppointmentProcedureUDF appUDF)
        {
            int amount = 0;

            if (appUDF.AppointmentUDF1Checked && admUDF.AppointmentUDFChek1Enabled)
                amount += admUDF.AppointmentUDFChek1Amount;

            if (appUDF.AppointmentUDF2Checked && admUDF.AppointmentUDFChek2Enabled)
                amount += admUDF.AppointmentUDFChek2Amount;

            if (appUDF.AppointmentUDF3Checked && admUDF.AppointmentUDFChek3Enabled)
                amount += admUDF.AppointmentUDFChek3Amount;

            if (appUDF.AppointmentUDF4Checked && admUDF.AppointmentUDFChek4Enabled)
                amount += admUDF.AppointmentUDFChek4Amount;

            if (appUDF.AppointmentUDF5Checked && admUDF.AppointmentUDFChek5Enabled)
                amount += admUDF.AppointmentUDFChek5Amount;

            if (appUDF.AppointmentUDF6Checked && admUDF.AppointmentUDFChek6Enabled)
                amount += admUDF.AppointmentUDFChek6Amount;

            if (appUDF.AppointmentUDF7Checked && admUDF.AppointmentUDFChek7Enabled)
                amount += admUDF.AppointmentUDFChek7Amount;

            if (appUDF.AppointmentUDF8Checked && admUDF.AppointmentUDFChek8Enabled)
                amount += admUDF.AppointmentUDFChek8Amount;

            if (appUDF.AppointmentUDF9Checked && admUDF.AppointmentUDFChek9Enabled)
                amount += admUDF.AppointmentUDFChek9Amount;

            if (appUDF.AppointmentUDF10Checked && admUDF.AppointmentUDFChek10Enabled)
                amount += admUDF.AppointmentUDFChek10Amount;

            return amount;
        }

        public AdminUDF UpdateAdminUDFHelper( AdminUDF UpdUDF, int id)
        {
            var updUDf = new AdminUDF
            {
                ID = id,
                Male = UpdUDF.Male,

                AppointmentUDFChek1Label = UpdUDF.AppointmentUDFChek1Label,
                AppointmentUDFChek1Amount = UpdUDF.AppointmentUDFChek1Amount ,
                AppointmentUDFChek1Time  = UpdUDF.AppointmentUDFChek1Time,
                AppointmentUDFChek1Enabled = UpdUDF.AppointmentUDFChek1Enabled,

                AppointmentUDFChek2Label = UpdUDF.AppointmentUDFChek2Label,
                AppointmentUDFChek2Amount = UpdUDF.AppointmentUDFChek2Amount,
                AppointmentUDFChek2Time = UpdUDF.AppointmentUDFChek2Time,
                AppointmentUDFChek2Enabled = UpdUDF.AppointmentUDFChek2Enabled,

                AppointmentUDFChek3Label = UpdUDF.AppointmentUDFChek3Label,
                AppointmentUDFChek3Amount = UpdUDF.AppointmentUDFChek3Amount,
                AppointmentUDFChek3Time = UpdUDF.AppointmentUDFChek3Time,
                AppointmentUDFChek3Enabled = UpdUDF.AppointmentUDFChek3Enabled,

                AppointmentUDFChek4Label = UpdUDF.AppointmentUDFChek4Label,
                AppointmentUDFChek4Amount = UpdUDF.AppointmentUDFChek4Amount,
                AppointmentUDFChek4Time = UpdUDF.AppointmentUDFChek4Time,
                AppointmentUDFChek4Enabled = UpdUDF.AppointmentUDFChek4Enabled,

                AppointmentUDFChek5Label = UpdUDF.AppointmentUDFChek5Label,
                AppointmentUDFChek5Amount = UpdUDF.AppointmentUDFChek5Amount,
                AppointmentUDFChek5Time = UpdUDF.AppointmentUDFChek5Time,
                AppointmentUDFChek5Enabled = UpdUDF.AppointmentUDFChek5Enabled,

                AppointmentUDFChek6Label = UpdUDF.AppointmentUDFChek6Label,
                AppointmentUDFChek6Amount = UpdUDF.AppointmentUDFChek6Amount,
                AppointmentUDFChek6Time = UpdUDF.AppointmentUDFChek6Time,
                AppointmentUDFChek6Enabled = UpdUDF.AppointmentUDFChek6Enabled,

                AppointmentUDFChek7Label = UpdUDF.AppointmentUDFChek7Label,
                AppointmentUDFChek7Amount = UpdUDF.AppointmentUDFChek7Amount,
                AppointmentUDFChek7Time = UpdUDF.AppointmentUDFChek7Time,
                AppointmentUDFChek7Enabled = UpdUDF.AppointmentUDFChek7Enabled,

                AppointmentUDFChek8Label = UpdUDF.AppointmentUDFChek8Label,
                AppointmentUDFChek8Amount = UpdUDF.AppointmentUDFChek8Amount,
                AppointmentUDFChek8Time = UpdUDF.AppointmentUDFChek8Time,
                AppointmentUDFChek8Enabled = UpdUDF.AppointmentUDFChek8Enabled,

                AppointmentUDFChek9Label = UpdUDF.AppointmentUDFChek9Label,
                AppointmentUDFChek9Amount = UpdUDF.AppointmentUDFChek9Amount,
                AppointmentUDFChek9Time = UpdUDF.AppointmentUDFChek9Time,
                AppointmentUDFChek9Enabled = UpdUDF.AppointmentUDFChek9Enabled,

                AppointmentUDFChek10Label = UpdUDF.AppointmentUDFChek10Label,
                AppointmentUDFChek10Amount = UpdUDF.AppointmentUDFChek10Amount,
                AppointmentUDFChek10Time = UpdUDF.AppointmentUDFChek10Time,
                AppointmentUDFChek10Enabled = UpdUDF.AppointmentUDFChek10Enabled,
            };

            return updUDf;
        }
    }
}
