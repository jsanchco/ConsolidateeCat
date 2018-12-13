namespace eCat.Repository.Mapped
{
    public class TProyectoSeccionConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TProyectoSeccion>
    {
        public TProyectoSeccionConfiguration()
            : this("dbo")
        {
        }

        public TProyectoSeccionConfiguration(string schema)
        {
            ToTable("T_ProyectoSeccion", schema);
            HasKey(x => x.IdProyectoSeccion);

            Property(x => x.IdProyectoSeccion).HasColumnName(@"IdProyectoSeccion").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ProyectoSeccion).HasColumnName(@"ProyectoSeccion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(64);
            Property(x => x.Defecto).HasColumnName(@"Defecto").HasColumnType("bit").IsRequired();
        }
    }
}