namespace eCat.Repository.Mapped
{
    public class TbFichasBaseImageneConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TbFichasBaseImagene>
    {
        public TbFichasBaseImageneConfiguration()
            : this("dbo")
        {
        }

        public TbFichasBaseImageneConfiguration(string schema)
        {
            ToTable("TB_FichasBase_Imagenes", schema);
            HasKey(x => x.IdFichasBaseImagen);

            Property(x => x.IdFichasBaseImagen).HasColumnName(@"IdFichasBaseImagen").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.IdInterno).HasColumnName(@"IdInterno").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(12);
            Property(x => x.IdTipoImagen).HasColumnName(@"IdTipoImagen").HasColumnType("tinyint").IsRequired();
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(255);
            Property(x => x.Fichero).HasColumnName(@"Fichero").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(255);
            Property(x => x.Pie).HasColumnName(@"Pie").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.Defecto).HasColumnName(@"Defecto").HasColumnType("bit").IsRequired();
            Property(x => x.Automatico).HasColumnName(@"Automatico").HasColumnType("bit").IsRequired();
            Property(x => x.Calidad).HasColumnName(@"Calidad").HasColumnType("tinyint").IsRequired();
            Property(x => x.Baja).HasColumnName(@"Baja").HasColumnType("bit").IsRequired();
            Property(x => x.IdFichasBaseImagenOrigen).HasColumnName(@"IdFichasBaseImagenOrigen").HasColumnType("bigint").IsOptional();
            Property(x => x.FechaCreacion).HasColumnName(@"FechaCreacion").HasColumnType("datetime").IsOptional();

            // Foreign keys
            HasRequired(a => a.FichasBase).WithMany(b => b.TbFichasBaseImagenes).HasForeignKey(c => c.IdInterno).WillCascadeOnDelete(false); // FK_TB_FichasBase_Imagenes_FichasBase
            HasRequired(a => a.TbImagenesTipos).WithMany(b => b.TbFichasBaseImagenes).HasForeignKey(c => c.IdTipoImagen).WillCascadeOnDelete(false); // FK_TB_FichasBase_Imagenes_TB_Imagenes_Tipos
        }
    }
}