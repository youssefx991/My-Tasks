// // class Test{}
import { Parent } from "./models/Parent.js";
// //Basic Types
// let a1:number = 2
// // a1="str"
// // a1=true
// console.log(a1)
// let a2:string = "hello"
// a2 = "world"
// let a3:boolean = true
// // a3=2
// function check(arg:number):boolean{
//     if(arg>2)
//         return false
//     return true
// }
// let arr:number[] = [1,2,3]
// console.log(arr)
// // arr = ["5",2,3,4,5]
// function printArray(arr:number[]){
//     // console.log(arr)
//     arr.forEach(elem=>{
//         console.log(elem)
//     })
// }
// printArray(arr)
// // printArray(27)
// let myarr
// myarr = [1,2,3]
// myarr = 5
// myarr = "str"
// //Tuple
// let arr1:[number,number]=[1,2]
// //Object
// const user1:{name:string,age:number,address:string} = {
//     name:"ahmed",
//     age:20,
//     address:'123st'
// }
// console.log(user1.name)
// user1.name = "ali"
// console.log(user1.name)
// // console.log(user1.courses)//error
// // user1.salary = 10000
// function PrintUser(user:{name:string,age:number,address:string}){
//     return user.name
// }
// console.log(PrintUser(user1))
// // PrintUser(1)//error
// function add(arg1:number,arg2:number):number{
//     return arg1+arg2
// }
// function concate(arg1:string,arg2:string):string{
//     return arg1+arg2
// }
// function addConcate(arg1:string,arg2:string):string;
// function addConcate(arg1:number,arg2:number):number;
// function addConcate(arg1:any,arg2:any){
//     return arg1+arg2
// }
// console.log(addConcate(1,1))
// console.log(addConcate("str","str"))
// // console.log(addConcate("str",5))//error
// let x:string|number|boolean =1
// x=true
// x="xyz"
// // x={}
// type mytest = number|string|boolean
// let y :mytest
// y=5
// y=true
// type User = {
//     name:string
//     age:number
//     address:string
// }
// type permission={
//     permissionLevel:string
// }
// type UserMix = User&permission
// let u1:User={name:'',address:'',age:0}
// let u3:UserMix={address:'',age:0,name:'',permissionLevel:''}
// enum PerLeve{
//     student,
//     instructor="instructor",
//     admin="admin"
// }
// let p1:PerLeve=PerLeve.student
// p1 = "admin" as PerLeve
// console.log(p1)
// // p1=1
// // p1=2
// // p1=3
// // interface IUser{
// //     name:string
// //     age:number
// //     courses:string[]
// // }
// // interface IUserExtend extends IUser{
// //     permissionLevel:string
// // }
// // let u2:IUserExtend={
// //     name:'ali',
// //     age:20,
// //     courses:[],
// //     // address:"xyz"
// //     permissionLevel:''
// // }
// //tsc --watch file.ts
// function firstElement(arr:number[]){
//     return arr[0]
// }
// const arr2=[1,2,3]
// console.log(firstElement(arr2))
// function firstElement2(arr:string[]){
//     return arr[0]
// }
// const arr3=["hello","world"]
// console.log(firstElement2(arr3))
// function general_firstElement(arr:string[]):string;
// function general_firstElement(arr:number[]):number;
// function general_firstElement(arr:any[]){
//     return arr[0]
// }
// console.log(general_firstElement(arr2))
// console.log(general_firstElement(arr3))
// const arr4 = [true,false,false]
// // console.log(general_firstElement(arr4))
// function genaric_firstElement<T>(arr:T[]):T{
//     return arr[0]
// }
// let o1 = genaric_firstElement<number>(arr2)
// let o2 = genaric_firstElement<string>(arr3)
// const arr5 = [1,2,3,"str","test"]
// let o3 = genaric_firstElement<number|string>(arr5)
// function myfun<Input,output>(arr:Input[],func:(arg:Input)=>output){
//     return arr.map(func)
// }
// const mynewArr = ["hel",'world']
// let o4 = myfun<string,number>(mynewArr,elem=>elem.length)
// console.log(o4)
// const mydata = ["1","2","3"]
// console.log(myfun(mydata,n=>parseInt(n)))
// interface IsSized{
//     length:number
// }
// function lengthComparison<T extends IsSized>(a:T,b:T){
//     if(a.length>=b.length){
//         return a
//     }
//     return b
// }
// var arrr1=[1,2,3]
// var arrr2=[1,2,5,6,7]
// console.log(lengthComparison(arrr1,arrr2))
// // console.log(lengthComparison(1,2))
// type myUser={
//     users:string[]
//     length:number
// }
// const myuser1:myUser={
//     users:['a','b','c'],
//     length:3
// }
// const myuser2:myUser={
//     users:['a','b'],
//     length:2
// }
// console.log(lengthComparison(myuser1,myuser2))
// console.log(lengthComparison("hhhh",'xxxx'))
// interface IPerson{
//     readonly fname:string
//     lname:string
//     salary?:number
// }
// //Utilities
// let p2:Partial<IPerson>={
// }
// type RequiredIPerson = Required<IPerson>
// let p3:RequiredIPerson={
//     fname:'',
//     lname:'',
//     salary:0
// }
// // p2.salary=5
// // console.log(p2.salary)
// // p2.fname = 'test'
// // console.log(p2.fname)
// let p:Readonly<IPerson>={
//     fname:'ahmed',
//     lname:'mohamed',    
// }
// // p.fname = "xyz"
// console.log(p.fname)
// console.log(p.salary)
// let std1:Pick<IPerson,"fname"|"salary">={
//     fname:'ali',
//     // lname:''
// }
// let std2:Omit<IPerson,"salary">={
//     fname:'xyz',
//     lname:'abc'
// }
// std2.lname = "dfdsfd"
// type sections ="HR"|"Testing"|"Dev"
// let deptSec:sections ="HR"
// let deptSec2:Extract<sections,"HR"|"Testing">="HR"
// let deptSec3:Exclude<sections,"Testing">="Dev"
// type xyz = "HR"|"Dev"
/**-------------------------------------------------------------------------------- */
class Point2D {
    xPos;
    yPos;
    constructor(xpos = 0, ypos = 0) {
        this.xPos = xpos;
        this.yPos = ypos;
    }
    get YPos() {
        return this.yPos;
    }
    set YPos(value) {
        this.yPos = value;
    }
}
var p1 = new Point2D(1, 2);
console.log(p1);
// console.log(p1.xPos)
// console.log(p1.yPos)//error
console.log(p1.YPos);
class Point3D extends Point2D {
    zPos;
    constructor(xpos, ypos, zpos) {
        super(xpos, ypos);
        this.xPos = 0;
        this.zPos = zpos;
        Point3D.counter++;
    }
    display() {
        return `(x=${this.xPos} , y=${this.YPos},z=${this.zPos})`;
    }
    static counter = 0;
}
var p2 = new Point3D(1, 2, 3);
// console.log(p2.xPos)
console.log(p2.zPos);
var p3 = new Point3D(23, 33);
console.log(p3.display());
console.log(Point3D.counter);
// interface IInterview{
//     startTime?:string
//     endTime:string
//     printInterview():void
// }
class abstractInterview {
    startTime;
    endTime = "";
    constructor(st, ed) {
        this.startTime = st;
        this.endTime = ed;
    }
}
// class MyInterview implements IInterview{
class MyInterview extends abstractInterview {
    // startTime?: string | undefined
    // endTime!: string
    description = "";
    constructor(st, ed, des) {
        super(st, ed);
        this.description = des;
    }
}
class DataBox {
    content;
    constructor(_content) {
        this.content = _content;
    }
    print() {
        console.log(this.content);
    }
}
var d1 = new DataBox([1, 2, 3]);
d1.print();
var d2 = new DataBox("hello");
d2.print();
// var d3 = new DataBox(2)
// d3.print()
var myObj = new Parent();
console.log(myObj.name);
