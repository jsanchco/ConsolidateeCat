namespace eCat.Repository.Mapped
{
    public class PublicoObjetivoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.PublicoObjetivo>
    {
        public PublicoObjetivoConfiguration()
            : this("dbo")
        {
        }

        public PublicoObjetivoConfiguration(string schema)
        {
            ToTable("PublicoObjetivo", schema);
            HasKey(x => x.IdPublicoObjetivo);

            Property(x => x.IdPublicoObjetivo).HasColumnName(@"IDPublicoObjetivo").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.PublicoObjetivo_).HasColumnName(@"PublicoObjetivo").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.IdAplicacion).HasColumnName(@"IDAplicacion").HasColumnType("nvarchar").IsRequired().HasMaxLength(5);

            // Foreign keys
            HasRequired(a => a.Aplicacione).WithMany(b => b.PublicoObjetivoes).HasForeignKey(c => c.IdAplicacion).WillCascadeOnDelete(false); // FK_PublicoObjetivo_Aplicaciones
        }
    }
}