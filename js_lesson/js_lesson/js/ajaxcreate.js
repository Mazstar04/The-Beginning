

var a = 4;

let c = 6;
 const b = 5;


function add(a, d) {
    let z = a + d;
    console.log(z);
}
add(a,c);


class person{
    constructor(name,age,sex,height){
        this.name = name;
        this.age = age;
        this.sex = sex;
        this.height = height;
    }
    move() {
        console.log("i'm moving");
    }
    eat() {
        console.log("i'm eating");
    }

}
class student extends person{

}


let anonymous = function(specifiednumber){
   if(specifiednumber>19){
       let diff = specifiednumber-19;
       let result = 3*diff;
       return result;
   }
   else{
       console.log("number is lesser than 19")
   }
}