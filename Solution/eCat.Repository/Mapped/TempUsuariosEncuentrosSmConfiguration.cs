namespace eCat.Repository.Mapped
{
    public class TempUsuariosEncuentrosSmConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TempUsuariosEncuentrosSm>
    {
        public TempUsuariosEncuentrosSmConfiguration()
            : this("dbo")
        {
        }

        public TempUsuariosEncuentrosSmConfiguration(string schema)
        {
            ToTable("TEMP_UsuariosEncuentrosSM", schema);
            HasKey(x => x.IdUsuario);

            Property(x => x.IdUsuario).HasColumnName(@"IdUsuario").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdRol).HasColumnName(@"IdRol").HasColumnType("tinyint").IsOptional();
            Property(x => x.Consulta).HasColumnName(@"Consulta").HasColumnType("tinyint").IsOptional();
        }
    }
}