namespace eCat.Repository.Mapped
{
    public class FichasBaseArchivoHistoricoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.FichasBaseArchivoHistorico>
    {
        public FichasBaseArchivoHistoricoConfiguration()
            : this("dbo")
        {
        }

        public FichasBaseArchivoHistoricoConfiguration(string schema)
        {
            ToTable("FichasBase_ArchivoHistorico", schema);
            HasKey(x => x.IdArchivoHistorico);

            Property(x => x.IdArchivoHistorico).HasColumnName(@"IdArchivoHistorico").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.IdInterno).HasColumnName(@"IdInterno").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(12);
            Property(x => x.Año).HasColumnName(@"Año").HasColumnType("smallint").IsOptional();
            Property(x => x.Texto).HasColumnName(@"Texto").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);

            // Foreign keys
            HasRequired(a => a.FichasBase).WithMany(b => b.FichasBaseArchivoHistoricoes).HasForeignKey(c => c.IdInterno).WillCascadeOnDelete(false); // FK_FichasBase_ArchivoHistorico_FichasBase
        }
    }
}