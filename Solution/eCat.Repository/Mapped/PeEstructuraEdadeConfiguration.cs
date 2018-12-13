namespace eCat.Repository.Mapped
{
    public class PeEstructuraEdadeConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.PeEstructuraEdade>
    {
        public PeEstructuraEdadeConfiguration()
            : this("dbo")
        {
        }

        public PeEstructuraEdadeConfiguration(string schema)
        {
            ToTable("PE_EstructuraEdades", schema);
            HasKey(x => x.IdEstructura);

            Property(x => x.IdEstructura).HasColumnName(@"IdEstructura").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.IdPais).HasColumnName(@"IdPais").HasColumnType("smallint").IsRequired();
            Property(x => x.Baja).HasColumnName(@"Baja").HasColumnType("bit").IsRequired();
            Property(x => x.FechaAlta).HasColumnName(@"FechaAlta").HasColumnType("datetime").IsRequired();
            Property(x => x.FechaBaja).HasColumnName(@"FechaBaja").HasColumnType("datetime").IsOptional();
            Property(x => x.FechaUltimaModificacion).HasColumnName(@"FechaUltimaModificacion").HasColumnType("datetime").IsOptional();

            // Foreign keys
            HasRequired(a => a.E2AclDominio).WithMany(b => b.PeEstructuraEdades).HasForeignKey(c => c.IdPais).WillCascadeOnDelete(false); // FK_PE_Edades_E2_ACL_DOMINIOS
        }
    }
}