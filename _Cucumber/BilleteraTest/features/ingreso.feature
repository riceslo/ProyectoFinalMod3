Feature: Prueba Ingresos en la billetera
  Como un cliente de SITIO WEB (no humano)
  Registrar un ingresos en la billetera
  Scenario: Ingreso a la Billetera
    Given Ingreso el monto de 50 a la billetera
    When Preparo el JSON de los datos
    Then Hago un request POST hacia el url ingreso con los datos
    Then Recibo una respuesta con http status 201