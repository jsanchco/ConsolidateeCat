namespace eCat.Repository.Mapped
{
    public class RelFrasesDescriptivaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.RelFrasesDescriptiva>
    {
        public RelFrasesDescriptivaConfiguration()
            : this("dbo")
        {
        }

        public RelFrasesDescriptivaConfiguration(string schema)
        {
            ToTable("RelFrasesDescriptivas", schema);
            HasKey(x => new { x.IdInterno, x.IdPublicoObjetivo, x.IdFraseDescriptiva });

            Property(x => x.IdInterno).HasColumnName(@"IDInterno").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(12).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdPublicoObjetivo).HasColumnName(@"IDPublicoObjetivo").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdFraseDescriptiva).HasColumnName(@"IDFraseDescriptiva").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.FraseDescriptiva).HasColumnName(@"FraseDescriptiva").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);

            // Foreign keys
            HasRequired(a => a.FichasBase).WithMany(b => b.RelFrasesDescriptivas).HasForeignKey(c => c.IdInterno).WillCascadeOnDelete(false); // FK_RelFrasesDescriptivas_FichasBase
            HasRequired(a => a.PublicoObjetivo).WithMany(b => b.RelFrasesDescriptivas).HasForeignKey(c => c.IdPublicoObjetivo).WillCascadeOnDelete(false); // FK_RelFrasesDescriptivas_PublicoObjetivo
        }
    }
}