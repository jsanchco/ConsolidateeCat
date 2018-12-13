namespace eCat.Repository.Mapped
{
    public class TLineasNegocioCamposLibresValoreConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TLineasNegocioCamposLibresValore>
    {
        public TLineasNegocioCamposLibresValoreConfiguration()
            : this("dbo")
        {
        }

        public TLineasNegocioCamposLibresValoreConfiguration(string schema)
        {
            ToTable("T_LineasNegocio_CamposLibres_Valores", schema);
            HasKey(x => x.IdValor);

            Property(x => x.IdValor).HasColumnName(@"IdValor").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.IdCampoLn).HasColumnName(@"IdCampoLN").HasColumnType("int").IsRequired();
            Property(x => x.Valor).HasColumnName(@"Valor").HasColumnType("nvarchar").IsRequired().HasMaxLength(255);
            Property(x => x.CodigoSap).HasColumnName(@"CodigoSAP").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(20);

            // Foreign keys
            HasRequired(a => a.TLineasNegocioCamposLibre).WithMany(b => b.TLineasNegocioCamposLibresValores).HasForeignKey(c => c.IdCampoLn).WillCascadeOnDelete(false); // FK_T_LineasNegocio_CamposLibres_Valores_T_LineasNegocio_CamposLibres
        }
    }
}