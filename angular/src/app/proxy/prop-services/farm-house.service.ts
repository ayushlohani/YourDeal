import { RestService, Rest } from '@abp/ng.core';
import { Injectable } from '@angular/core';
import type { PropDTO } from '../dtos/models';
import type { IActionResult } from '../microsoft/asp-net-core/mvc/models';

@Injectable({
  providedIn: 'root',
})
export class FarmHouseService {
  apiName = 'Default';
  

  createFarmHouse = (Prop: PropDTO, config?: Partial<Rest.Config>) =>
    this.restService.request<any, IActionResult>({
      method: 'POST',
      url: '/api/app/farm-house/farm-house',
      body: Prop,
    },
    { apiName: this.apiName,...config });
  

  deleteFarmHouse = (id: string, config?: Partial<Rest.Config>) =>
    this.restService.request<any, IActionResult>({
      method: 'DELETE',
      url: `/api/app/farm-house/${id}/farm-house`,
    },
    { apiName: this.apiName,...config });
  

  getFarmHouse = (config?: Partial<Rest.Config>) =>
    this.restService.request<any, IActionResult>({
      method: 'GET',
      url: '/api/app/farm-house/farm-house',
    },
    { apiName: this.apiName,...config });
  

  getFarmHouseById = (id: string, config?: Partial<Rest.Config>) =>
    this.restService.request<any, IActionResult>({
      method: 'GET',
      url: `/api/app/farm-house/${id}/farm-house-by-id`,
    },
    { apiName: this.apiName,...config });
  

  updateFarmHouse = (id: string, Prop: PropDTO, config?: Partial<Rest.Config>) =>
    this.restService.request<any, IActionResult>({
      method: 'PUT',
      url: `/api/app/farm-house/${id}/farm-house`,
      body: Prop,
    },
    { apiName: this.apiName,...config });

  constructor(private restService: RestService) {}
}
