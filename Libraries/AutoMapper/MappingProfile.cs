using AutoMapper;
using EmporioVirtual.Models.ProdutoAgregador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmporioVirtual.Libraries.AutoMapper
{
    public class MappingProfile : Profile
    {
        //ctor - criar método construtor
        public MappingProfile()
        {
            CreateMap<Produto, ProdutoItem>();
        }
    }
}
