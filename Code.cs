📅 18/01/2022
⏲ 

<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>
📚 215
📅 17/01/2022
⏲ 16:25

// Los Arreglos como parametros a funciones

static void Imprime(int[] arreglo)
{
   
}

// para Realizar la invocacion de la Funcion de Arreglos

int[] numeros = new int[5];
....
....
...
Imprime(numeros);

--------------------------------------------------------------------------------------------------------------------------------------------------------
📚 216

// ahora veremos como le pasamos por parametros en el main

static void Main(string[]args)
{
    int[] numeros = new int[5];
    int n = 0;
    string linea = "";

    for(n=0;n<5;n++)
    {
      Console.WriteLine("Dame un numero ");
      linea = Console.ReadLine();
      numeros[n] = Convert.ToInt32(valor);  
    }

    //Invocamos a la funcion 
    imprime(numeros);

    static void imprime(int[]arreglo)
    {
        int n = 0;
        for(n=0;n<5;n++)
        {
           Console.WriteLine("El numero es {0} ",arreglo[n]);     
        }
    }
}



<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>
📚 221 - 222
// El Arralist
// Ejemplo de un arrayList

ArrayList datos = new ArrayList();
ArrayList datosDos = new ArrayList(15);

datos.Add(7);
datos.Add(n);
palabras.Add("Hola Mundo");

<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>

📙 223

static void Main(string[]args)
{

    foreach(int valor in costo)
    {
        Console.WriteLine("el valor es {0} ",costo);
    }


// como acceder a la informacion de un arreglo

<<<><<<<<<<<<<<>>>>><<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>><<<<<<<<<<>>>>>><<<<<
📙 224

Console.WriteLine("El dato es {0} ",datos[2]);

impuesto = datos[2] * 0.15f;

datos[2] = 5;

// Como obtener la cantidad de elementos de un arreglo

elementos = datos.Count;

// si sale valor 5 .. los indices son del 0 al 4



<<<><<<<<<<<<<<>>>>><<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>><<<<<<<<<<>>>>>><<<<<
📙 225

// Insertar Elementos , Tambien se pueden insertar elementos aparte de Add .
// el metodo Insert() necesita de dos parametros. el primero es el indice , segundo indice el elemento
// Es como un actualizar..

datos.Insert(2,5); // valor del indice 2 y el elemento es el 5

<<<><<<<<<<<<<<>>>>><<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>><<<<<<<<<<>>>>>><<<<<
📙 226

// Nota:Para saber la capacidad del ArrayList es posible hacerlo al leer el valor de la propiedad. "Capacity" esta propiedad es de tipo entero. 
// si lo que deseamos es reducir.la capacidad. del ArrayList. se puede usar el metodo. TrimToZise() pero tenemos que tener cuidado en no perder informacion.

// Como eliminar un Elemento 
// Se puede eliminar un elemento de forma sencilla, solo se necesita el indice- del elementos
// Este metodo solo se necesita un parametro. que es el indice del objeto. que deseamos eliminar. 


datos.RemoveAt(7);

// Con ArrayList para saber si se encuentra. un elemento dentro de este. para eso usamos el metodo. IndexOf() este metodo solo se requiere un solo parametro.
// que es el objeto a buscar adentro del arrayList. el metodo nos regresa un valor entero.
// Si el elemento no se encuentra. en el ArrayList , entonces simplemente el valor "-1 "

indice = datos.IndexOf(7);


<<<><<<<<<<<<<<>>>>><<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>><<<<<<<<<<>>>>>><<<<<
📙 227

// Ejemplo de ArrayList

static void Main(string[]args)
{
    int indice = 0;
    int cantidad = 0;

    ArrayList datos = new ArrayList();
    datos.Add(7);
    datos.Ad(5);
    datos.Add(1);
    Console.WriteLine("Tenemos Inicialmente los Datos ");
    Imprime(datos);
}

static void Imprime(ArrayList arreglo)
{
   foreach(int n in arreglo)
   {
    Console.WriteLine("{0},",n);
    Console.WriteLine("n---------------------------------");
   }
}

<<<><<<<<<<<<<<>>>>><<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>><<<<<<<<<<>>>>>><<<<<
// 📙 228 al 233


static void Main(string[]args)
{
    int indice = 0;
    int cantidad = 0;

    ArrayList datos = new ArrayList();
    datos.Add(7);
    datos.Ad(5);
    datos.Add(1);
    datos.Add(4);
    datos.Add(5);

    indice = datos.Add(10);
    Console.WriteLine("despues de hacerlo crecer");
    imprime(datos);
    Console.WriteLine("El ultimo elemento tiene el indice {0}",indice);
    Console.WriteLine("--------------------------");
    //Se imprime un elemento en particular
    Console.WriteLine("El valor en el indice 2 es {0}",datos[2]);
    Console.WriteLine("_____________________________________");
    datos[3] = 55;
    Console.WriteLine("Despues de las modificaciones ");
    imprime(datos);
    
    // Obtenemos la cantidad
    cantidad = datos.Count();
    Console.WriteLine("la cantidad de elementos es {0}",cantidad);
    Console.WriteLine("--_---_--______---___-__-_-__");
    datos.Insert(2.88);
    Console.WriteLine("Despues de la insercion.");
    imprime(datos);
    // Para eliminar un campo. 
    datos.RemoveAt(4);
    Console.WriteLine("Despues de la eliminacion ");
    imprime(datos);
    indice = Datos.IndexOf(5);
    Console.WriteLine("El primer 5 se encuentra eb {0}" ,indice);
    Console.WriteLine("--________-------------________");

    Console.WriteLine("Tenemos Inicialmente los Datos ");
    Imprime(datos);
}

static void Imprime(ArrayList arreglo)
{
   foreach(int n in arreglo)
   {
    Console.WriteLine("{0},",n);
    Console.WriteLine("n---------------------------------");
   }
}
// 📓 233


<<<><<<<<<<<<<<>>>>><<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>><<<<<<<<<<>>>>>><<<<<
📙 234 - 235 -236 

// El Stack es otro tipo de coleccion se le conoce como pila tambien. nos permite guardar elementos y cambia su tamaño de forma dinamica.es un objeto. tiene sus propios metodos. se debe instanciar

// Como crear un stack como cualquier otra coleccion solo se necesita instanciar para poder utilizar.Adentro de esta clase encontramos todo los metodos necesarios. 

Stack miPila = new Stack();

// Para introducir informacion al stack. para introducir informacion al stack. usamos el metodo Push() // este metodo coloca el nuevo elemento en la parte superior del Stack.
// solo se necesita de un parametro. 

miPila.Push(7);
miPila.Push(11);
miPila.Push(8);

// primer elemento es el 8 , ultimo elemento 7


<<<><<<<<<<<<<<>>>>><<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>><<<<<<<<<<>>>>>><<<<<

¬¬ pag 237

/*como obtener informacion del stack

si queremos obtener informacion del stack del elemento que esta en el lugar superior.
*/
int valor = 0;
valor = (int)miPila.Pop();

// el valor tendra el valor 8	

/*para recorrer el stack usar foreach
*/

<<<><<<<<<<<<<<>>>>><<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>><<<<<<<<<<>>>>>><<<<<

¬¬ pag 238

foreach(int x in miPila)
{
	Console.WriteLine("{0}",n);
}

/*para obtener la cantidad de elementos del stack.Se debe usar la propiedad Count.
Esta nos regresa un valor entero.Con la cantidad de elementos.
*/
cantidad = miPila.Count();

/*para limpiar elementos del stack. Si queremos eliminar todo los elementos del stack se usa una propiedad y no necesita parametros.
*/
miPila.Clear();

/*Para saber si un stack tiene elementos.y este es un elemento en particular.
se debe agregar un parametro
que es el elemento que se busca.Regresa un TRUE o FALSE
*/
bool enStack = false;
enStack = miPila.Contains(7);

<<<><<<<<<<<<<<>>>>><<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>><<<<<<<<<<>>>>>><<<<<

¬¬ pag 239 - 240

/*creacion de una aplicacion
*/

static void Main(string[]args)
{
    int opcion = 0;
    string linea = "";
    int numero = 0 ;
    bool encontrado = false;

    Stack miPila = new Stack();

    datos
    {
        Console.WriteLine("1- Push");
        Console.WriteLine("2- Pop");
        Console.WriteLine("3-Clear");
        Console.WriteLine("4-Contains");
        Console.WriteLine("3-Salir");
        Console.WriteLine("Dame tu Opcion");
        linea = Console.ReadLine();
        opcion = Convert.ToInt32(linea);
        
        if(opcion ==1)
        {
            // pedimos el valor a introducir
            Console.WriteLine("Dame el valor a Introducir");
            linea = Console.ReadLine();
            numero = Convert.ToInt32(linea);

            // adicionamos el valor en el stack
            miPila.Push(numero);
        }

        if(opcion==2)
        {
            // mostramos el elemento
            numero = (int)miPila.Pop();
            Console.WriteLine("El valor Obtenido es {0}",numero);
        }

        if(opcion==3)
        {
           //limpiamos todo los contenidos del stack
           miPila.Clear(); 
        }

        if(opcion==4)
        {
            // pedimos el valor a encontrar
            Console.WriteLine("Dame el valor a encontrar");
            linea = Console.ReadLine();
            numero = Convert.ToInt32(linea);

            // Vemos si el elemento esta
            encontrado = miPila.Contains(numero);
            // Mostramos el resultado
            Console.WriteLine("encontrado {0}",encontrado);           
        }

            // Mostramos la informacion del stack 
            Console.WriteLine("El stack Tiene {0} elementos",miPila.Count);
             
             foreach(int n in miPila)
             {
                Console.WriteLine("{0},",n);
                Console.WriteLine("");
                COnsole.WriteLine("------------------");

             }

    }while(opcion!=5)

}

<<<><<<<<<<<<<<>>>>><<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>><<<<<<<<<<>>>>>><<<<<

📚 Pag  243


// El Queue o tambien conocida como cola. al igual que el stack ya no es necesario programarla.
// existe una clase que se puede usar. la clase se llama Queue su estructura es de tipo fifo.
// este funciona diferente al stack. es como una fila. el primero que llega el primero en salir.


<<<><<<<<<<<<<<>>>>><<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>><<<<<<<<<<>>>>>><<<<<

📚 Pag  244

// Declaracion de un Queue Se debe crear una instancia de la clase.

Queue fila = new Queue();

// Una vez instanciado ya es posible hacer uso de la fila y tambien de los metodos. que nos provee la clase correspondiente

// Adiccion de elementos al Queue
// Podemos agregar un elemento en cualquier momento que lo necesitamos. el tamaño del Queue se modifica dinamicamente por lo que no debemos preocuparnos. 
// Se utiliza el metodo Enqueue que pertenece a la clase Queue y solo necesita un parametro.
// se coloca el elemento que deseamos añadir.

<<<><<<<<<<<<<<>>>>><<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>><<<<<<<<<<>>>>>><<<<<

📚 Pag  245

fila.Enqueue(7);

int valor = 0;
valor = fila.Dequeue();

<<<><<<<<<<<<<<>>>>><<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>><<<<<<<<<<>>>>>><<<<<

¬¬ Pag 246

/*para saber si un Queue tiene un determinado elemento en particular.gracias a un metodo se puede hacer. hay que pasarle un parametro. el elemento en cuestion. retorno un booleano
*/
Contains();

if(miFila.Contains(7) == true)
{
	Console.WriteLine("El elemento si existe");
}

<<<><<<<<<<<<<<>>>>><<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>><<<<<<<<<<>>>>>><<<<<

¬¬ pag 247

/*para Borrar elementos del Queue: No requiere de ningun parametro. pero se debe usar con cuidado. o se pueden perder toda la coleccion.
*/

miFila.Clear();

/*Para conocer la cantidad de elementos que tiene un Queue:debemos usar la propiedad Count este corresponde a un valor entero.
*/
int cantidad = 0;
cantidad = miFila.Count;

/*Si se quiere usar para aprovechar y hacer una operacion en,particular.evitar algun error con el queue. 
*/
if(miFila.Count>0)
{
	 valor = (int)miFila.Dequeue();
}

/*Para recorrer los elementos del Queue la mejor forma es con un foreach.
*/
foreach(int n in miFila)
{
	Console.WriteaLine("{0}",n);
}

<<<><<<<<<<<<<<>>>>><<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>><<<<<<<<<<>>>>>><<<<<

¬¬ pag 248






















// ⏲

