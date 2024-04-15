import { NgModule } from '@angular/core';
import { SharedModule } from '../shared/shared.module';
import { HomeRoutingModule } from './home-routing.module';
import { HomeComponent } from './home.component';
import { HttpClientModule } from '@angular/common/http';
import { PageComponent } from '@abp/ng.components/page';

@NgModule({
  declarations: [HomeComponent],
  imports: [SharedModule, HomeRoutingModule,HttpClientModule],
})
export class HomeModule {}
