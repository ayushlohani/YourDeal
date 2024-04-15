import { RestService, Rest } from '@abp/ng.core';
import { Injectable } from '@angular/core';
import type { PropDTO } from '../dtos/models';
import type { IActionResult } from '../microsoft/asp-net-core/mvc/models';

@Injectable({
  providedIn: 'root',
})
export class ResortService {
  apiName = 'Default';
  

  createResort = (Prop: PropDTO, config?: Partial<Rest.Config>) =>
    this.restService.request<any, IActionResult>({
      method: 'POST',
      url: '/api/app/resort/resort',
      body: Prop,
    },
    { apiName: this.apiName,...config });
  

  deleteResort = (id: string, config?: Partial<Rest.Config>) =>
    this.restService.request<any, IActionResult>({
      method: 'DELETE',
      url: `/api/app/resort/${id}/resort`,
    },
    { apiName: this.apiName,...config });
  

  getResort = (config?: Partial<Rest.Config>) =>
    this.restService.request<any, IActionResult>({
      method: 'GET',
      url: '/api/app/resort/resort',
    },
    { apiName: this.apiName,...config });
  

  getResortById = (id: string, config?: Partial<Rest.Config>) =>
    this.restService.request<any, IActionResult>({
      method: 'GET',
      url: `/api/app/resort/${id}/resort-by-id`,
    },
    { apiName: this.apiName,...config });
  

  updateResort = (id: string, Prop: PropDTO, config?: Partial<Rest.Config>) =>
    this.restService.request<any, IActionResult>({
      method: 'PUT',
      url: `/api/app/resort/${id}/resort`,
      body: Prop,
    },
    { apiName: this.apiName,...config });

  constructor(private restService: RestService) {}
}
