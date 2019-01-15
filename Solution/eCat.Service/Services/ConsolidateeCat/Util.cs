namespace eCat.Service.Services.ConsolidateeCat
{
    #region Using

    using System;
    using Data.Common;
    using System.IO;
    using System.Reflection;

    #endregion

    public static class Util
    {
        public static void WriteLog(ResultStoreProcedure resultStoreProcedure)
        {
            var fileName = $"{AppDomain.CurrentDomain.BaseDirectory}\\App_Data\\log.txt";
            using (var sw = new System.IO.StreamWriter(fileName, true))
            {
                sw.WriteLine(resultStoreProcedure.ToString());
            }
        }

        public static ResultStoreProcedure GetLog()
        {
            var fileName = $"{AppDomain.CurrentDomain.BaseDirectory}\\App_Data\\log.txt";
            var methodBase = MethodBase.GetCurrentMethod();
            var resultGetLog = new ResultStoreProcedure
            {
                ClassName = methodBase.DeclaringType?.ToString(),
                Method = methodBase.Name,
                Status = Status.Ok,
                Date = DateTime.Now
            };

            try
            {
                File.Copy(fileName, @"c:\Temp\log.txt", true);

                return resultGetLog;
            }
            catch (Exception e)
            {
                resultGetLog.Description = e.Message;

                return resultGetLog;
            }
            finally
            {
                Util.WriteLog(resultGetLog);
            }
        }
    }
}
