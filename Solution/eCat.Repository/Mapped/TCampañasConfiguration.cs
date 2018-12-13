namespace eCat.Repository.Mapped
{
    public class TCampañasConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TCampañas>
    {
        public TCampañasConfiguration()
            : this("dbo")
        {
        }

        public TCampañasConfiguration(string schema)
        {
            ToTable("T_Campañas", schema);
            HasKey(x => x.IdCampaña);

            Property(x => x.IdCampaña).HasColumnName(@"IdCampaña").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.Inicio).HasColumnName(@"Inicio").HasColumnType("datetime").IsOptional();
            Property(x => x.Fin).HasColumnName(@"Fin").HasColumnType("datetime").IsOptional();
            HasMany(t => t.E2AclDominio).WithMany(t => t.TCampañas).Map(m =>
            {
                m.ToTable("T_Campañas_Dominios", "dbo");
                m.MapLeftKey("IdCampaña");
                m.MapRightKey("IdDominio");
            });
        }
    }
}