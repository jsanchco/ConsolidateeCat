namespace eCat.Service.Services.ConsolidateeCat
{
    #region Using

    using System.Data.SqlClient;
    using Data.Parameters;
    using System;
    using System.Reflection;
    using Data.Common;
    using System.Data;
    using System.Collections.Generic;

    #endregion

    public static class ServiceAdd
    {
        public static List<ResultStoreProcedure> InsertFichaBase(string connectionString, DataFichasBase dataFichasBase)
        {
            var listResultStoreProcedure = new List<ResultStoreProcedure>();
            var resultStoreProcedure = new ResultStoreProcedure(MethodBase.GetCurrentMethod(), dataFichasBase.ToUri());
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
                        sqlCommand.CommandText = "pa_InsertFichasBase";

                        sqlCommand.Parameters.Add(new SqlParameter("@sIdInterno", dataFichasBase.IdInterno));
                        sqlCommand.Parameters.Add(new SqlParameter("@nsTitulo", dataFichasBase.Titulo));
                        sqlCommand.Parameters.Add(new SqlParameter("@nIdLineaNegocio", dataFichasBase.IdLineaNegocio));
                        sqlCommand.Parameters.Add(new SqlParameter("@nCoeditorial", dataFichasBase.Coeditorial ?? (object)DBNull.Value));
                        sqlCommand.Parameters.Add(new SqlParameter("@nIdioma", dataFichasBase.Idioma));
                        sqlCommand.Parameters.Add(new SqlParameter("@sCodLinea_P", dataFichasBase.CodLinea_P));
                        sqlCommand.Parameters.Add(new SqlParameter("@nIdTipoMaterialSAP", dataFichasBase.IdTipoMaterialSAP));
                        sqlCommand.Parameters.Add(new SqlParameter("@sCodigoGrupo", dataFichasBase.CodigoGrupo));
                        sqlCommand.Parameters.Add(new SqlParameter("@nIdProyecto", dataFichasBase.IdProyecto ?? (object)DBNull.Value));
                        sqlCommand.Parameters.Add(new SqlParameter("@nIdProyectoAdicional", dataFichasBase.IdProyectoAdicional ?? (object)DBNull.Value));
                        sqlCommand.Parameters.Add(new SqlParameter("@nIdProyectoGestion", dataFichasBase.IdProyectoGestion ?? (object)DBNull.Value));
                        sqlCommand.Parameters.Add(new SqlParameter("@nIdCampaña", dataFichasBase.IdCampana));
                        sqlCommand.Parameters.Add(new SqlParameter("@nIdUsoComercial", dataFichasBase.IdUsoComercial ?? (object)DBNull.Value));
                        sqlCommand.Parameters.Add(new SqlParameter("@dtFechaComerializacion", dataFichasBase.FechaComerializacion));
                        sqlCommand.Parameters.Add(new SqlParameter("@dtNecesidadInfo", dataFichasBase.NecesidadInfo ?? string.Empty));
                        sqlCommand.Parameters.Add(new SqlParameter("@nIdColeccion", dataFichasBase.IdColeccion ?? (object)DBNull.Value));
                        sqlCommand.Parameters.Add(new SqlParameter("@nNumColeccion", dataFichasBase.NumColeccion));
                        sqlCommand.Parameters.Add(new SqlParameter("@nIdSerie", dataFichasBase.IdSerie ?? (object)DBNull.Value));
                        sqlCommand.Parameters.Add(new SqlParameter("@nNumSerie", dataFichasBase.NumSerie));
                        sqlCommand.Parameters.Add(new SqlParameter("@nZGeografica", dataFichasBase.ZGeografica ?? (object)DBNull.Value));
                        sqlCommand.Parameters.Add(new SqlParameter("@nsUsuarioCreacion", dataFichasBase.UsuarioCreacion));
                        sqlCommand.Parameters.Add(new SqlParameter("@sIdInternoOrigen", dataFichasBase.IdInternoOrigen ?? string.Empty));
                        sqlCommand.Parameters.Add(new SqlParameter("@sIdInternoOrigenSAP", dataFichasBase.IdInternoOrigenSAP ?? string.Empty));
                        sqlCommand.Parameters.Add(new SqlParameter("@iIdPais", dataFichasBase.IdPais));
                        sqlCommand.Parameters.Add(new SqlParameter("@nPorcentajeCoedicion", dataFichasBase.PorcentajeCoedicion ?? (object)DBNull.Value));
                        sqlCommand.Parameters.Add(new SqlParameter("@nTipoMaterialEducativo", dataFichasBase.TipoMaterialEducativo ?? (object)DBNull.Value));

                        var returnParam = new SqlParameter
                        {
                            ParameterName = "@return",
                            Direction = ParameterDirection.ReturnValue
                        };
                        sqlCommand.Parameters.Add(returnParam);

                        sqlCommand.ExecuteNonQuery();
                        resultStoreProcedure.Code = Convert.ToInt64(returnParam.Value);

                        resultStoreProcedure.Status = resultStoreProcedure.Code == 1 ? Status.Ok : Status.Error;
                        resultStoreProcedure.Description = GetDescriptionError(resultStoreProcedure.Code);
                        Util.WriteLog(resultStoreProcedure);

                        if (resultStoreProcedure.Status == Status.Ok)
                        {
                            resultStoreProcedure = InsertFichaRamasClasificacion(connectionString,
                                new DataFichaRamasClasificacion
                                {
                                    IdInterno = dataFichasBase.IdInterno,
                                    IdClasificacion = dataFichasBase.JerarquiaProducto,
                                    UsuarioCreacion = dataFichasBase.UsuarioCreacion
                                });

                            listResultStoreProcedure.Add(resultStoreProcedure);
                            Util.WriteLog(resultStoreProcedure);
                        }

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

        public static ResultStoreProcedure InsertFichaRamasClasificacion(string connectionString, DataFichaRamasClasificacion dataFichaRamasClasificacion)
        {
            var resultStoreProcedure = new ResultStoreProcedure(MethodBase.GetCurrentMethod(), dataFichaRamasClasificacion.ToUri());

            try
            {
                using (var sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    using (var sqlCommand = new SqlCommand())
                    {
                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.CommandText = "pa_InsertE2_RAMASCLASIF_FICHAS";

                        sqlCommand.Parameters.Add(new SqlParameter("@sIdInterno", dataFichaRamasClasificacion.IdInterno));
                        sqlCommand.Parameters.Add(new SqlParameter("@sIdClasificacion", dataFichaRamasClasificacion.IdClasificacion));
                        sqlCommand.Parameters.Add(new SqlParameter("@sUsuario", dataFichaRamasClasificacion.UsuarioCreacion));

                        var returnParam = new SqlParameter
                        {
                            ParameterName = "@return",
                            Direction = ParameterDirection.ReturnValue
                        };
                        sqlCommand.Parameters.Add(returnParam);

                        sqlCommand.ExecuteNonQuery();
                        resultStoreProcedure.Code = Convert.ToInt64(returnParam.Value);

                        resultStoreProcedure.Status = resultStoreProcedure.Code == 1 ? Status.Ok : Status.Error;
                        resultStoreProcedure.Description = GetDescriptionError(resultStoreProcedure.Code);

                        return resultStoreProcedure;
                    }
                }
            }
            catch (Exception e)
            {
                resultStoreProcedure.Status = Status.Exception;
                resultStoreProcedure.Description = e.Message;

                return resultStoreProcedure;
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
                case -100:
                case -101:
                case -102:
                case -103:
                case -104:
                case -105:
                case -106:
                case -107:
                    return "Material de Baja";
                case -500:
                    return "Error en Auditoria";

                default:
                    return string.Empty;
            }
        }
    }
}
