import { RestService, Rest } from '@abp/ng.core';
import { Injectable } from '@angular/core';
import type { PropDTO } from '../dtos/models';
import type { IActionResult } from '../microsoft/asp-net-core/mvc/models';

@Injectable({
  providedIn: 'root',
})
export class VillaService {
  apiName = 'Default';
  

  createVilla = (Prop: PropDTO, config?: Partial<Rest.Config>) =>
    this.restService.request<any, IActionResult>({
      method: 'POST',
      url: '/api/app/villa/villa',
      body: Prop,
    },
    { apiName: this.apiName,...config });
  

  deleteVilla = (id: string, config?: Partial<Rest.Config>) =>
    this.restService.request<any, IActionResult>({
      method: 'DELETE',
      url: `/api/app/villa/${id}/villa`,
    },
    { apiName: this.apiName,...config });
  

  getVilla = (config?: Partial<Rest.Config>) =>
    this.restService.request<any, IActionResult>({
      method: 'GET',
      url: '/api/app/villa/villa',
    },
    { apiName: this.apiName,...config });
  

  getVillaById = (id: string, config?: Partial<Rest.Config>) =>
    this.restService.request<any, IActionResult>({
      method: 'GET',
      url: `/api/app/villa/${id}/villa-by-id`,
    },
    { apiName: this.apiName,...config });
  

  updateVilla = (id: string, Prop: PropDTO, config?: Partial<Rest.Config>) =>
    this.restService.request<any, IActionResult>({
      method: 'PUT',
      url: `/api/app/villa/${id}/villa`,
      body: Prop,
    },
    { apiName: this.apiName,...config });

  constructor(private restService: RestService) {}
}
