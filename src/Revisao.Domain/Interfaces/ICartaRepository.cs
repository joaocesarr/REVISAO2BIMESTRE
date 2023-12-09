using Revisao.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Domain.Interfaces
{
    public interface ICartaRepository
    {
        public IEnumerable<DocumentosCarta> ObterTodos();
        Task Adicionar(DocumentosCarta documentosCarta);
    }
}
