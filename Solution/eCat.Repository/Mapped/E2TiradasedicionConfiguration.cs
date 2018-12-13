namespace eCat.Repository.Mapped
{
    public class E2TiradasedicionConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.E2Tiradasedicion>
    {
        public E2TiradasedicionConfiguration()
            : this("dbo")
        {
        }

        public E2TiradasedicionConfiguration(string schema)
        {
            ToTable("E2_TIRADASEDICION", schema);
            HasKey(x => new { x.IdInterno, x.NumeroEdicion });

            Property(x => x.IdInterno).HasColumnName(@"IDInterno").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(12).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.NumeroEdicion).HasColumnName(@"Numero_Edicion").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Tirada).HasColumnName(@"Tirada").HasColumnType("int").IsOptional();
            Property(x => x.Fecha).HasColumnName(@"Fecha").HasColumnType("datetime").IsOptional();
            Property(x => x.DepositoLegal).HasColumnName(@"DepositoLegal").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(25);

            // Foreign keys
            HasRequired(a => a.FichasBase).WithMany(b => b.E2Tiradasedicion).HasForeignKey(c => c.IdInterno).WillCascadeOnDelete(false); // FK_E2_TIRADASEDICION_FichasBase
        }
    }
}