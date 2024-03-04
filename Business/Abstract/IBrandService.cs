﻿using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract;

public interface IBrandService
{
   CreatedBrandsResponse  Add(CreatBrandRequest brand);
    List<GetAllBrandsResponse> GetAll();
    // response and request
}
