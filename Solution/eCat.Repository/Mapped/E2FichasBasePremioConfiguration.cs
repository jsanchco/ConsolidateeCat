namespace eCat.Repository.Mapped
{
    public class E2FichasBasePremioConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.E2FichasBasePremio>
    {
        public E2FichasBasePremioConfiguration()
            : this("dbo")
        {
        }

        public E2FichasBasePremioConfiguration(string schema)
        {
            ToTable("E2_FichasBase_Premios", schema);
            HasKey(x => x.IdInternoPremio);

            Property(x => x.IdInternoPremio).HasColumnName(@"IDInternoPremio").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdInterno).HasColumnName(@"IDInterno").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(12);
            Property(x => x.IdPremio).HasColumnName(@"IDPremio").HasColumnType("int").IsRequired();
            Property(x => x.Anyo).HasColumnName(@"Anyo").HasColumnType("smallint").IsOptional();
            Property(x => x.Comentarios).HasColumnName(@"Comentarios").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(3000);

            // Foreign keys
            HasOptional(a => a.FichasBase).WithMany(b => b.E2FichasBasePremio).HasForeignKey(c => c.IdInterno).WillCascadeOnDelete(false); // FK_E2_FichasBase_Premios_FichasBase
            HasRequired(a => a.Premio).WithMany(b => b.E2FichasBasePremio).HasForeignKey(c => c.IdPremio).WillCascadeOnDelete(false); // FK_E2_FichasBase_Premios_Premios
        }
    }
}