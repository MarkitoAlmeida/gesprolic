using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace GesProLic.Application.Mapper
{
    public class AutoMapperConfig
    {
        protected AutoMapperConfig() { }

        public static MapperConfiguration RegisterMapper()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new DomainToViewModelMap());
                cfg.AddProfile(new ViewModelToDomainMap());
            });
        }
    }
}
