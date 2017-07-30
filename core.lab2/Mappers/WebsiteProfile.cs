using AutoMapper;
using core.lab2.Controllers;
using core.lab2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core.lab2.Mappers
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
