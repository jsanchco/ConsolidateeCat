namespace eCat.Service.Services.ConsolidateeCat
{
    #region Using

    using System;
    using Data.Common;

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
    }
}
