using MediatR;
using MeuCorre.Application.UseCases.Categorias.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuCorre.Application.UseCases.tags.Commands
{
   public class DeletarTagCommand : IRequest<(string, bool)>
    {
        [Required(ErrorMessage = "E necessário informar o id do usuário")]
        public required Guid UsuarioId { get; set; }

        [Required(ErrorMessage = "E necessário informar o id da categoria")]
        public required Guid TagId { get; set; }
    }
    internal class DeletarCategoriaCommadHandler : IRequestHandler<DeletarTegCommand, (string, bool)>
    {
        public Task<(string, bool)> Handle(DeletarTegCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
