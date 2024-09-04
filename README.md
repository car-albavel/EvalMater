# PRUEBA TÉCNICA DESARROLLADOR .NET SENIOR

En el siguiente proyecto encontrará una minimal api para gestionar las preguntas que se reflejarán en un examen de cualquier temática deseada. Se requiere qué, usando una arquitectura limpia, implemente los siguiente requerimientos para un outsourcing de selección de candidatos, donde se evaluará los conocimientos técnicos de las personas mediante un examen de conocimientos.

## 1. Registrar Preguntas nuevas

Como Usuario, quiero agregar preguntas de opción múltiple con única respuesta, al repositorio y clasificarlas por temática para poder evaluar a los candidatos de acuerdo con el cargo al que están aplicando.

> *Criterios de Aceptación*

- Las preguntas deben persistir en el tiempo y no depender de si el servicio está detenido o no
  
- Las preguntas deben tener la siguiente estructura
    
    - Pregunta
    - Opciones de respuesta
    - Respuesta correcta
    - Puntaje de la pregunta
    - Temática

## 2. Eliminar una pregunta

Como usuario quiero, poder eliminar o marcar una pregunta como obsoleta de tal manera que no se borre de la base de datos pero que al consultar las preguntas, no se visualicen las que han sido marcadas como obsoletas

> *Criterios de Aceptación*

- El servicio debe marcar las preguntas en el repositorio como obsoletas
  
## 3. Consultar preguntas registradas

Como usuario quiero, consultar las preguntas que tengo configuradas  en mi repo> por temática

> *Criterios de Aceptación*

- El servicio debe permitir consultar las preguntas que se tienen hasta el momento configuradas y almacenadas en el repositorio

## CRITERIOS DE EVALUACIÓN

1. Implementación de una arquitectura limpia
2. El proyecto debe compilar y ejecutarse sin errores. (Actualmente el proyecto tiene errores de compilación y deberá corregirlos)
3. Resultado de análisis de calidad. (No es necesario tener cobertura de código pero se valorará la implementación de al menos 2 test unitarios)
4. Se valorará el uso de validaciones de datos
5. Se valorará el uso de EntityFramework - Code First
6. El proyecto debe tener un control de versiones local para validar cada uno de los commits realizados
7. Documentación del proyecto
8. Uso de principios de Desarrollo de software
9. Sustentación del proyecto
10. Implementación de CORS (OPCIONAL)
11. Facilidad de despliegue

## CONSIDERACIONES

- Usted es libre de utilizar las librerías que requiera para la implementación de los requerimientos
- Deberá actualizar el archivo [Web.Api.Http](./src/Web.Api/Web.Api.http) para probar cada uno de los endpoints implementados
- Debe usar idioma inglés en el estilo del código
- Todos los endpoints deben implementar la interfaz __IEndpoint__