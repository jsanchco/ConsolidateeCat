namespace eCat.Repository.Mapped
{
    public class FichasBaseSoporteConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.FichasBaseSoporte>
    {
        public FichasBaseSoporteConfiguration()
            : this("dbo")
        {
        }

        public FichasBaseSoporteConfiguration(string schema)
        {
            ToTable("FichasBase_Soporte", schema);
            HasKey(x => new { x.IdInterno, x.IdSoporte });

            Property(x => x.IdInterno).HasColumnName(@"IdInterno").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(12).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdSoporte).HasColumnName(@"IdSoporte").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Cantidad).HasColumnName(@"Cantidad").HasColumnType("tinyint").IsRequired();
            Property(x => x.Orden).HasColumnName(@"Orden").HasColumnType("tinyint").IsRequired();

            // Foreign keys
            HasRequired(a => a.FichasBase).WithMany(b => b.FichasBaseSoportes).HasForeignKey(c => c.IdInterno).WillCascadeOnDelete(false); // FK_FichasBase_Soporte_FichasBase
            HasRequired(a => a.TSoporte).WithMany(b => b.FichasBaseSoportes).HasForeignKey(c => c.IdSoporte).WillCascadeOnDelete(false); // FK_FichasBase_Soporte_T_Soportes
        }
    }
}