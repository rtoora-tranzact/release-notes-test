module.exports = {
  extends: ['@commitlint/config-conventional'],
  rules: {
    'type-enum': [
      2,
      'always',
      [
        'feat', // Nuevas características
        'fix', // Corrección de errores
        'docs', // Documentación
        'style', // Cambios que no afectan el significado del código
        'refactor', // Refactorización de código
        'perf', // Mejoras de rendimiento
        'test', // Adición o corrección de pruebas
        'chore', // Cambios en el proceso de compilación o herramientas auxiliares
        'revert', // Revierte un commit anterior
        'build', // Cambios que afectan el sistema de compilación o dependencias externas
        'ci' // Cambios en archivos de configuración CI
      ]
    ],
    'subject-case': [0], // Permitir cualquier estilo de caso en el asunto
    'header-max-length': [2, 'always', 100] // Longitud máxima del encabezado
  }
};