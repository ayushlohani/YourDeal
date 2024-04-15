using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using YourDeal.DTOs;

namespace YourDeal.Interfaces
{
    public interface IHouseServices : IApplicationService
    {
        Task<IActionResult> GetHouseAsync();
        Task<IActionResult> GetHouseByIdAsync(Guid id);
        Task<IActionResult> CreateHouseAsync(PropDTO Prop);
        Task<IActionResult> DeleteHouseAsync(Guid id);
        Task<IActionResult> UpdateHouseAsync(Guid id, PropDTO Prop);
    }
}
