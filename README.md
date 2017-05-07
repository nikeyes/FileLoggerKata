# FileLoggerKata
https://github.com/ardalis/kata-catalog/blob/master/katas/File%20Logger.md

Usando TDD con commit por cada BabyStep.

Terminado el paso 3.

He utilizado los tests unitarios con un MemoryLogger para diseñar la interfaz que necesito.  
Para validar que el diseño es el correcto he implementado un FileLogger real (https://github.com/nikeyes/FileLoggerKata/commit/59627bae9342f11333699ae4c6bf0f891b108008) y he convertido lo tests unitarios en tests de integración cambiando el new del MemoryLogger por un FileLogger.
