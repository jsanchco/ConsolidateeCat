namespace eCat.Repository.Mapped
{
    public class TProyectosProyectoSeccionConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TProyectosProyectoSeccion>
    {
        public TProyectosProyectoSeccionConfiguration()
            : this("dbo")
        {
        }

        public TProyectosProyectoSeccionConfiguration(string schema)
        {
            ToTable("T_Proyectos_ProyectoSeccion", schema);
            HasKey(x => x.IdProyecto);

            Property(x => x.IdProyecto).HasColumnName(@"IdProyecto").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdProyectoSeccion).HasColumnName(@"IdProyectoSeccion").HasColumnType("tinyint").IsRequired();

            // Foreign keys
            HasRequired(a => a.TProyecto).WithOptional(b => b.TProyectosProyectoSeccion).WillCascadeOnDelete(false); // FK_T_Proyectos_ProyectoSeccion_T_Proyectos
            HasRequired(a => a.TProyectoSeccion).WithMany(b => b.TProyectosProyectoSeccions).HasForeignKey(c => c.IdProyectoSeccion).WillCascadeOnDelete(false); // FK_T_Proyectos_ProyectoSeccion_T_ProyectoSeccion
        }
    }
}