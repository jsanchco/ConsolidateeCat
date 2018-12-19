namespace eCat.Repository.Mapped
{
    public class TAmbitosCesionConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TAmbitosCesion>
    {
        public TAmbitosCesionConfiguration()
            : this("dbo")
        {
        }

        public TAmbitosCesionConfiguration(string schema)
        {
            ToTable("T_AmbitosCesion", schema);
            HasKey(x => x.IdAmbitoCesion);

            Property(x => x.IdAmbitoCesion).HasColumnName(@"IdAmbitoCesion").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(255);
            Property(x => x.IdGrupoAmbitoCesion).HasColumnName(@"IdGrupoAmbitoCesion").HasColumnType("int").IsOptional();

            // Foreign keys
            HasOptional(a => a.TAmbitosCesionGrupos).WithMany(b => b.TAmbitosCesions).HasForeignKey(c => c.IdGrupoAmbitoCesion).WillCascadeOnDelete(false); // FK_T_AmbitosCesion_T_AmbitosCesion_Grupos
            //HasMany(t => t.TFichasBaseAmbitosCesions).WithMany(t => t.TAmbitosCesions).Map(m =>
            //{
            //    m.ToTable("T_FichasBase_AmbitosCesion_Restricciones", "dbo");
            //    m.MapLeftKey("IdAmbitoCesionRestriccion");
            //    m.MapRightKey("IdFichasBaseAmbitoCesion");
            //});
            HasMany(t => t.DilvePais).WithMany(t => t.TAmbitosCesions).Map(m =>
            {
                m.ToTable("DILVE_AmbitosCesion_Paises_Equivalencias", "dbo");
                m.MapLeftKey("IdAmbitoCesion");
                m.MapRightKey("IdPaisDILVE");
            });
            HasMany(t => t.DilveTerritorios).WithMany(t => t.TAmbitosCesions).Map(m =>
            {
                m.ToTable("DILVE_AmbitosCesion_Territorios_Equivalencias", "dbo");
                m.MapLeftKey("IdAmbitoCesion");
                m.MapRightKey("IdTerritorioDILVE");
            });
        }
    }
}