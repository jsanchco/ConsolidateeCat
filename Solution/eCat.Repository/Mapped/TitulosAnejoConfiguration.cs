namespace eCat.Repository.Mapped
{
    public class TitulosAnejoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TitulosAnejo>
    {
        public TitulosAnejoConfiguration()
            : this("dbo")
        {
        }

        public TitulosAnejoConfiguration(string schema)
        {
            ToTable("TitulosAnejos", schema);
            HasKey(x => new { x.IdInterno, x.IdObraAneja });

            Property(x => x.IdInterno).HasColumnName(@"IDInterno").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(12).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Orden).HasColumnName(@"Orden").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdObraAneja).HasColumnName(@"IDObraAneja").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(12).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);

            // Foreign keys
            HasRequired(a => a.FichasBase).WithMany(b => b.TitulosAnejoes).HasForeignKey(c => c.IdInterno).WillCascadeOnDelete(false); // FK_TitulosAnejos_FichasBase
        }
    }
}