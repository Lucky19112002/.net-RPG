using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webAPT_DEMO
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto,Character>();
        }
    }
}