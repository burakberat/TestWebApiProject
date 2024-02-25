using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IBrandService
    {
        CreatedBrandResponse Add(CreateBrandRequest createBrandRequest); // kullanıcıdan data isterken veritabanı nesnesi istemeyiz ve dönmeyiz.
        List<GetAllBrandResponse> GetAll();
    }
}
