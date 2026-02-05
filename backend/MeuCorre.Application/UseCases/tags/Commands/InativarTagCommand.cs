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
    public class InativarTagCommand : IRequest<(string, bool)>
    {
        [Required(ErrorMessage = "É necessário informar o ID da categoria")]
        public required Guid TagId { get; set; }
        public required Guid UsuarioId { get; set; }
    }
    internal class InativarCategoriaCommandHandler : IRequestHandler<InativarCategoriaCommand, (string, bool)>
    {
        public Task<(string, bool)> Handle(InativarCategoriaCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
