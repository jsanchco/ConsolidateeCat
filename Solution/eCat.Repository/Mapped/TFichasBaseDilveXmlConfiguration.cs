namespace eCat.Repository.Mapped
{
    public class TFichasBaseDilveXmlConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TFichasBaseDilveXml>
    {
        public TFichasBaseDilveXmlConfiguration()
            : this("dbo")
        {
        }

        public TFichasBaseDilveXmlConfiguration(string schema)
        {
            ToTable("T_FichasBase_DILVE_Xml", schema);
            HasKey(x => x.IdInterno);

            Property(x => x.IdInterno).HasColumnName(@"IdInterno").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(12).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.XmlDilve).HasColumnName(@"XmlDILVE").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.Comentarios).HasColumnName(@"Comentarios").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.Fecha).HasColumnName(@"Fecha").HasColumnType("datetime").IsRequired();
            Property(x => x.IdTipoEnvioDilve).HasColumnName(@"IdTipoEnvioDILVE").HasColumnType("tinyint").IsRequired();

            // Foreign keys
            HasRequired(a => a.TTiposEnvioDilve).WithMany(b => b.TFichasBaseDilveXmls).HasForeignKey(c => c.IdTipoEnvioDilve).WillCascadeOnDelete(false); // FK_T_FichasBase_DILVE_Xml_T_TiposEnvio_DILVE
        }
    }
}