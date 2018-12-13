namespace eCat.Repository.Mapped
{
    public class TProyectosGestionConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TProyectosGestion>
    {
        public TProyectosGestionConfiguration()
            : this("dbo")
        {
        }

        public TProyectosGestionConfiguration(string schema)
        {
            ToTable("T_ProyectosGestion", schema);
            HasKey(x => x.IdProyectoGestion);

            Property(x => x.IdProyectoGestion).HasColumnName(@"IdProyectoGestion").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.CodigoProyectoGestion).HasColumnName(@"CodigoProyectoGestion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(30);
            Property(x => x.ProyectoGestion).HasColumnName(@"ProyectoGestion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(255);
        }
    }
}