namespace eCat.Repository.Mapped
{
    public class PalabrasClaveConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.PalabrasClave>
    {
        public PalabrasClaveConfiguration()
            : this("dbo")
        {
        }

        public PalabrasClaveConfiguration(string schema)
        {
            ToTable("PalabrasClave", schema);
            HasKey(x => x.IdPalabra);

            Property(x => x.IdPalabra).HasColumnName(@"IDPalabra").HasColumnType("nvarchar").IsRequired().HasMaxLength(6).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Palabra).HasColumnName(@"Palabra").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.IdGrupoPalabraClave).HasColumnName(@"IDGrupoPalabraClave").HasColumnType("int").IsOptional();

            // Foreign keys
            HasOptional(a => a.PalabrasClaveGrupos).WithMany(b => b.PalabrasClaves).HasForeignKey(c => c.IdGrupoPalabraClave).WillCascadeOnDelete(false); // FK_PalabrasClave_PalabrasClaveGrupos
        }
    }
}