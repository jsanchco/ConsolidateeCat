namespace eCat.Repository.Mapped
{
    public class TProyectoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TProyecto>
    {
        public TProyectoConfiguration()
            : this("dbo")
        {
        }

        public TProyectoConfiguration(string schema)
        {
            ToTable("T_Proyectos", schema);
            HasKey(x => x.IdProyecto);

            Property(x => x.IdProyecto).HasColumnName(@"IdProyecto").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Proyecto).HasColumnName(@"Proyecto").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(255);
        }
    }
}