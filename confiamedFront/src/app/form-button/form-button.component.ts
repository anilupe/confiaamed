import { Component, Input, OnInit } from '@angular/core';
import { Form } from '../../interface/Form';
import { FormDetail, FormAndDetail } from '../../interface/FormDetail';


@Component({
  selector: 'app-form-button',
  templateUrl: './form-button.component.html',
  styleUrls: ['./form-button.component.scss']
})
export class FormButtonComponent implements OnInit {

  @Input() listForm :Form[]=[];
  @Input() data : FormAndDetail[]=[];
  details:FormDetail[]=[];
  constructor() { }

  ngOnInit(): void {
  }
  showFields(id:number){

    var item = this.data.find(c=>c.form.id==id)?.details;

    console.log(item,id)
    item?.forEach(c=>{
      this.details.push({id:c.id,name:c.name,type:c.type})
    })
  }

}
