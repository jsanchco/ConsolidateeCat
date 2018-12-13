namespace eCat.Repository.Mapped
{
    public class E2AclObjetosIdiomaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.E2AclObjetosIdioma>
    {
        public E2AclObjetosIdiomaConfiguration()
            : this("dbo")
        {
        }

        public E2AclObjetosIdiomaConfiguration(string schema)
        {
            ToTable("E2_ACL_OBJETOS_Idioma", schema);
            HasKey(x => new { x.IdObjeto, x.IdIdiomaPlataforma });

            Property(x => x.IdObjeto).HasColumnName(@"ID_OBJETO").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Nombre).HasColumnName(@"Nombre").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.IdIdiomaPlataforma).HasColumnName(@"IdIdiomaPlataforma").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);

            // Foreign keys
            HasRequired(a => a.E2AclObjeto).WithMany(b => b.E2AclObjetosIdioma).HasForeignKey(c => c.IdObjeto).WillCascadeOnDelete(false); // FK_E2_ACL_OBJETOS_Idioma_E2_ACL_OBJETOS
            HasRequired(a => a.TIdiomasPlataforma).WithMany(b => b.E2AclObjetosIdioma).HasForeignKey(c => c.IdIdiomaPlataforma).WillCascadeOnDelete(false); // FK_E2_ACL_OBJETOS_Idioma_T_Idiomas_Plataforma
        }
    }
}