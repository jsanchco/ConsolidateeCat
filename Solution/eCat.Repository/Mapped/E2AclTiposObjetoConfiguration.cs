namespace eCat.Repository.Mapped
{
    public class E2AclTiposObjetoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.E2AclTiposObjeto>
    {
        public E2AclTiposObjetoConfiguration()
            : this("dbo")
        {
        }

        public E2AclTiposObjetoConfiguration(string schema)
        {
            ToTable("E2_ACL_TIPOS_OBJETOS", schema);
            HasKey(x => x.IdTipo);

            Property(x => x.IdTipo).HasColumnName(@"ID_TIPO").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Objeto).HasColumnName(@"Objeto").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
        }
    }
}