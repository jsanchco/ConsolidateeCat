namespace eCat.TestConsole.TestData
{
    #region Using

    using Data.Parameters;
    using System;

    #endregion

    public static class TestDataFichasBase
    {
        public static DataFichasBase Test1()
        {
            return new DataFichasBase
            {
                IdInterno = "AR191694",
                Titulo = "Biologia Savia. Los seres vivos unidad",
                IdLineaNegocio = 25, // ARTXT
                Idioma = 13,
                CodLinea_P = "TXT",
                IdTipoMaterialSAP = 6, // ZPGE
                CodigoGrupo = "GR01",
                IdProyecto = 185,
                IdProyectoGestion = 166, // ES_2015_ESOB_05
                IdCampana = 23,
                IdUsoComercial = 3, // RDI
                FechaComerializacion = new DateTime(2017, 12, 26),
                UsuarioCreacion = "PruebasIECISA",
                IdPais = 4, // AR
                TipoMaterialEducativo = 1
            };
        }
    }
}
