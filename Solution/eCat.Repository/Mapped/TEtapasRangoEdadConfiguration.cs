namespace eCat.Repository.Mapped
{
    public class TEtapasRangoEdadConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TEtapasRangoEdad>
    {
        public TEtapasRangoEdadConfiguration()
            : this("dbo")
        {
        }

        public TEtapasRangoEdadConfiguration(string schema)
        {
            ToTable("T_EtapasRangoEdad", schema);
            HasKey(x => x.Codigo);

            Property(x => x.IdEtapaRangoEdad).HasColumnName(@"IdEtapaRangoEdad").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Codigo).HasColumnName(@"Codigo").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(5).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Nombre).HasColumnName(@"Nombre").HasColumnType("nvarchar").IsRequired().HasMaxLength(255);
            Property(x => x.Tipo).HasColumnName(@"Tipo").HasColumnType("tinyint").IsRequired();
            HasMany(t => t.DilveNivelEducativoAneles).WithMany(t => t.TEtapasRangoEdads).Map(m =>
            {
                m.ToTable("DILVE_NivelEducativoANELE_Equivalencias", "dbo");
                m.MapLeftKey("IdEtapaRangoEdad");
                m.MapRightKey("IdNivelEducaticoANELE");
            });
        }
    }
}