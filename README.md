# release-notes-test
This project is for testing packages generation along with it's corresponding release notes

# release-notes-test
This project is for testing packages generation along with it's corresponding release notes

## Conventional Commits

Este proyecto utiliza [Conventional Commits](https://www.conventionalcommits.org/) para el formato de mensajes de commit. Esto nos ayuda a generar automáticamente changelogs y versiones semánticas.

### Estructura del mensaje de commit
```
<tipo>[ámbito opcional]: <descripción>

[cuerpo opcional]

[nota al pie opcional]
```

### Tipos de commit permitidos

- `feat`: Una nueva característica
- `fix`: Una corrección de error
- `docs`: Cambio en documentación
- `style`: Cambios que no afectan el significado del código
- `refactor`: Cambio de código que ni corrige un error ni agrega una característica
- `perf`: Cambio de código que mejora el rendimiento
- `test`: Adición o corrección de pruebas
- `chore`: Cambios en el proceso de compilación o herramientas auxiliares
- `revert`: Revierte un commit anterior
- `build`: Cambios que afectan el sistema de compilación o dependencias externas
- `ci`: Cambios en archivos de configuración y scripts de CI

### Ejemplos
fix: adding DOM-XXXX fix