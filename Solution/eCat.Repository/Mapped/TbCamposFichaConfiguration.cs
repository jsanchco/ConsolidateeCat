namespace eCat.Repository.Mapped
{
    public class TbCamposFichaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TbCamposFicha>
    {
        public TbCamposFichaConfiguration()
            : this("dbo")
        {
        }

        public TbCamposFichaConfiguration(string schema)
        {
            ToTable("TB_CAMPOS_FICHA", schema);
            HasKey(x => x.IdCampo);

            Property(x => x.IdCampo).HasColumnName(@"ID_CAMPO").HasColumnType("numeric").IsRequired().HasPrecision(18,0).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NombreCampo).HasColumnName(@"NombreCampo").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.NivelTag).HasColumnName(@"NivelTag").HasColumnType("int").IsRequired();
            Property(x => x.CampoLucene).HasColumnName(@"CampoLucene").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);

            // Foreign keys
            HasRequired(a => a.TbCamposNivele).WithMany(b => b.TbCamposFichas).HasForeignKey(c => c.NivelTag).WillCascadeOnDelete(false); // FK_TB_CAMPOS_FICHA_TB_CAMPOS_NIVELES
            HasMany(t => t.E2GeCatalogo).WithMany(t => t.TbCamposFichas).Map(m =>
            {
                m.ToTable("E2_GE_CATALOGOS_REL_CAMPOS_FICHA", "dbo");
                m.MapLeftKey("ID_CAMPO");
                m.MapRightKey("ID_CATALOGO");
            });
        }
    }
}