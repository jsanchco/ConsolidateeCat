namespace eCat.Repository.Mapped
{
    public class ConsultaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.Consulta>
    {
        public ConsultaConfiguration()
            : this("dbo")
        {
        }

        public ConsultaConfiguration(string schema)
        {
            ToTable("_Consultas", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Consulta_).HasColumnName(@"Consulta").HasColumnType("varchar(max)").IsRequired().IsUnicode(false);
        }
    }
}