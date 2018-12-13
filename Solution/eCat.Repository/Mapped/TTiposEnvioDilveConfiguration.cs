namespace eCat.Repository.Mapped
{
    public class TTiposEnvioDilveConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TTiposEnvioDilve>
    {
        public TTiposEnvioDilveConfiguration()
            : this("dbo")
        {
        }

        public TTiposEnvioDilveConfiguration(string schema)
        {
            ToTable("T_TiposEnvio_DILVE", schema);
            HasKey(x => x.IdTipoEnvioDilve);

            Property(x => x.IdTipoEnvioDilve).HasColumnName(@"IdTipoEnvioDILVE").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
        }
    }
}