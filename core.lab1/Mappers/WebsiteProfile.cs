using AutoMapper;
using core.lab1.Controllers;
using core.lab1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core.lab1.Mappers
{
    public class WebsiteProfile : Profile
    {
        public WebsiteProfile()
        {
            CreateMap<Website, WebsiteReadModel>();
            CreateMap<WebsiteCreateModel, Website>();
        }
    }
}
