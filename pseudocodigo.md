# Proyecto: Clase `Mascota`

Este proyecto modela una **mascota** utilizando pseudocódigo.  
Se definen atributos, un constructor y métodos que representan acciones que puede realizar la mascota.

---

## 📋 Descripción del pseudocódigo

### **Clase Mascota**
- **Atributos:**
  - `nombre` (Cadena): Nombre de la mascota.
  - `edad` (Entero): Edad de la mascota.
  - `tipo` (Cadena): Tipo de mascota (ejemplo: perro, gato, etc.).
  - `sonido` (Cadena): Sonido característico de la mascota.

- **Constructor:**  
  Inicializa los atributos de la mascota con valores dados.

- **Métodos:**
  1. **EmitirSonido():**  
     Muestra en pantalla el sonido característico de la mascota.
  2. **MostrarInformacion():**  
     Muestra en pantalla el nombre, edad y tipo de la mascota.

---

## 📜 Pseudocódigo

```plaintext
INICIO CLASE Mascota
    // Atributos
    Definir nombre Como Cadena
    Definir edad Como Entero
    Definir tipo Como Cadena
    Definir sonido Como Cadena

    // Constructor
    INICIO CONSTRUCTOR Mascota(nom, ed, tip, son)
        Asignar nombre = nom
        Asignar edad = ed
        Asignar tipo = tip
        Asignar sonido = son
    FIN CONSTRUCTOR

    // Método para emitir sonido
    INICIO METODO EmitirSonido()
        Escribir sonido
    FIN METODO

    // Método para mostrar información
    INICIO METODO MostrarInformacion()
        Escribir "Nombre: ", nombre
        Escribir "Edad: ", edad
        Escribir "Tipo: ", tipo
    FIN METODO
FIN CLASE

// Programa principal
INICIO
    Definir miMascota Como Mascota
    miMascota ← Mascota("Firulais", 3, "Perro", "Guau!")

    miMascota.MostrarInformacion()
    miMascota.EmitirSonido()
FIN
