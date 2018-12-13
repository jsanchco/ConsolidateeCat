namespace eCat.Repository.Mapped
{
    public class TE2GeCatalogosPreciosEspecialeConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TE2GeCatalogosPreciosEspeciale>
    {
        public TE2GeCatalogosPreciosEspecialeConfiguration()
            : this("dbo")
        {
        }

        public TE2GeCatalogosPreciosEspecialeConfiguration(string schema)
        {
            ToTable("T_E2_GE_CATALOGOS_PreciosEspeciales", schema);
            HasKey(x => new { x.IdCatalogo, x.Campo });

            Property(x => x.IdCatalogo).HasColumnName(@"IdCatalogo").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Campo).HasColumnName(@"Campo").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(128).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Valor).HasColumnName(@"Valor").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(128);
            Property(x => x.Precio).HasColumnName(@"Precio").HasColumnType("decimal").IsOptional().HasPrecision(24,2);
            Property(x => x.Orden).HasColumnName(@"Orden").HasColumnType("int").IsRequired();

            // Foreign keys
            HasRequired(a => a.TE2GeCatalogosPreciosEspecialesCampos).WithMany(b => b.TE2GeCatalogosPreciosEspeciale).HasForeignKey(c => c.Campo).WillCascadeOnDelete(false); // FK_T_E2_GE_CATALOGOS_PreciosEspeciales_T_E2_GE_CATALOGOS_PreciosEspeciales_Campos
        }
    }
}