namespace eCat.Repository.Mapped
{
    public class E2AclObjetoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.E2AclObjeto>
    {
        public E2AclObjetoConfiguration()
            : this("dbo")
        {
        }

        public E2AclObjetoConfiguration(string schema)
        {
            ToTable("E2_ACL_OBJETOS", schema);
            HasKey(x => x.IdObjeto);

            Property(x => x.IdObjeto).HasColumnName(@"ID_OBJETO").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Codigo).HasColumnName(@"Codigo").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Nombre).HasColumnName(@"Nombre").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.IdPadre).HasColumnName(@"IdPadre").HasColumnType("int").IsOptional();
            Property(x => x.Icono).HasColumnName(@"Icono").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(255);
            Property(x => x.PantallaUrl).HasColumnName(@"PantallaUrl").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(1000);
            Property(x => x.Activo).HasColumnName(@"Activo").HasColumnType("bit").IsRequired();
            Property(x => x.Orden).HasColumnName(@"Orden").HasColumnType("int").IsOptional();
            Property(x => x.EnEscritorio).HasColumnName(@"EnEscritorio").HasColumnType("bit").IsRequired();
            HasMany(t => t.E2AclTiposObjeto).WithMany(t => t.E2AclObjeto).Map(m =>
            {
                m.ToTable("E2_ACL_REL_TIPOSOBJETOS", "dbo");
                m.MapLeftKey("ID_OBJETO");
                m.MapRightKey("ID_TIPO");
            });
        }
    }
}