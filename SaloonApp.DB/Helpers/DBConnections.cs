using System;
using System.Collections.Generic;
using System.Text;

namespace SaloonApp.DB
{
    class DBConnections
    {
        public static string GetAzureConnection()
        {
            return
                "Server=tcp:MY-SERVER.database.windows.net,1433; " +
                "Initial Catalog = MY-DB; " +
                "Persist Security Info = False; " +
                "User ID = MY-ADMIN; " +
                "Password = MY-PASS; " +
                "MultipleActiveResultSets = False; " +
                "Encrypt = True; " +
                "TrustServerCertificate = False; " +
                "Connection Timeout = 30; ";
        }

        public static string GetAppHarborConnection()
        {
            return
                "Server=964f8e95-1103-4f33-951c-a86d00b4391b.sqlserver.sequelizer.com;" +
                "Database=db964f8e9511034f33951ca86d00b4391b;" +
                "User ID=iazudehemvwiyvon;" +
                "Password=gwtTmWZbawgDKXCiT7QmtwQ7JSCQMiASHDvviu2Dj3VSdUGNvTHbhvmSNvjBsiwY;" +
                "MultipleActiveResultSets=true";
        }
    }
}
