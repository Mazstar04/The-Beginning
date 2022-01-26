var age = prompt("Please enter your Age");

            if (age == null || age < 18) {
                close();
            }
            else{
                window.alert('MazStar says Welcome!!😉😉😍😘');
         
            }

             function WhiteToBlack(){
           
            if (document.getElementById('white').style.backgroundColor == 'white')
            {
                document.getElementById('white').style.backgroundColor = 'black';
                document.getElementById('white').style.color = 'white';
                document.getElementById('btn').innerHTML = "Light Mode";
            }
            else
            {
                document.getElementById('white').style.backgroundColor = 'white';
                document.getElementById('white').style.color = 'black';
                document.getElementById('btn').innerHTML = "Dark Mode";
            }
        }

        // function dark(){
        //     document.getElementById('white').style.backgroundColor = 'black';
        //     document.getElementById('white').style.color = 'white';
        // }

        // function pink(){
        //     document.getElementById('white').style.backgroundColor = 'hotpink';
        //     document.getElementById('white').style.color = 'white';
        // }

        // function white(){
        //     document.getElementById('white').style.backgroundColor = 'white';
        //     document.getElementById('white').style.color = 'black';
        // }

        // function orchid(){
        //     document.getElementById('white').style.backgroundColor = 'orchid';
        //     document.getElementById('white').style.color = 'white';
        // }

        // function blue(){
        //     document.getElementById('white').style.backgroundColor = 'aqua';
        //     document.getElementById('white').style.color = 'white';
        // }

        function isEmail(email) {
            var pattern = /^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$/;
            if (email.match(pattern)) {
                return true;
            }
            return false;
        }

            function FormValidation() {
            let errors = [];
            let surname = document.getElementById('mysurname').value;
            let firstname = document.getElementById('myfirstname').value;
            let email = document.getElementById('myemail').value;
            let password = document.getElementById('mypassword').value;
            let confirmpswd = document.getElementById('confirmpass').value;
            let no = document.getElementById('myno').value;
            let age = document.getElementById('myage').value;
            let nationality = document.getElementById('mynationality').value;

            let checkEmail = isEmail(email);

            if (surname == "") {
                let message = "Surname Field is Empty";
                errors.push(message);

            }

            if (firstname == "") {
                let message = "Firstname Field is Empty";
                errors.push(message);

            }

            if (email == "" ) {
                let message = "Email field is Empty!";
                errors.push(message);

            }

            if (checkEmail === false) {
                let message = "email is invalid";
                errors.push(message);

            }

            if (password == "") {
                let message = "Make sure you set a password";
                errors.push(message);

            }

            if (confirmpswd == "") {
                let message = "Confirm your Password!!";
                errors.push(message);

            }

            if (password != confirmpswd) {
                let message = "Passwords do not Match!";
                errors.push(message);

            }

            if (no == "") {
                let message = "Telephone Field is Empty";
                errors.push(message);

            }

            if (no.length != 11 ) {
                let message = "Phone Number must not be greater or less than 11 digits!";
                errors.push(message);

            }
            
            if (age == "") {
                let message = "Input age!!";
                errors.push(message);

            }

            if (age < 18) {
                let message = "Underage!!";
                errors.push(message);

            }

            if (nationality == "") {
                let message = "Nationality Field is Empty";
                errors.push(message);

            }

            if (errors.length > 0) {
                alert(errors);
                return false;
            }
            return true;
        }