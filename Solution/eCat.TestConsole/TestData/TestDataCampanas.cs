namespace eCat.TestConsole.TestData
{
    #region Using

    using Data.Parameters;
    using System;

    #endregion

    public static class TestDataCampanas
    {
        public static DataInsertTCampana Test1()
        {
            return new DataInsertTCampana
            {
                Descripcion = "2022",
                Desde = new DateTime(2021, 1, 1),
                Hasta = new DateTime(2021, 12, 31)
            };
        }
    }
}
