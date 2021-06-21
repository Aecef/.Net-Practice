
function quoteAmountChange() {
    document.getElementById('q-counter').innerHTML = quoteAmount;
}
var currentDelete = 0;
function setDelete(quote) {
    currentDelete = quote;
}
function modalDelete() {
    quoteAmount -= 1;
    quoteAmountChange();
    deleteElement(currentDelete);
}

function deleteElement(number) {
    document.getElementById("card" + number).remove();
    document.getElementById("collapse" + number).innerHTML = "";
    document.getElementById("collapse" + number).remove();
    document.getElementById("heading" + number).remove();
}

new Sortable(document.getElementById("accordion"), {
    group: 'shared',
    animation: 150,
    ghostClass: 'bg-info'
})

function updateMonthly(quantityID) {
    var money = document.getElementById("quantity-"+quantityID).value;
    money = money * 327.24;
    document.getElementById("monthly-cost-" + quantityID).innerHTML = "Monthly: $" + money.toFixed(2) + "";
    document.getElementById("monthly-cost-a").innerHTML = "Monthly: $" + money.toFixed(2) + "";

}