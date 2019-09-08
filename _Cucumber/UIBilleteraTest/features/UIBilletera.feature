
Feature: Realizar un Ingreso Automatizado
 Como Usuario Final (humano)
 Quiero realizar un ingreso y ver el saldo de la billetera

 Scenario: Se ingresan los datos correctos y se muestra el saldo
  Given Se realiza el ingreso de "150"
   When Navego a la pagina principal 
    And Introduzco el importe en el campo ingreso
    And Hacer click en el boton Procesar de los ingresos
   Then Se debe mostrar el saldo de "150"