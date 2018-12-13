namespace eCat.Repository.Mapped
{
    public class TTiposPublicacionConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TTiposPublicacion>
    {
        public TTiposPublicacionConfiguration()
            : this("dbo")
        {
        }

        public TTiposPublicacionConfiguration(string schema)
        {
            ToTable("T_TiposPublicacion", schema);
            HasKey(x => x.IdTipoPublicacion);

            Property(x => x.IdTipoPublicacion).HasColumnName(@"IdTipoPublicacion").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.TipoPublicacion).HasColumnName(@"TipoPublicacion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(255);
        }
    }
}