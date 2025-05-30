﻿using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface ICompanyRepository
    {
        IEnumerable<Company> GetAllCompanies(bool trackChanges);
        Company GetCompany(Guid companyId, bool trackChanges);
        void CreateCompany(Company company);
        IEnumerable<Company> GetByIds(IEnumerable<Guid> ids, bool trackChanges);
        void DeleteCompany(Company company);
    }

}
