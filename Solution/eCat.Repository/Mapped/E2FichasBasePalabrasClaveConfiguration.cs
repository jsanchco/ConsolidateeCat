namespace eCat.Repository.Mapped
{
    public class E2FichasBasePalabrasClaveConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.E2FichasBasePalabrasClave>
    {
        public E2FichasBasePalabrasClaveConfiguration()
            : this("dbo")
        {
        }

        public E2FichasBasePalabrasClaveConfiguration(string schema)
        {
            ToTable("E2_FichasBase_PalabrasClave", schema);
            HasKey(x => new { x.IdInterno, x.IdPalabra });

            Property(x => x.IdInterno).HasColumnName(@"IDInterno").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(12).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdPalabra).HasColumnName(@"IDPalabra").HasColumnType("nvarchar").IsRequired().HasMaxLength(6).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Orden).HasColumnName(@"Orden").HasColumnType("int").IsOptional();

            // Foreign keys
            HasRequired(a => a.FichasBase).WithMany(b => b.E2FichasBasePalabrasClave).HasForeignKey(c => c.IdInterno).WillCascadeOnDelete(false); // FK_E2_FichasBase_PalabrasClave_FichasBase
            HasRequired(a => a.PalabrasClave).WithMany(b => b.E2FichasBasePalabrasClave).HasForeignKey(c => c.IdPalabra).WillCascadeOnDelete(false); // FK_E2_FichasBase_PalabrasClave_PalabrasClave
        }
    }
}