using AutoMapper;
using TodoApp;
using YourDeal.DTOs;

namespace YourDeal;

public class YourDealApplicationAutoMapperProfile : Profile
{
    public YourDealApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        CreateMap<PropDTO, PropModel>().ReverseMap();
    }
}
