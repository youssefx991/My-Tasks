import {IParent} from '../interfaces/IParent.js'
export class Parent implements IParent{
    name:string="parent class"
    printName(): string {
        return this.name
    }
}