let toplama = document.querySelector("#Toplama button")
let input1 = document.querySelector(".number1 input")
let input2 = document.querySelector(".number2 input")
toplama.onclick = function () {

    let invalue = Number(input1.value) + Number(input2.value);
    let input3 = document.querySelector(".netice input")
    input3.value = invalue;
}
let cixma = document.querySelector("#Cixma button")
cixma.onclick = function () {
    let resvalue = Number(input1.value) - Number(input2.value);
    let input3 = document.querySelector(".netice input")
    input3.value = resvalue;
}
let vurma = document.querySelector("#Vurma button")
vurma.onclick = function () {
    let resultval = Number(input1.value) * Number(input2.value);
    let input3 = document.querySelector(".netice input")
    input3.value = resultval;
}
let bolme=document.querySelector("#Bolme button")
bolme.onclick=function(){
    if(Number(input2.value)===0) {
        let input3 = document.querySelector(".netice input");
        input3.value = "Sifira bolme mumkun deyil";
    } else {
        let resultval = Number(input1.value) / Number(input2.value);
        let input3 = document.querySelector(".netice input");
        input3.value = resultval;
    }
}