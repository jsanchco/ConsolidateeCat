namespace eCat.Repository.Mapped
{
    public class ResenaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.Resena>
    {
        public ResenaConfiguration()
            : this("dbo")
        {
        }

        public ResenaConfiguration(string schema)
        {
            ToTable("Resenas", schema);
            HasKey(x => new { x.IdInterno, x.IdResena });

            Property(x => x.IdInterno).HasColumnName(@"IDInterno").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(12).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdResena).HasColumnName(@"IDResena").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdMedio).HasColumnName(@"IDMedio").HasColumnType("int").IsRequired();
            Property(x => x.Fecha).HasColumnName(@"Fecha").HasColumnType("smalldatetime").IsRequired();
            Property(x => x.Resena_).HasColumnName(@"Resena").HasColumnType("nvarchar(max)").IsOptional();

            // Foreign keys
            HasRequired(a => a.FichasBase).WithMany(b => b.Resenas).HasForeignKey(c => c.IdInterno).WillCascadeOnDelete(false); // FK_Resenas_FichasBase
            HasRequired(a => a.Medio).WithMany(b => b.Resenas).HasForeignKey(c => c.IdMedio).WillCascadeOnDelete(false); // FK_Resenas_Medios
        }
    }
}