using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using YourDeal.DTOs;

namespace YourDeal.Interfaces
{
    public interface IFarmHouseServices : IApplicationService
    {
        Task<IActionResult> GetFarmHouseAsync();
        Task<IActionResult> GetFarmHouseByIdAsync(Guid id);
        Task<IActionResult> CreateFarmHouseAsync(PropDTO Prop);
        Task<IActionResult> DeleteFarmHouseAsync(Guid id);
        Task<IActionResult> UpdateFarmHouseAsync(Guid id, PropDTO Prop);
    }
}
