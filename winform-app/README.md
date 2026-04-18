# Proyecto WinForms — Estructura y patrón (Modelo - Vista - Controlador)

Este proyecto está organizado siguiendo una variante ligera del patrón MVC (Model-View-Controller) adecuada para una aplicación Windows Forms.

## Flujo básico (ejemplo: mostrar Artículo en MainForm)
1. La vista (MainForm) llama al Controller (`ArticuloController`) para pedir datos.
2. El Controller delega la petición al Model (`Articulo.GetById` o `Articulo.GetAll`).
3. El Model usa `AccesoDatos`(Clase con la configuración para conectarse a la DB) para ejecutar la query y mapear el resultado a objetos del dominio.
4. La vista recibe el objeto y lo presenta al usuario.

## Por qué esta organización

- Separación práctica: la UI no ejecuta SQL directamente; pide al controlador y éste al modelo.
- Partial classes: mantienen el código más pequeño por archivo, disminuyen conflictos Git y mejoran lectura.
- Centralizar la conexión (AccesoDatos) facilita gestión de recursos y manejo de exceptions.

## Cómo ejecutar y probar

1. Copiá `appsettings.template.json` a `appsettings.json` y completá la propiedad `ConnectionString`.

Notas de seguridad

- No incluir cadenas con credenciales en el repositorio.

#### Para más información sobre como configurar variables de entorno y la estructura de partial class de los modelos consultar los respectivos readme.md dentro de las carpetas de esas funcionalidades