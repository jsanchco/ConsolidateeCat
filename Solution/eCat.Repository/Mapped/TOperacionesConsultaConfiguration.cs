namespace eCat.Repository.Mapped
{
    public class TOperacionesConsultaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TOperacionesConsulta>
    {
        public TOperacionesConsultaConfiguration()
            : this("dbo")
        {
        }

        public TOperacionesConsultaConfiguration(string schema)
        {
            ToTable("T_OperacionesConsultas", schema);
            HasKey(x => x.IdOperacion);

            Property(x => x.IdOperacion).HasColumnName(@"IdOperacion").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Operacion).HasColumnName(@"Operacion").HasColumnType("nvarchar").IsRequired().HasMaxLength(255);
            HasMany(t => t.TTiposCamposConsultas).WithMany(t => t.TOperacionesConsultas).Map(m =>
            {
                m.ToTable("T_TiposCampos_Operaciones_Consultas", "dbo");
                m.MapLeftKey("IdOperacion");
                m.MapRightKey("IdTipoCampo");
            });
        }
    }
}