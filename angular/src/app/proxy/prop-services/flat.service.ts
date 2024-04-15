import { RestService, Rest } from '@abp/ng.core';
import { Injectable } from '@angular/core';
import type { PropDTO } from '../dtos/models';
import type { IActionResult } from '../microsoft/asp-net-core/mvc/models';

@Injectable({
  providedIn: 'root',
})
export class FlatService {
  apiName = 'Default';
  

  createFlat = (Prop: PropDTO, config?: Partial<Rest.Config>) =>
    this.restService.request<any, IActionResult>({
      method: 'POST',
      url: '/api/app/flat/flat',
      body: Prop,
    },
    { apiName: this.apiName,...config });
  

  deleteFlat = (id: string, config?: Partial<Rest.Config>) =>
    this.restService.request<any, IActionResult>({
      method: 'DELETE',
      url: `/api/app/flat/${id}/flat`,
    },
    { apiName: this.apiName,...config });
  

  getFlat = (config?: Partial<Rest.Config>) =>
    this.restService.request<any, IActionResult>({
      method: 'GET',
      url: '/api/app/flat/flat',
    },
    { apiName: this.apiName,...config });
  

  getFlatById = (id: string, config?: Partial<Rest.Config>) =>
    this.restService.request<any, IActionResult>({
      method: 'GET',
      url: `/api/app/flat/${id}/flat-by-id`,
    },
    { apiName: this.apiName,...config });
  

  updateFlat = (id: string, Prop: PropDTO, config?: Partial<Rest.Config>) =>
    this.restService.request<any, IActionResult>({
      method: 'PUT',
      url: `/api/app/flat/${id}/flat`,
      body: Prop,
    },
    { apiName: this.apiName,...config });

  constructor(private restService: RestService) {}
}
