import { Component, OnInit } from '@angular/core';
import { FormService } from './services/form.service';
import { FormAndDetail } from '../interface/FormDetail';
import { Form } from 'src/interface/Form';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit{
  title = 'Confiamed';
listform:Form[]=[];
data:FormAndDetail[]=[];


  constructor(
    private _formservice:FormService
  ) {
    
  }
  ngOnInit(){
    
    this._formservice.get().subscribe(data=>{
     
   this.generateForm(data);
    })
  }
  generateForm(data:FormAndDetail[]){
    data.forEach(value=>{
      console.log(value)
      this.listform.push({id:value.form.id,name:value.form.name})
    })
  }
}
