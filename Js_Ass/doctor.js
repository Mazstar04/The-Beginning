var doctor = {
    lastname: "Hamzat",
    firstname: "Mazeedah",
    Age: 32,
    Address: "Kemta",
    Email: "mazeedahhamzat@gmail.com",
    displayDetails:function(){
        console.log(this.lastname);
        console.log(this.firstname);
    },
    addAge:function(){
        console.log(this.Age + 5);
    }
}

doctor.displayDetails();
doctor.addAge();