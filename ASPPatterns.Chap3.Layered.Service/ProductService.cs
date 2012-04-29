using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ASPPatterns.Chap3.Layered.Service
{
    public class ProductService
    {
        private Model.ProductService _productService;

        public ProductService(Model.ProductService productService)
        {
            _productService = productService;
        }

        public ProductListResponse GetAllProductsFor(ProductListRequest productListRequest)
        {
            ProductListResponse productListResponse = new ProductListResponse();

            try
            {
                IList<Model.Product> productEntities = _productService.GetAllProductsFor(productListRequest.CustomerType);
                productListResponse.Products = productEntities.ConvertToProductListViewModel();
                productListResponse.Sucess = true;
            }
            catch (Exception ex)
            {
                // Log the exception..
                productListResponse.Sucess = false;
                // Return a friendly error message
                productListResponse.Message = "An error occurred";
            }
            return productListResponse;
        }
    }
}
