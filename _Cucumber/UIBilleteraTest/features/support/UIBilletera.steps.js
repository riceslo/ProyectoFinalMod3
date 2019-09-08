require('chromedriver');
const { Given, When, Then } = require('cucumber')
const { expect } = require('chai')
const { Builder, By, Key, until } = require('selenium-webdriver');


let _ingreso = 0;
let chromeDriver = undefined;

Given('Se realiza el ingreso de {string}', function (importe) {
    // Write code here that turns the phrase above into concrete actions
    _ingreso = importe;
});


When('Navego a la pagina principal', async function () {
// Write code here that turns the phrase above into concrete actions
    chromeDriver = await new Builder().forBrowser('chrome').build();
    await chromeDriver.get('http://localhost:44324/Billetera');
});

When('Introduzco el importe en el campo ingreso', async function () {
// Write code here that turns the phrase above into concrete actions
    await chromeDriver.findElement(By.name('ctl00$MainContent$txtIngreso')).sendKeys(_ingreso);
});         

When('Hacer click en el boton Procesar de los ingresos', async function () {
// Write code here that turns the phrase above into concrete actions
await chromeDriver.findElement(By.id('MainContent_lbtIngreso')).click();
});

Then('Se debe mostrar el saldo de {string}', async function (expected) {
// Write code here that turns the phrase above into concrete actions
    await chromeDriver.findElement(By.id('MainContent_spnSaldo'))
        .getText().then(function (text) {
        showText = text;
    });

    expect(showText).to.eql(expected);
    await chromeDriver.quit();
});          
         