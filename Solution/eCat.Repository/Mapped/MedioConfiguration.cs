namespace eCat.Repository.Mapped
{
    public class MedioConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.Medio>
    {
        public MedioConfiguration()
            : this("dbo")
        {
        }

        public MedioConfiguration(string schema)
        {
            ToTable("Medios", schema);
            HasKey(x => x.IdMedio);

            Property(x => x.IdMedio).HasColumnName(@"IDMedio").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdTipoMedio).HasColumnName(@"IDTipoMedio").HasColumnType("int").IsOptional();
            Property(x => x.Medio_).HasColumnName(@"Medio").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);

            // Foreign keys
            HasOptional(a => a.TiposMedio).WithMany(b => b.Medios).HasForeignKey(c => c.IdTipoMedio).WillCascadeOnDelete(false); // FK_Medios_TiposMedios
        }
    }
}