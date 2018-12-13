namespace eCat.Repository.Mapped
{
    public class E2AclRelGruposobjetoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.E2AclRelGruposobjeto>
    {
        public E2AclRelGruposobjetoConfiguration()
            : this("dbo")
        {
        }

        public E2AclRelGruposobjetoConfiguration(string schema)
        {
            ToTable("E2_ACL_REL_GRUPOSOBJETOS", schema);
            HasKey(x => new { x.IdGrupo, x.IdObjeto, x.IdTipo });

            Property(x => x.IdGrupo).HasColumnName(@"ID_GRUPO").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdObjeto).HasColumnName(@"ID_OBJETO").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdTipo).HasColumnName(@"ID_TIPO").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Info).HasColumnName(@"INFO").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(255);

            // Foreign keys
            HasRequired(a => a.E2AclGrupos).WithMany(b => b.E2AclRelGruposobjeto).HasForeignKey(c => c.IdGrupo).WillCascadeOnDelete(false); // FK_E2_ACL_REL_GRUPOSOBJETOS_E2_ACL_GRUPOS
            HasRequired(a => a.E2AclObjeto).WithMany(b => b.E2AclRelGruposobjeto).HasForeignKey(c => c.IdObjeto).WillCascadeOnDelete(false); // FK_E2_ACL_REL_GRUPOSOBJETOS_E2_ACL_OBJETOS
            HasRequired(a => a.E2AclTiposObjeto).WithMany(b => b.E2AclRelGruposobjeto).HasForeignKey(c => c.IdTipo).WillCascadeOnDelete(false); // FK_E2_ACL_REL_GRUPOSOBJETOS_E2_ACL_TIPOS_OBJETOS
        }
    }
}