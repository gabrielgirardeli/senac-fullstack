using MediatR;
using MeuCorre.Application.UseCases.Categorias.Commands;
using MeuCorre.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuCorre.Application.UseCases.tags.Commands
{
 public   class AtualizarTagCommand : IRequest<(string, bool)>
    {
        [Required(ErrorMessage = "Id da tag é obrigatório")]
        public required Guid UsuarioId { get; set; }

        [Required(ErrorMessage = "Nome da tag é obrigatório")]
        public required string Nome { get; set; }

        [Required(ErrorMessage = "a cor da tag (despesa ou receita) é obrigatório")]

        public required string Cor { get; set; }

    }
    internal class AtualizarCategoriaCommandHandler : IRequestHandler<AtualizarCategoriaCommand, (string, bool)>
    {
        public Task<(string, bool)> Handle(AtualizarCategoriaCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
