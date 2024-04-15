using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using YourDeal.DTOs;
using YourDeal.Interfaces;

namespace YourDeal.PropServices
{
    public class HouseService : ApplicationService, IHouseServices
    {
        private readonly IRepository<PropModel, Guid> _propRepository;
        public HouseService(IRepository<PropModel, Guid> propRepository)
        {
            _propRepository = propRepository;
        }
        public async Task<IActionResult> CreateHouseAsync(PropDTO Prop)
        {
            try
            {
                Prop.Catogary = "House";
                Prop.Id = Guid.NewGuid();
                var PropMappedObject = ObjectMapper.Map<PropDTO, PropModel>(Prop);
                var Propobj = await this._propRepository.InsertAsync(PropMappedObject);
                return new OkObjectResult(Propobj);
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(ex.Message);
            }
        }

        public async Task<IActionResult> DeleteHouseAsync(Guid id)
        {
            await this._propRepository.DeleteAsync(id);
            return new OkResult();
        }

        public async Task<IActionResult> GetHouseAsync()
        {
            var PropObj = await this._propRepository.GetListAsync();
            var filteredProps = PropObj.Where(prop => prop.Catogary == "House").ToList();
            return new OkObjectResult(filteredProps);
        }

        public async Task<IActionResult> GetHouseByIdAsync(Guid id)
        {
            var PropObj = await this._propRepository.GetAsync(id);
            return new OkObjectResult(PropObj);
        }

        public async Task<IActionResult> UpdateHouseAsync(Guid id, PropDTO Prop)
        {
            try
            {
                var PropObj = await this._propRepository.FindAsync(Prop.Id);
                if (PropObj != null)
                {
                    ObjectMapper.Map<PropDTO, PropModel>(Prop, PropObj);
                    var PropReturnObj = await this._propRepository.UpdateAsync(PropObj);
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
