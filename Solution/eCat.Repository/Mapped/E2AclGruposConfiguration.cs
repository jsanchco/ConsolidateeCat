namespace eCat.Repository.Mapped
{
    public class E2AclGruposConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.E2AclGrupos>
    {
        public E2AclGruposConfiguration()
            : this("dbo")
        {
        }

        public E2AclGruposConfiguration(string schema)
        {
            ToTable("E2_ACL_GRUPOS", schema);
            HasKey(x => x.IdGrupo);

            Property(x => x.IdGrupo).HasColumnName(@"ID_GRUPO").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Nombre).HasColumnName(@"Nombre").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Descripción).HasColumnName(@"Descripción").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.FCreacion).HasColumnName(@"FCreacion").HasColumnType("datetime").IsRequired();
            Property(x => x.FModificacion).HasColumnName(@"FModificacion").HasColumnType("datetime").IsRequired();
            HasMany(t => t.Usuarios).WithMany(t => t.E2AclGrupos).Map(m =>
            {
                m.ToTable("E2_ACL_REL_USUARIOSGRUPOS", "dbo");
                m.MapLeftKey("ID_Grupo");
                m.MapRightKey("ID_Usuaio");
            });
        }
    }
}