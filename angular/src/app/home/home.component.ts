import { AuthService } from '@abp/ng.core';
import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

//url:-https://localhost:44315/api/app/all-prop

@Component({
  selector: 'root-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss'],
})
export class HomeComponent implements OnInit{
  
  public getJsonValue:any;
  public postJsonValue:any;
  hasLoggedIn: any;
  v_name : String;
  constructor(private http:HttpClient) {}
  ngOnInit(): void {
    this.getMethod();
    //this.postMethod();
  }
  public getMethod(){
    this.http.get('https://localhost:44315/api/app/all-prop').subscribe((res)=>{
      this.getJsonValue=res
      console.log(res);
    })
  }
  public create(nam:string,c : string,img_u:string,o_name:string,o_p:string,sqt:string,paisa:number,cty:string,stat:string,coun:string,des:string):void{
    this.postMethod(nam,c,img_u,o_name,o_p,sqt,paisa,cty,stat,coun,des);
  }
  public postMethod(nam:string,c : string,img_u:string,o_name:string,o_p:string,sqt:string,paisa:number,cty:string,stat:string,coun:string,des:string){
    let body={
      "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
      "name": nam,
      "catogary": c,
      "status": "string",
      "imageUrl":img_u,
      "ownerName": o_name,
      "ownerPhoneNo": o_p,
      "sqft": sqt,
      "price": paisa,
      "city": cty,
      "state": stat,
      "country": coun,
      "description": des
    }
    this.http.post('https://localhost:44315/api/app/all-prop',body).subscribe((res)=>{
      this.postJsonValue=this.postJsonValue.concat(res);
      console.log(res);
    })
  }
  public delete(ide:string):void{
    this.http.delete(`https://localhost:44315/api/app/all-prop/${ide}`).subscribe(()=>{
      this.getJsonValue=this.getJsonValue.filter(item=>item.id!==ide);
    })
  }
  public role:any;
  reload(){
    
  }
  
}
