using AutoMapper;
using Revisao.Data.Providers.MongoDB.Collections;
using Revisao.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Data.AutoMapper
{
    public class DomainToCollection : Profile
    {
        public DomainToCollection()
        {
            CreateMap<DocumentosCarta, DocumentoCartaCollection>();
        }
    }
}
