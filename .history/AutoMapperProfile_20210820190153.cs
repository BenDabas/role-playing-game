using dotnet_rpg.Dtos.Character;
using dotnet_rpg.Models;
using AutoMapper;

namespace dotnet_rpg
{
    public class AutoMapperProfile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
        }
    }
}