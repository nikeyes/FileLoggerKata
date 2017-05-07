# FileLoggerKata
https://github.com/ardalis/kata-catalog/blob/master/katas/File%20Logger.md

Usando TDD con commit por cada BabyStep.  

Para hacer emerger el diseño he usado tests unitarios con un "Doble".  
En este ejercicio y desde mi punto de vista, los test unitarios solo sirven para hacer emerger el diseño.  
Después deberían convertirse en tests de integración para validar que nuestro código hace lo que realmente tiene que hacer.

He decidido utilizar un objeto Fake por la sencillez del objeto a "Doblar" (cada método tiene 1 linea).  
Con un framework de Mocks el setup de los métodos también me hubiera costado 1 linea por método, pero con una sintaxis menos clara. 

He utilizado los tests unitarios con un MemoryLogger para diseñar el contrato que necesito.  
Para validar que el diseño y la funcionalidad son correctos, he implementado un FileLogger real (https://github.com/nikeyes/FileLoggerKata/commit/59627bae9342f11333699ae4c6bf0f891b108008) y he convertido lo tests unitarios en tests de integración con solo cambiar el **new del MemoryLogger** por un **new de un FileLogger** en el TestInitialize.


Terminado el paso 3....
