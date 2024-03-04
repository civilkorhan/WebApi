using Business.Abstract;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using DataAcces.Abstract;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes;

public class BrandManager : IBrandService
{
   private readonly IBrandDal _brandDal;  //dependecy enjection yapıldı

    public BrandManager(IBrandDal brandDal)
    {
        _brandDal = brandDal;
    }

    public CreatedBrandsResponse Add(CreatBrandRequest creatbrandrequest)
    {
        // business rules kontrol yapıldı uygunsa
        Brand brand = new();  // veri tabanındaki nesnemi parametreme çevirdim bu olaya mapping denir
        // mapping alanları birbirine eşitler ama bunu sürekli biz yazmayız automapping kütüphanesi var
        brand.Name=creatbrandrequest.Name;
        brand.CreatedDate=DateTime.Now;
        _brandDal.Add(brand);
        
        CreatedBrandsResponse createdBrandsResponse = new CreatedBrandsResponse();
        createdBrandsResponse.Id = 4;
        createdBrandsResponse.Name = brand.Name;
        createdBrandsResponse.CreatedDate=brand.CreatedDate;

        return createdBrandsResponse;   

    }

    public List<GetAllBrandsResponse> GetAll()
    {
        
        List<Brand>brands=_brandDal.GetAll();  // VERİ TABANINDAKİ HALİ
        List<GetAllBrandsResponse>GetAllBrandsResponses=new List<GetAllBrandsResponse>();  //bizim kullanıcıya vereceğimiz hali
        foreach (var Brand in brands)
        {
            GetAllBrandsResponse getAllBrandsResponse = new GetAllBrandsResponse();
            getAllBrandsResponse.Id = Brand.Id;
            getAllBrandsResponse.Name = Brand.Name;
            getAllBrandsResponse.CreatedDate=Brand.CreatedDate;

            GetAllBrandsResponses.Add(getAllBrandsResponse);
        }
        return GetAllBrandsResponses;    
    }
}
