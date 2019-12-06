using AnyPos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnyPos.POSApi
{
    public partial class ApiClient
    {
        private string productAPIEndPoint = "http://localhost:8080/api/Products";


        public async Task<List<ProductModel>> GetProducts()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                 ""));
            return await GetAsync<List<ProductModel>>(requestUrl);
        }

    }
}
