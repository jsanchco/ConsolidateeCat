namespace eCat.Repository.Mapped
{
    public class TTiposConsultaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TTiposConsulta>
    {
        public TTiposConsultaConfiguration()
            : this("dbo")
        {
        }

        public TTiposConsultaConfiguration(string schema)
        {
            ToTable("T_TiposConsultas", schema);
            HasKey(x => x.IdTipoConsulta);

            Property(x => x.IdTipoConsulta).HasColumnName(@"IdTipoConsulta").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.TipoConsulta).HasColumnName(@"TipoConsulta").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
        }
    }
}