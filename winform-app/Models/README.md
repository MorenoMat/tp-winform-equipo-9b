# Organización de Models con partial classes

Este directorio contiene los modelos del dominio organizados usando `partial class` para dividir responsabilidades por archivos.

Resumen rápido

- En lugar de tener toda la lógica (propiedades, consultas SQL, métodos de inserción/actualización/eliminación) en un solo archivo grande, se divide la clase en varios archivos `partial`.
- Ejemplo de estructura por modelo (ej. `Articulo`):
  - `Articulo.Base.cs` — propiedades y datos simples del modelo.
  - `Articulo.Read.cs` — métodos de lectura (GetAll, GetById, etc.).
  - `Articulo.Write.cs` — métodos de inserción (Add).
  - `Articulo.Update.cs` — métodos de actualización (Update).
  - `Articulo.Delete.cs` — métodos de eliminación (Delete).

Ventajas

- Legibilidad: archivos más pequeños y con responsabilidad clara facilitan entender el código.
- Mantenibilidad: es más fácil localizar y cambiar una operación específica (p. ej. solo las consultas de lectura).
- Menos conflictos en Git: al dividir métodos en archivos separados, las posibilidades de que dos ramas modifiquen el mismo archivo disminuyen.
- Organización: facilita reviewers y búsquedas por tipo de operación (Read/Write/Update/Delete).

Buenas prácticas

- Mantener cada archivo con responsabilidad clara y evitar mezclar muchas cosas en un mismo partial.
- Usar nombres consistentes (`Base`, `Read`, `Write`, `Update`, `Delete`) y namespaces coherentes.

Notas

- Esta organización no cambia la semántica: en tiempo de compilación las partes `partial` se combinan en una sola clase.