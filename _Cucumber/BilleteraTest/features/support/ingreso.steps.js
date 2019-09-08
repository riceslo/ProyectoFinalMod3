
const { Given, When, Then } = require('cucumber')
const { expect } = require('chai')
const httpClient = require('request-promise')

let jSONOBJECTS = {};
let jSONOBJECTSRESP = undefined;

Given('Ingreso el monto de {int} a la billetera', function (ingreso) {
    // Write code here that turns the phrase above into concrete actions
    jSONOBJECTS = {
        valor: ingreso
      };
});

When('Preparo el JSON de los datos', function () {
    // Write code here that turns the phrase above into concrete actions
    console.log('DONE');
    httpOptions = {
      method: 'POST',
      uri: 'http://localhost:44324/Billetera.aspx/Ingreso',
      json: true,
      body: jSONOBJECTS,
      resolveWithFullResponse: true
    };
});

Then('Hago un request POST hacia el url ingreso con los datos', async function () {
    // Write code here that turns the phrase above into concrete actions
    await httpClient(httpOptions)
    .then(function(response) {
        jSONOBJECTSRESP = response;
    })
    .catch(function(error) {
        jSONOBJECTSRESP = error;
    });
});

Then('Recibo una respuesta con http status {int}', function (status) {
    // Write code here that turns the phrase above into concrete actions
    expect(jSONOBJECTSRESP.statusCode).to.eql(status);
});

