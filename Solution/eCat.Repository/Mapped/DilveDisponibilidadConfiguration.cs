namespace eCat.Repository.Mapped
{
    public class DilveDisponibilidadConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.DilveDisponibilidad>
    {
        public DilveDisponibilidadConfiguration()
            : this("dbo")
        {
        }

        public DilveDisponibilidadConfiguration(string schema)
        {
            ToTable("DILVE_Disponibilidad", schema);
            HasKey(x => x.IdDisponibilidadDilve);

            Property(x => x.IdDisponibilidadDilve).HasColumnName(@"IdDisponibilidadDILVE").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CodigoDisponibilidadDilve).HasColumnName(@"CodigoDisponibilidadDILVE").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(128);
            HasMany(t => t.EstadosSaps).WithMany(t => t.DilveDisponibilidads).Map(m =>
            {
                m.ToTable("DILVE_Disponibilidad_Equivalencias", "dbo");
                m.MapLeftKey("IdDisponibilidadDILVE");
                m.MapRightKey("IdEstadoSAP");
            });
        }
    }
}