import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'YourDeal',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44315/',
    redirectUri: baseUrl,
    clientId: 'YourDeal_App',
    responseType: 'code',
    scope: 'offline_access YourDeal',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44315',
      rootNamespace: 'YourDeal',
    },
  },
} as Environment;
