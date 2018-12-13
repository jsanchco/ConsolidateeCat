namespace eCat.Repository.Mapped
{
    public class DilveEstadoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.DilveEstado>
    {
        public DilveEstadoConfiguration()
            : this("dbo")
        {
        }

        public DilveEstadoConfiguration(string schema)
        {
            ToTable("DILVE_Estados", schema);
            HasKey(x => x.IdEstadoDilve);

            Property(x => x.IdEstadoDilve).HasColumnName(@"IdEstadoDILVE").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CodigoEstado).HasColumnName(@"CodigoEstado").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Estado).HasColumnName(@"Estado").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(30);
            HasMany(t => t.EstadosSaps).WithMany(t => t.DilveEstadoes).Map(m =>
            {
                m.ToTable("DILVE_Estados_Equivalencias", "dbo");
                m.MapLeftKey("IdEstadoDilve");
                m.MapRightKey("IdEstadoSAP");
            });
        }
    }
}