using AutoMapper;
using CleanArchMvc.Aplication.DTO;
using CleanArchMvc.Aplication.Products.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Aplication.Mappings
{
    public class DTOToCommandMappingProfile: Profile
    {
        public DTOToCommandMappingProfile()
        {
            CreateMap<ProductDTO, ProductCreateCommand>();
            CreateMap<ProductDTO, ProductUpdateCommand>();
        }
    }
}
