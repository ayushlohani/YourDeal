using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using YourDeal.DTOs;

namespace YourDeal.Interfaces
{
    public interface IVillaServices : IApplicationService
    {
        Task<IActionResult> GetVillaAsync();
        Task<IActionResult> GetVillaByIdAsync(Guid id);
        Task<IActionResult> CreateVillaAsync(PropDTO Prop);
        Task<IActionResult> DeleteVillaAsync(Guid id);
        Task<IActionResult> UpdateVillaAsync(Guid id,PropDTO Prop);
    }
}
