using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp;
using Volo.Abp.Application.Services;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using YourDeal.DTOs;
using YourDeal.Interfaces;

namespace YourDeal.PropServices
{
    public class FlatService : ApplicationService, IFlatServices, ITransientDependency
    {
        private readonly IRepository<PropModel, Guid> _flatRepository;
        public FlatService(IRepository<PropModel, Guid> propRepository)
        {
            _flatRepository = propRepository;
        }

        public async Task<IActionResult> CreateFlatAsync(PropDTO Prop)
        {
            try
            {
                Prop.Catogary = "Flat";
                Prop.Id = Guid.NewGuid();
                var PropMappedObject = ObjectMapper.Map<PropDTO, PropModel>(Prop);
                var Propobj = await this._flatRepository.InsertAsync(PropMappedObject);
                return new OkObjectResult(Propobj);
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(ex.Message);
            }
        }

        public async Task<IActionResult> DeleteFlatAsync(Guid id)
        {
            await this._flatRepository.DeleteAsync(id);
            return new OkResult();
        }

        public async Task<IActionResult> GetFlatAsync()
        {
            var PropObj = await this._flatRepository.GetListAsync();
            var filteredProps = PropObj.Where(prop => prop.Catogary == "Flat").ToList();
            return new OkObjectResult(filteredProps);
        }

        public async Task<IActionResult> GetFlatByIdAsync(Guid id)
        {
            var PropObj = await this._flatRepository.GetAsync(id);
            return new OkObjectResult(PropObj);
        }

        public async Task<IActionResult> UpdateFlatAsync(Guid id, PropDTO Prop)
        {
            try
            {
                var PropObj = await this._flatRepository.FindAsync(Prop.Id);
                if (PropObj != null)
                {
                    ObjectMapper.Map<PropDTO, PropModel>(Prop, PropObj);
                    var PropReturnObj = await this._flatRepository.UpdateAsync(PropObj);
                    return new OkObjectResult(PropReturnObj);
                }
                else
                {
                    return new BadRequestResult();
                }
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(ex.Message);
            }
        }
    }
}
