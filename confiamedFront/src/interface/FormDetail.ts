import { Form } from './Form';
export interface FormDetail{
    id:number;
    type:number;
    name:string;
}

export interface FormAndDetail{

    form:Form;
    details:FormDetail[]
}