﻿using RealEstateManager.Database.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstateManager.DataAccess.Repositories.Contracts
{
    public interface IPropertyRepository
    {
        IEnumerable<Property> GetAll();
        Property GetByID(int id);
        Property Add(Property property);
    }
}
