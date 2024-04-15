using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using YourDeal.DTOs;

namespace YourDeal.Interfaces
{
    public interface IAllPropServices : IApplicationService
    {
        Task<IActionResult> GetListAsync();
        //Task<List<PropDTO>> GetListAsync(); without action result further code is in Allpropservice
        Task<IActionResult> GetOtherCatogryAsync();
        Task<IActionResult> GetByIdAsync(Guid id);
        Task<IActionResult> CreateAsync(PropDTO Prop);
        Task<IActionResult> DeleteAsync(Guid id);
        Task<IActionResult> UpdateAsync(Guid id, PropDTO Prop);
    }
}
