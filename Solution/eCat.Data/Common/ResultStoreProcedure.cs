namespace eCat.Data.Common
{
    #region Using

    using System;
    using System.Reflection;

    #endregion

    public class ResultStoreProcedure
    {
        public string Description { get; set; }
        public long? Code { get; set; }
        public Status Status { get; set; }
        public DateTime Date { get; set; }
        public string ClassName { get; set; }
        public string Method { get; set; }
        public string Parameters { get; set; }

        #region Consructor

        public ResultStoreProcedure(MethodBase methodBase, string parameters)
        {
            Date = DateTime.Now;
            Status = Status.Pending;

            ClassName = methodBase.DeclaringType?.ToString();
            Method = methodBase.Name;

            Parameters = parameters;
        }

        #endregion

        public override string ToString()
        {
            return $"{Date:MM/dd/yyyy HH:mm:ss}\t{ClassName}\t{Method}\t{Parameters}\t{Status.ToString()}\t{Code}\t{Description}";
        }

    }

    public enum Status { Pending, Ok, Error, Exception }
}
