namespace eCat.Repository.Mapped
{
    public class TbCamposFichaElementoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TbCamposFichaElemento>
    {
        public TbCamposFichaElementoConfiguration()
            : this("dbo")
        {
        }

        public TbCamposFichaElementoConfiguration(string schema)
        {
            ToTable("TB_CAMPOS_FICHA_ELEMENTOS", schema);
            HasKey(x => new { x.IdCampo, x.NumElemento });

            Property(x => x.IdCampo).HasColumnName(@"ID_CAMPO").HasColumnType("numeric").IsRequired().HasPrecision(18,0).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.NumElemento).HasColumnName(@"NumElemento").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Tag).HasColumnName(@"Tag").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.CampoSelect).HasColumnName(@"CampoSelect").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(255);

            // Foreign keys
            HasRequired(a => a.TbCamposFicha).WithMany(b => b.TbCamposFichaElementoes).HasForeignKey(c => c.IdCampo).WillCascadeOnDelete(false); // FK_TB_CAMPOS_FICHA_ELEMENTOS_TB_CAMPOS_FICHA
        }
    }
}