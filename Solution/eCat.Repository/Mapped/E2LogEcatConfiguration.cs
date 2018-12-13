namespace eCat.Repository.Mapped
{
    public class E2LogEcatConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.E2LogEcat>
    {
        public E2LogEcatConfiguration()
            : this("dbo")
        {
        }

        public E2LogEcatConfiguration(string schema)
        {
            ToTable("E2_LOG_ECAT", schema);
            HasKey(x => x.IdError);

            Property(x => x.IdError).HasColumnName(@"IdError").HasColumnType("numeric").IsRequired().HasPrecision(25,0).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Formulario).HasColumnName(@"Formulario").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Funcion).HasColumnName(@"Funcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(500);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Usuario).HasColumnName(@"Usuario").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Fecha).HasColumnName(@"Fecha").HasColumnType("datetime").IsRequired();
            Property(x => x.Corregido).HasColumnName(@"Corregido").HasColumnType("bit").IsRequired();
            Property(x => x.FechaCorregido).HasColumnName(@"FechaCorregido").HasColumnType("datetime").IsOptional();
            Property(x => x.UsuarioCorregido).HasColumnName(@"UsuarioCorregido").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Error).HasColumnName(@"Error").HasColumnType("bit").IsRequired();
        }
    }
}