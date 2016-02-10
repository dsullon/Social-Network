using SocialNetwork.RestServices.Dominio;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace SocialNetwork.RestServices.Mappers
{
    public class UsuarioConfiguracion : EntityTypeConfiguration<Usuario>
    {
        public UsuarioConfiguracion()
        {
            this.ToTable("Usuarios");

            this.HasKey(c => c.Id);
            this.Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(c => c.Id).IsRequired();

            this.Property(c => c.Email).IsRequired();
            this.Property(c => c.Email).HasMaxLength(80);
            this.Property(c => c.Email).HasColumnAnnotation(IndexAnnotation.AnnotationName, new IndexAnnotation(new IndexAttribute("UQ_UsuarioEmail") { IsUnique = true }));

            this.Property(c => c.Nick).IsRequired();
            this.Property(c => c.Nick).HasMaxLength(80);
            this.Property(c => c.Nick).HasColumnAnnotation(IndexAnnotation.AnnotationName, new IndexAnnotation(new IndexAttribute("UQ_UsuarioNick") { IsUnique = true }));

            this.Property(c=>c.Password).IsRequired();
            this.Property(c => c.Password).HasMaxLength(80);

            this.Property(c => c.Nombre).IsRequired();
            this.Property(c => c.Nombre).HasMaxLength(80);

            this.Property(c => c.Apellido).IsRequired();
            this.Property(c => c.Apellido).HasMaxLength(80);


            this.Property(c => c.Foto).IsOptional();
            this.Property(c => c.Foto).HasMaxLength(255);

            this.Property(c => c.FechaCreacion).IsRequired();
        }
    }
}