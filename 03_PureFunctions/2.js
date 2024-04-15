// 2. Pure Functionssssssssssssss

let cartItems = [];

function addToCartImpure(item) {
    cartItems.push(item);
    return cartItems;
}

function multiplyWithRandomImpure(number) {
    const randomValue = Math.random();
    return number * randomValue;
}

function printAndReturnStringImpure(str) {
    console.log(str);
    return str;
}


function addToCartPure(cartItems, item) {
    return [...cartItems, item];
}

function multiplyWithRandomPure(number, randomValue) {
    return number * randomValue;
}

function returnStringPure(str) {
    return str;
}


const initialCartItems = [];
const cartAfterApple = addToCartPure(initialCartItems, 'Apple');
const cartAfterBanana = addToCartPure(cartAfterApple, 'Banana');
console.log(cartAfterBanana);

const randomNumber = Math.random();
console.log(multiplyWithRandomPure(5, randomNumber));

console.log(returnStringPure("Hello"));
