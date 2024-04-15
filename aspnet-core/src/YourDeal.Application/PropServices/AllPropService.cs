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
    public class AllPropService : ApplicationService, IAllPropServices, ITransientDependency
    {
        private readonly IRepository<PropModel, Guid> _propRepository;
        public AllPropService(IRepository<PropModel, Guid> propRepository)
        {
            _propRepository = propRepository;
        }
        
        public async Task<IActionResult> CreateAsync(PropDTO Prop)
        {
            try
            {
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

        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            await this._propRepository.DeleteAsync(id);
            return new OkResult();
        }

        public async Task<IActionResult> GetListAsync()
        {
            var PropObj = await this._propRepository.GetListAsync();
            return new OkObjectResult(PropObj.ToList());
        }

        //can perform withour IActionResut
        //public async Task<List<PropDTO>> GetListAsync()
        //{
        //    var PropObj = await _propRepository.GetListAsync();
        //    var PropDTOList = ObjectMapper.Map<List<PropModel>, List<PropDTO>>(PropObj);
        //    return PropDTOList;
        //}

        public async Task<IActionResult> GetByIdAsync(Guid id)
        {
            var PropObj = await this._propRepository.GetAsync(id);
            return new OkObjectResult(PropObj);
        }

        public async Task<IActionResult> UpdateAsync(Guid id, PropDTO Prop)
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
        private bool IsexistingCatogary(string s)
        {
            return (s == "Flat" || s == "House" || s == "Resort" || s == "FarmHouse" || s == "Villa");
        }
        public async Task<IActionResult> GetOtherCatogryAsync()
        {
            var PropObj = await this._propRepository.GetListAsync();
            var filteredProps = PropObj.Where(prop => !IsexistingCatogary(prop.Catogary)).ToList();
            return new OkObjectResult(filteredProps.ToList());
        }
    }
}
