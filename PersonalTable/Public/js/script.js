
import swal from 'sweetalert';


var form = document.getElementById("form-container");
var imgDiv = document.getElementById("img-container");
var focus = document.getElementsByClassName("focus-div");


function Opacity(){
imgDiv.style.opacity ="0";
imgDiv.style.zIndex = "0"
form.style.opacity = "1"
form.style.Zindex="10"



}
function Alert() {
   
    Swal.fire(
        'Good job!',
        'You clicked the button!',
        'success'
    )
}


$(document).ready(function () {
    $('#person').validate({ 
        rules: {
            Name: {
                required: true

            }
          
        },

        messages: {
            Name: {
                required: "Boş qoyula bilməz !"
            }
           
        }
    })
})