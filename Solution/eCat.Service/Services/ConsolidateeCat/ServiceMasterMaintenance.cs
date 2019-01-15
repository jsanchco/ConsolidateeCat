namespace eCat.Service.Services.ConsolidateeCat
{
    #region Using

    using System.Collections.Generic;
    using Data.Common;
    using Data.Parameters;
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Reflection;

    #endregion

    public static class ServiceMasterMaintenance
    {
        public static List<ResultStoreProcedure> InsertCampana(string connectionString, DataInsertTCampana dataInsertTCampana)
        {
            var listResultStoreProcedure = new List<ResultStoreProcedure>();
            var resultStoreProcedure = new ResultStoreProcedure(MethodBase.GetCurrentMethod(), dataInsertTCampana.ToUri());
            listResultStoreProcedure.Add(resultStoreProcedure);

            try
            {
                using (var sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    using (var sqlCommand = new SqlCommand())
                    {
                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.CommandText = "pa_Insert_T_Campañas";

                        sqlCommand.Parameters.Add(new SqlParameter("@nsDescripcion", dataInsertTCampana.Descripcion));
                        sqlCommand.Parameters.Add(new SqlParameter("@dtDesde", dataInsertTCampana.Desde));
                        sqlCommand.Parameters.Add(new SqlParameter("@dtHasta", dataInsertTCampana.Hasta));

                        var returnParam = new SqlParameter
                        {
                            ParameterName = "@return",
                            Direction = ParameterDirection.ReturnValue
                        };
                        sqlCommand.Parameters.Add(returnParam);

                        sqlCommand.ExecuteNonQuery();
                        resultStoreProcedure.Code = Convert.ToInt64(returnParam.Value);

                        resultStoreProcedure.Status = resultStoreProcedure.Code > 0 ? Status.Ok : Status.Error;
                        resultStoreProcedure.Description = GetDescriptionError(resultStoreProcedure.Code);
                        Util.WriteLog(resultStoreProcedure);

                        return listResultStoreProcedure;
                    }
                }
            }
            catch (Exception e)
            {
                resultStoreProcedure.Status = Status.Exception;
                resultStoreProcedure.Description = e.Message;

                return listResultStoreProcedure;
            }
        }

        private static string GetDescriptionError(long? code)
        {
            if (code == null)
                return "No return PA";
            switch (code)
            {
                case -2:
                    return "Existe este Material";

                default:
                    return string.Empty;
            }
        }
    }
}
