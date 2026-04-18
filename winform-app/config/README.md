# Configuración (appsettings)

Este directorio contiene la configuración local de la aplicación.

---

## Archivos

- `appsettings.template.json` → plantilla con el valor de ejemplo para `ConnectionString`.
- `appsettings.json` → archivo local con la cadena de conexión real (NO subir al repositorio).

> Nota: `appsettings.json` está añadido a `.gitignore` por seguridad.

---

## Formato recomendado

Ejemplo mínimo de `appsettings.json`:

```json
{
  "ConnectionString": "Server=.\\SQLEXPRESS;Database=POKEDEX_DB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;"
}
```

- Ajustá `Encrypt` / `TrustServerCertificate` según tu entorno (ver secciones abajo).

---

## Cómo usar (Visual Studio)

1. Copiá `appsettings.template.json` y renombralo a `appsettings.json`.
2. Abrí `appsettings.json` y completá `ConnectionString` con la cadena de tu base de datos.

### Importante: copiar al directorio de salida

Para que la aplicación encuentre `appsettings.json` cuando se ejecuta desde Visual Studio, asegurate de que el archivo se copie al directorio de salida (bin). Para ello:

1. En Solution Explorer localizá `winform-app/config/appsettings.json`.
2. Seleccioná el archivo y abrí la ventana *Properties*.
3. En *Copy to Output Directory* elegí `Copy always` o `Copy if newer`.

Después de esto, al ejecutar la aplicación, el archivo estará disponible y la configuración será leída correctamente.

---

## Motivo de todo este quilombo:

- No subir credenciales ni cadenas de conexión al repositorio por razones de seguridad al evitar exponer credenciales de la DB.
