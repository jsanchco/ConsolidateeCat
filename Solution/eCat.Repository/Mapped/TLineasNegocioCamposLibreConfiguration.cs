namespace eCat.Repository.Mapped
{
    public class TLineasNegocioCamposLibreConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TLineasNegocioCamposLibre>
    {
        public TLineasNegocioCamposLibreConfiguration()
            : this("dbo")
        {
        }

        public TLineasNegocioCamposLibreConfiguration(string schema)
        {
            ToTable("T_LineasNegocio_CamposLibres", schema);
            HasKey(x => x.IdCampoLn);

            Property(x => x.IdCampoLn).HasColumnName(@"IdCampoLN").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.IdPais).HasColumnName(@"IdPais").HasColumnType("smallint").IsRequired();
            Property(x => x.IdLineaNegocio).HasColumnName(@"IdLineaNegocio").HasColumnType("tinyint").IsRequired();
            Property(x => x.NombreCampo).HasColumnName(@"NombreCampo").HasColumnType("nvarchar").IsRequired().HasMaxLength(255);
            Property(x => x.TipoCampo).HasColumnName(@"TipoCampo").HasColumnType("smallint").IsRequired();
            Property(x => x.Orden).HasColumnName(@"Orden").HasColumnType("smallint").IsRequired();

            // Foreign keys
            HasRequired(a => a.E2AclDominio).WithMany(b => b.TLineasNegocioCamposLibres).HasForeignKey(c => c.IdPais).WillCascadeOnDelete(false); // FK_T_LineasNegocio_CamposLibres_E2_ACL_DOMINIOS
            HasRequired(a => a.LineaNegocio).WithMany(b => b.TLineasNegocioCamposLibres).HasForeignKey(c => c.IdLineaNegocio).WillCascadeOnDelete(false); // FK_T_LineasNegocio_CamposLibres_LineaNegocio
        }
    }
}