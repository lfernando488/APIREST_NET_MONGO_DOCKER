using API.Entities;
using API.Entities.ViewModels;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Mappers
{
    public class EntityToViewModelMapping : Profile
    {

        public EntityToViewModelMapping()
        {
            //Entra news sai newsviewmodel
            CreateMap<News, NewsViewModel>();
        }


    }
}
