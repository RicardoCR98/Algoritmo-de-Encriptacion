# Sistema de Encriptación y Desencriptación

## Descripción

Este proyecto es una **aplicación de escritorio** desarrollada en **C# (Visual Studio)** que implementa algoritmos de encriptación y desencriptación utilizando la lógica de diferentes técnicas matemáticas, tales como la **matriz de Vigenère**, el **método de Gauss-Jordan** y otras estrategias de cifrado.

El objetivo de esta aplicación es proporcionar una herramienta para cifrar y descifrar mensajes de forma segura, siendo un proyecto aún en desarrollo. Su interfaz gráfica permite al usuario interactuar fácilmente con las funcionalidades de cifrado y descifrado.

## Características

- **Encriptación** de textos utilizando la matriz de Vigenère.
- **Desencriptación** de textos con los métodos aplicados.
- Uso del **método de Gauss-Jordan** para realizar operaciones relacionadas con matrices y sistemas de ecuaciones en el proceso de encriptación.
- **Interfaz gráfica** simple desarrollada con Windows Forms.
- Aplicación de **lógica modular** separada en capas:
  - **Vista**: La interfaz gráfica donde el usuario interactúa con el sistema.
  - **Lógica**: Implementación de los algoritmos de encriptación y desencriptación.
  
## Tecnologías Utilizadas

- **Lenguaje de programación**: C#
- **Entorno de desarrollo**: Visual Studio
- **Interfaz gráfica**: Windows Forms
- **Algoritmos**: Matriz de Vigenère, Gauss-Jordan, y otros.

## Estructura del Proyecto

```bash
SistemaEncriptacion/
│
├── Logica/
│   ├── Encrypt.cs        # Lógica de encriptación
│   ├── Decrypt.cs        # Lógica de desencriptación
│   └── Vista/
│       ├── Form1.cs      # Controlador del formulario principal
│       └── Form1.Designer.cs  # Diseñador de la interfaz gráfica
├── Program.cs            # Punto de entrada de la aplicación
├── Proyecto2EDA_AlgoritmoEncriptacion.sln  # Solución de Visual Studio
└── README.md             # Archivo con documentación del proyecto
```

## Requisitos Previos

- **Visual Studio 2019 o superior**
- **.NET Framework 4.7.2 o superior**
  
## Instalación y Ejecución

1. Clona este repositorio en tu máquina local:

   ```bash
   git clone https://github.com/tu-usuario/sistema-encriptacion.git
   ```

2. Abre la solución del proyecto (`.sln`) en **Visual Studio**.

3. Compila y ejecuta la aplicación utilizando las herramientas integradas de Visual Studio.

## Estado del Proyecto

El proyecto se encuentra en **fase de desarrollo**, con las siguientes áreas pendientes de implementación o mejora:

- Integración de más algoritmos de encriptación.
- Mejoras en la interfaz gráfica.
- Optimización del rendimiento de los algoritmos.
- Tests unitarios para validar el funcionamiento de los algoritmos.

## Contribuciones

Las contribuciones son bienvenidas. Si deseas contribuir, por favor sigue estos pasos:

1. Haz un fork del proyecto.
2. Crea una nueva rama (`git checkout -b feature/nueva-caracteristica`).
3. Realiza tus cambios y haz un commit (`git commit -am 'Añadir nueva característica'`).
4. Haz push de tu rama (`git push origin feature/nueva-caracteristica`).
5. Abre un Pull Request.
