using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using YourDeal.DTOs;

namespace YourDeal.Interfaces
{
    public interface IResortServices : IApplicationService
    {
        Task<IActionResult> GetResortAsync();
        Task<IActionResult> GetResortByIdAsync(Guid id);
        Task<IActionResult> CreateResortAsync(PropDTO Prop);
        Task<IActionResult> DeleteResortAsync(Guid id);
        Task<IActionResult> UpdateResortAsync(Guid id, PropDTO Prop);
    }
}
