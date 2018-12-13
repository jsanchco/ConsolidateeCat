namespace eCat.Repository.Mapped
{
    public class FechaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.Fecha>
    {
        public FechaConfiguration()
            : this("dbo")
        {
        }

        public FechaConfiguration(string schema)
        {
            ToTable("Fechas", schema);
            HasKey(x => new { x.IdInterno, x.IdEvento });

            Property(x => x.IdInterno).HasColumnName(@"IDInterno").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(12).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdEvento).HasColumnName(@"IDEvento").HasColumnType("nvarchar").IsRequired().HasMaxLength(5).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Fecha_).HasColumnName(@"Fecha").HasColumnType("smalldatetime").IsRequired();
            Property(x => x.Comentarios).HasColumnName(@"Comentarios").HasColumnType("nvarchar(max)").IsOptional();

            // Foreign keys
            HasRequired(a => a.Evento).WithMany(b => b.Fechas).HasForeignKey(c => c.IdEvento).WillCascadeOnDelete(false); // FK_Fechas_Eventos
            HasRequired(a => a.FichasBase).WithMany(b => b.Fechas).HasForeignKey(c => c.IdInterno).WillCascadeOnDelete(false); // FK_Fechas_FichasBase
        }
    }
}