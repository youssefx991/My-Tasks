
let obj = {
    name: "N/A",
    address: "N/A",
    age: 30
}


let handler = {
    set(target, prop, value) {
        console.log(`Setting property: ${prop} to value: ${value}`);
        if (!target.hasOwnProperty(prop))
            throw new Error(`Property ${prop} does not exist on this object.`);
        target[prop] = value
    },

    get(target, prop) {
        console.log(`Accessing property: ${prop}`);
        if (!target.hasOwnProperty(prop))
            throw new Error(`Property ${prop} does not exist on this object.`);
        return target[prop]
    },

    deleteProperty(target, prop) {
        console.log(`Deleting property: ${prop}`);
        if (!target.hasOwnProperty(prop))
            throw new Error(`Property ${prop} does not exist on this object.`);
        return delete target[prop]
    },

    defineProperty(target, prop, descriptor) {
        console.log(`Defining property: ${prop} with descriptor:`, descriptor);
        if (!target.hasOwnProperty(prop))
            throw new Error(`Property ${prop} does not exist on this object.`);
        return Object.defineProperty(target, prop, descriptor)
    },

    ownKeys(target) {
        console.log('Listing own keys of the object');
        return Object.keys(target)
    },

    has(target, prop) {
        console.log(`Checking existence of property: ${prop}`); 
        return target.hasOwnProperty(prop)
    },

}
let proxy = new Proxy(obj, handler);

// example usage
console.log("=====Testing Set===== \n\n")
proxy.name = 'youssef'
proxy.address = 'my address'
proxy.age = 24

console.log("\n=====Testing Get===== \n\n")
console.log(proxy.name)
console.log(proxy.address)
console.log(proxy.age)

console.log("\n=====Testing Delete===== \n\n")
delete proxy.age

console.log("\n=====Testing Define Property===== \n\n")
Object.defineProperty(proxy, 'name', { writable: false })


console.log("\n=====Testing Own Keys===== \n\n")
console.log(Object.keys(proxy))


console.log("\n=====Testing Has===== \n\n")
console.log('name' in proxy)
console.log('age' in proxy)



