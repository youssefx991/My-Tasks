// function disName(): string {
//   return "dddd";
// }

// console.log(disName());

function Logger(c: any) {
  console.log("this is class", c.name);
}

function ReadOnly(target: any, key: any) {
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
  @ReadOnly
  stdName = "ali";
  constructor(name: string) {
    this.stdName = name;
  }
}

const std = new Student("ahmed");
std.stdName = "hosam";
console.log(std);
