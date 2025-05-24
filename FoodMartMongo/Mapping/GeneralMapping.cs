using AutoMapper;
using FoodMartMongo.Dtos.CategoryDtos;
using FoodMartMongo.Dtos.CustomerDtos;
using FoodMartMongo.Dtos.DiscountDtos;
using FoodMartMongo.Dtos.FeatureDtos;
using FoodMartMongo.Dtos.PeopleViewingDtos;
using FoodMartMongo.Dtos.ProductDtos;
using FoodMartMongo.Entities;

namespace FoodMartMongo.Mapping
{
	public class GeneralMapping : Profile
	{
		public GeneralMapping()
		{
			CreateMap<Category, ResultCategoryDto>().ReverseMap();
			CreateMap<Category, CreateCategoryDto>().ReverseMap();
			CreateMap<Category, UpdateCategoryDto>().ReverseMap();
			CreateMap<Category, GetCategoryByIdDto>().ReverseMap();

			CreateMap<Product, ResultProductDto>().ReverseMap();
			CreateMap<Product, CreateProductDto>().ReverseMap();
			CreateMap<Product, UpdateProductDto>().ReverseMap();
			CreateMap<Product, GetProductByIdDto>().ReverseMap();
			CreateMap<Product, ResultProductWithCategoryDto>().ReverseMap();

			CreateMap<Customer, ResultCustomerDto>().ReverseMap();
			CreateMap<Customer, CreateCustomerDto>().ReverseMap();
			CreateMap<Customer, UpdateCustomerDto>().ReverseMap();
			CreateMap<Customer, GetCustomerByIdDto>().ReverseMap();

			CreateMap<Feature, ResultFeatureDto>().ReverseMap();
			CreateMap<Feature, CreateFeatureDto>().ReverseMap();
			CreateMap<Feature, UpdateFeatureDto>().ReverseMap();
			CreateMap<Feature, GetFeatureByIdDto>().ReverseMap();

			CreateMap<Discount, ResultDiscountDto>().ReverseMap();
			CreateMap<Discount, CreateDiscountDto>().ReverseMap();
			CreateMap<Discount, UpdateDiscountDto>().ReverseMap();
			CreateMap<Discount, GetDiscountByIdDto>().ReverseMap();

			CreateMap<PeopleViewing, ResultPeopleViewingDto>().ReverseMap();
			CreateMap<PeopleViewing, CreatePeopleViewingDto>().ReverseMap();
			CreateMap<PeopleViewing, UpdatePeopleViewingDto>().ReverseMap();
			CreateMap<PeopleViewing, GetPeopleViewingByIdDto>().ReverseMap();
		}
	}
}
