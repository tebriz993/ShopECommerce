using AutoMapper;
using ShopECommerce.BusinessLogic.Dtos.Categories;
using ShopECommerce.BusinessLogic.Dtos.ProductsDtos;
using ShopECommerce.DataAccessLayer.Abstract.Commons;
using ShopECommerce.Entity.Concrete.Common;
using ShopECommerce.Service;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopECommerce.BusinessLogic.Concrete
{
    public class ProductService : IProductService
    {
        private readonly IProductsRepository _productRepository;
        private readonly ICategoriesRepository _categoriesRepository;
        private readonly IMapper _mapper;

        public ProductService(IProductsRepository productRepository,
                              ICategoriesRepository categoriesRepository,
                              IMapper mapper)
        {
            _productRepository = productRepository;
            _categoriesRepository = categoriesRepository;
            _mapper = mapper;
        }

        public async Task AddProducts(ProductAddDto productAddDto)
        {
            await _productRepository.AddAsync(_mapper.Map<Products>(productAddDto));
        }

        public async Task<IEnumerable<ProductViewDto>> GetAllProducts(int? categoryId)
        {
            var productList = await _productRepository.GetProducts(categoryId);
            return _mapper.Map<IEnumerable<ProductViewDto>>(productList);
        }

        public async Task<IEnumerable<CategoriesViewDto>> GetAllCategories()
        {
            var categoryList = await _categoriesRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<CategoriesViewDto>>(categoryList);
        }
    }
}
