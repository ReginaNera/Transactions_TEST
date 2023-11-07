using AutoMapper;
using DBDataAccess.Models;
using System;
using Transactions_TEST.Enumeratons;
using Transactions_TEST.Models;

namespace Transactions_TEST
{
    public class Automapper : Profile
    {
        public Automapper()
        {
            CreateMap<InsertTransactionRequestModel, TransactionModel>().ReverseMap();
            CreateMap<TransactionModel, TransactionResponseModel>()
                .ForMember(dest => dest.Id,
               opts => opts.MapFrom(src => src.Id))
                .ForMember(dest => dest.Amount,
               opts => opts.MapFrom(src => src.Amount))
                .ForMember(dest => dest.Currency,
               opts => opts.MapFrom(src => src.Currency))
                .ForMember(dest => dest.CardholderNumber,
               opts => opts.MapFrom(src => src.CardholderNumber))
                .ForMember(dest => dest.HolderName,
               opts => opts.MapFrom(src => src.HolderName))
                .ForMember(dest => dest.Status,
               opts => opts.MapFrom(src => Enum.GetName(typeof(StatusEnum),(StatusEnum)Enum.ToObject(typeof(StatusEnum), src.Status))));
                

           
        }
    }
}
