import { AuthService } from '@abp/ng.core';
import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

//url:-https://localhost:44315/api/app/all-prop

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss'],
})
export class HomeComponent implements OnInit{
  
  public getJsonValue:any;
  public postJsonValue:any;
  constructor(private http:HttpClient) {}
  ngOnInit(): void {
    this.getMethod();
    //this.postMethod();
  }
  public getMethod(){
    this.http.get('https://localhost:44315/api/app/all-prop').subscribe((res)=>{
      this.getJsonValue=res;
      console.log(res);
    })
  }
  public create():void{
    this.postMethod();
  }
  public postMethod(){
    let body={
      "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
      "name": "string",
      "catogary": "string",
      "status": "string",
      "imageUrl":"../../assets/images/head-logo.png",
      "ownerName": "string",
      "ownerPhoneNo": "string",
      "sqft": 0,
      "price": 0,
      "city": "string",
      "state": "string",
      "country": "string",
      "description": "string"
    }
    this.http.post('https://localhost:44315/api/app/all-prop',body).subscribe((res)=>{
      this.postJsonValue=this.postJsonValue.concat(res);
      console.log(res);
    })
  }
  public role:any;
  
}
