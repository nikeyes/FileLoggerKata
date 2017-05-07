# FileLoggerKata
https://github.com/ardalis/kata-catalog/blob/master/katas/File%20Logger.md

Usando TDD con commit por cada BabyStep.

Terminado el paso 3.

He utilizado los tests unitarios con un MemoryLogger para diseñar la interfaz que necesito.
Para validar que el diseño es el correcto he implementado un FileLogger real (f6e3dae32ac8d1d5a8d87ff4417c1d2964c293a9) y he convertido lo tests unitarios en tests de integración cambiando el new del MemoryLogger por un FileLogger.
