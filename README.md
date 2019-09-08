# ProyectoFinalMod3
PROYECTO FINAL - MÓDULO 3 – PRUEBAS DE SOFTWARE – QTESTING


Requerimientos
Para poder ejecutar el proyecto se necesita ejecutarlo bajo plataforma Windows, tener instalado NodeJS, Visual Studio 2019, Visual Studio Code 

NodeJS
Puede descargarlo en: https://nodejs.org/es/

Instale las dependencias del proyecto
Ejecute el siguiente comando:

npm install

0. «El unico requerimiento de usuario es la implementación de una billetera, la cual debe registrar ingresos y salidas, y en todo momento dar a conocer el saldo de la misma (estilo cuenta bancaria pero reducida)»

Para ejecutar la implementacion de la Billetera es necesario abrir con VS 2019 el archivo AppBilletera.sln, el cual contiene el proyecto AppBilletera/AppBilletera.csproj, este es un proyecto Web que ejecuta la aplicacion de la Billetera.

1. Implementar al menos 5 pruebas unitarias

Para la revision de las pruebas unitarias, es necesario abrir con VS 2019 el archivo AppBilletera.sln, el cual contiene el proyecto BilleteraTest/BilleteraTest.csproj, en este proyecto en la clase BilleteraTest/UnitTest1.cs  se encuentran las pruebas unitarias.

2. Escribir e implementar 2 pruebas de integración (uno de lectura y otro de escritura)

Para las pruebas de integracion, es necesario abrir con VS CODE la carpeta _ Cucumber/BilleteraTest/, en esta carpeta se encuenran los features de las pruebas de integracion.

Debe estar ejecutandose el proyecto de la Billetera para realizar las pruebas

Debe ejecutar
npm init

Instalar CucumberJS
npm i cucumber --save

Verificar instalación
./node_modules/.bin/cucumber-js

Instalar adicionalmente
npm i chai --save
npm i request --save
npm i request-promise --save

3. Describir e implementar una prueba de UI, donde se automatice el llenado de un formulario.

Para las pruebas de integracion, es necesario abrir con VS CODE la carpeta _ Cucumber/UIBilleteraTest/, en esta carpeta se encuenran los features de las pruebas de integracion.

Debe estar ejecutandose el proyecto de la Billetera para realizar las pruebas

Debe ejecutar
npm init

Instalar CucumberJS
npm i cucumber --save

Verificar instalación
./node_modules/.bin/cucumber-js

Instalar adicionalmente
npm i chai --save
npm i request --save
npm i request-promise --save
npm install selenium-webdriver --save
npm install chromedriver --global
