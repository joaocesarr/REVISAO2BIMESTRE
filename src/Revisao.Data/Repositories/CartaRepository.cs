using Newtonsoft.Json;
using Revisao.Domain.ViewModels;
using Revisao.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Revisao.Data.Providers.MongoDB.Interfaces;
using AutoMapper;
using Revisao.Data.Providers.MongoDB.Collections;


namespace Revisao.Data.Repositories
{
    public class CartaRepository : ICartaRepository
    {

        private readonly IMongoRepository<DocumentoCartaCollection> _cartaRepository;
        private readonly IMapper _mapper;

        public CartaRepository(IMongoRepository<DocumentoCartaCollection> cartaRepository, IMapper mapper)
        {
            _cartaRepository = cartaRepository;
            _mapper = mapper;
        }
        public async Task Adicionar(DocumentosCarta documentosCarta)
        {
            await _cartaRepository.InsertOneAsync(_mapper.Map<DocumentoCartaCollection>(documentosCarta));
        }
        public IEnumerable<DocumentosCarta> ObterTodos()
        {
            var categoriaList = _cartaRepository.FilterBy(filter => true);
            return _mapper.Map<IEnumerable<DocumentosCarta>>(categoriaList);
        }

        //private List<DocumentosCarta> LerCartaDoArquivo()
        //{
        //    if (!System.IO.File.Exists(_CartaCaminhoArquivo))
        //        return new List<DocumentosCarta>();
        //    string json = System.IO.File.ReadAllText(_CartaCaminhoArquivo);
        //    return JsonConvert.DeserializeObject<List<DocumentosCarta>>(json);
        //}

        //private void EscreverCartaNoArquivo(List<DocumentosCarta> documentosCarta)
        //{
        //    string json = JsonConvert.SerializeObject(documentosCarta);
        //    System.IO.File.WriteAllText(_CartaCaminhoArquivo, json);
        //}
    }
}
