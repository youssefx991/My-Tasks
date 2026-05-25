// function disName(): string {
//   return "dddd";
// }
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
// console.log(disName());
function Logger(c) {
    console.log("this is class", c.name);
}
function ReadOnly(target, key) {
    console.log("target", target);
    console.log("key", key);
    // target {}
    // key stdName
    Object.defineProperty(target, key, {
        writable: false,
    });
}
// @Logger
class Student {
    constructor(name) {
        this.stdName = "ali";
        this.stdName = name;
    }
}
__decorate([
    ReadOnly
], Student.prototype, "stdName", void 0);
const std = new Student("ahmed");
std.stdName = "hosam";
console.log(std);
export {};
//# sourceMappingURL=main.js.map