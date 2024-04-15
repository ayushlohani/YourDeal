using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using YourDeal.DTOs;

namespace YourDeal.Interfaces
{
    public interface IFlatServices : IApplicationService
    {
        Task<IActionResult> GetFlatAsync();
        Task<IActionResult> GetFlatByIdAsync(Guid id);
        Task<IActionResult> CreateFlatAsync(PropDTO Prop);
        Task<IActionResult> DeleteFlatAsync(Guid id);
        Task<IActionResult> UpdateFlatAsync(Guid id, PropDTO Prop);
    }
}
