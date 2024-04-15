import { RestService, Rest } from '@abp/ng.core';
import { Injectable } from '@angular/core';
import type { PropDTO } from '../dtos/models';
import type { IActionResult } from '../microsoft/asp-net-core/mvc/models';

@Injectable({
  providedIn: 'root',
})
export class HouseService {
  apiName = 'Default';
  

  createHouse = (Prop: PropDTO, config?: Partial<Rest.Config>) =>
    this.restService.request<any, IActionResult>({
      method: 'POST',
      url: '/api/app/house/house',
      body: Prop,
    },
    { apiName: this.apiName,...config });
  

  deleteHouse = (id: string, config?: Partial<Rest.Config>) =>
    this.restService.request<any, IActionResult>({
      method: 'DELETE',
      url: `/api/app/house/${id}/house`,
    },
    { apiName: this.apiName,...config });
  

  getHouse = (config?: Partial<Rest.Config>) =>
    this.restService.request<any, IActionResult>({
      method: 'GET',
      url: '/api/app/house/house',
    },
    { apiName: this.apiName,...config });
  

  getHouseById = (id: string, config?: Partial<Rest.Config>) =>
    this.restService.request<any, IActionResult>({
      method: 'GET',
      url: `/api/app/house/${id}/house-by-id`,
    },
    { apiName: this.apiName,...config });
  

  updateHouse = (id: string, Prop: PropDTO, config?: Partial<Rest.Config>) =>
    this.restService.request<any, IActionResult>({
      method: 'PUT',
      url: `/api/app/house/${id}/house`,
      body: Prop,
    },
    { apiName: this.apiName,...config });

  constructor(private restService: RestService) {}
}
