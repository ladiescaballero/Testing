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

 🎬📍
static void Main(string[]args)
{
    int[] numeros = new int[5];
    int n = 0;
    string linea = "";

    for(n=0;n<5;n++)
    {
      Console.WriteLine("Dame un numero ");
      linea = Console.ReadLine();
      numeros[n] = Convert.ToInt32(linea);  
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
📍

// El Arralist
// Ejemplo de un arrayList

ArrayList datos = new ArrayList();
ArrayList datosDos = new ArrayList(15);

datos.Add(7);
datos.Add(n);
palabras.Add("Hola Mundo");

<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>

📙 223
📍

static void Main(string[]args)
{

    foreach(int valor in costo)
    {
        Console.WriteLine("el valor es {0} ",costo);
    }


// como acceder a la informacion de un arreglo

<<<><<<<<<<<<<<>>>>><<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>><<<<<<<<<<>>>>>><<<<<
📙 224
📍


Console.WriteLine("El dato es {0} ",datos[2]);

impuesto = datos[2] * 0.15f;

datos[2] = 5;

// Como obtener la cantidad de elementos de un arreglo

elementos = datos.Count;

// si sale valor 5 .. los indices son del 0 al 4



<<<><<<<<<<<<<<>>>>><<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>><<<<<<<<<<>>>>>><<<<<
📙 225
📍

// Insertar Elementos , Tambien se pueden insertar elementos aparte de Add .
// el metodo Insert() necesita de dos parametros. el primero es el indice , segundo indice el elemento
// Es como un actualizar..

datos.Insert(2,5); // valor del indice 2 y el elemento es el 5

<<<><<<<<<<<<<<>>>>><<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>><<<<<<<<<<>>>>>><<<<<
📙 226
📍

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
    datos.Add(5);
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

static void Main(string[]args)
{
	// variables necesarias
	int opcion = "";
	string linea = "";
	int numero = 0;
	bool encontrado = false;
	
	//Creamos el queue
	Queue miFila = new Queue();
	
	do{
		
		// Menu
		Console.WriteLine("1 Enqueue");
		Console.WriteLine("2 deQueue");
		Console.WriteLine("3 Clear");
		Console.WriteLine("4 Contains");
		Console.WriteLine("Salir");
		Console.WriteLine("Dame tu opcion");
		linea = Console.ReadLine();
		opcion = Convert.ToInt32();
		if(opcion==1)
		{
			// pedimos el valor a ingresar
			Console.WriteLine("Dame el valor a ingresar");
			linea = Console.ReadLine();
			numero = Convert.ToInt32(linea);
			//Adicionamos el valor en el Queue
			miFila = Enqueue(numero);
        }

        if(opcion == 2)
        {
            // Obtenemos el elemento
            numero = (int)miFila.Dequeue();
            // Mostramos el elemento
            Console.WriteLine("el valor obtenido es : {0}",numero);
        }

        if(opcion==3)
        {
            // Limpiamos todo los contenidos del Queue
            miFila.Clear();
        }

        if(opcion == 4)
        {
            // Pedimos el valor a encontrar
            Console.WriteLine("Dame el valor a encontrar");
            linea = Console.ReadLine();
            numero = Convert.ToInt32(linea);
            // vemos si el elemento esta
            encontrado = miFila.Contains(numero);
            // Mostramos el resultado
            Console.WriteaLine("Elemento encontrado {0}",encontrado);
        }

        // Mostramos la informacion del Stack
        Console.WriteaLine("El Queue tiene {0} Elementos ",miFila.Count);
        foreach(int n in miFila)
        {
           Console.WriteaLine("{0},",n);
           Console.WriteaLine("");
           Console.WriteaLine("-----------");     
        }
    }while(opcion!=5);

	}
}

<<<><<<<<<<<<<<>>>>><<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>><<<<<<<<<<>>>>>><<<<<
¬¬ pag 251
	
Hashtable tabla = new Hashtable();

/*adicion de elementos al Hashtable para agregar elementos se debe usar dos parametros. uno la llave y el value.

llave generalmente es un string y el value cualquier tipo de dato.
*/

<<<><<<<<<<<<<<>>>>><<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>><<<<<<<<<<>>>>>><<<<<

¬¬ Pag 252

tabla.Add("pan",5.77);
tabla.Add("soda",10.85);
tabla.Add("Atun",85.50);


// Recorriendo el Hashtable : Para recorrer el hashtable usaremos la clase foreach.si queremos obtener la pareja key,value nos apoyaremos en una clase llamasa DictionaryEntry. Si queremos la impresion del siguiente ejemplo usaremos esto.

<<<><<<<<<<<<<<>>>>><<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>><<<<<<<<<<>>>>>><<<<<

📚 253

foreach(DictionatyEntry datos in tabla)
{
    Console.WriteaLine("key - {0} , value -{1}" ,datos.Key , datos.Value);
}

//Si lo deseamos podemos extraer solamente los valores y colocar una copia de ellos en una coleccion
// De esta forma es como trabajar de una forma mas parecida a lo aprendido anteriormente

ICollection valores = tabla.Values;


// valores = ICollection , 
// Imprimir = valor
foreach(double valor in valores)
{
    Console.WriteLine("el valor es {0}",valor);
}


// Icollection es una interfaz usada para implementar las colecciones de tal forma que los valores pueden actuar como cualquier coleccion valida que tengamos. 

// Obtener un elemento Hashtable: Si Deseamos leer un elemento en particular de Hashtable es posible que lo hagamos por medio de su propiedad Item para usarlo simplemente tenemos que colocar como indice un Key que corresponde al valor que queremos leer en el momento. 
// debemos tener en cuenta que es posible que necesitamos hacer un type cast para dejar el valor correspondiente en el tipo necesario.

float valor;
valor = (float)tabla.Item["Pan"];


<<<><<<<<<<<<<<>>>>><<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>><<<<<<<<<<>>>>>><<<<<

📚254

// Para borrar contenidos del Hashtable: Todo los elementos adentro del hashtable pueden ser borrados al utilizar el metodo clear() este metodo no necesita ningun parametro.

tabla.Clear(2);

// Para encontrar si ya existe un Key: Como no podemos repetir el mismo Key para dos elementos es necesario poder saber si ya existe un determinado key. existe un metodo Contains(). Solo se necesita de un parametro que es el key a buscar y regresa un valor de tipo Bool. si el valor es regresado es true. significa que el key ya existe. si es false que no se encuentra en el Hashtable.

bool existe ;
existe = tabla.Contains("Pan");

// Para encontrar si ya existe un value: Tambien se puede buscar adentro del Hashtable por un value en particular en este caso usaremos el metodo ContainsVale(). como parametros pasamos el valor a buscar y el metodo regresa un bool , si el valor regresado es true el value existe en el hashtable y el valor de false nos indica que no encuentra.

bool existe
existe = tabla.ContainsValue(17.50);

// Para conocer la cantidad de parejas en el hashtable: Si deseamos saber cuantas parejas key,value 
// existe adentro de nuestro Hashtable podemos usar la propiedad de Count.No hay que olvidar que el valor regresado es un entero que dice el numero de parejas.


int cantidad 
cantidad = tabla.Count;

// Para eliminar un elemento del Hashtable: No solamente podemos adicionar elementos. tambien podemos eliminar. Al eliminar se remueven la pareja key,value del hashtable para poder llevar a cabo la eliminacion. necesitamos conocer el key del valor a eliminar y utilizar el metodo Remove()
// solo se necesita de un solo parametro que es el key del elemento a borrar.

tabla.Remove("Pan");

// Con esto finalizamos los metodos principales del Hashtable y las colecciones mas usadas en C# 


<<<><<<<<<<<<<<>>>>><<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>><<<<<<<<<<>>>>>><<<<<

¬¬ Pag 258

/*Las cadenas sirven para guardar informacion alfanumerica.Se utilisa la clase String.
las cadenas se guardan como una coleccion y cada caracter es un elemento.
*/
/*Como declarar una cadena:Para declarar una cadena es muy sencillo. se crea una instancia de la clase string 
y le asignamos el valor que corresponde. puede ser un texto o vacio. debe ir entre comillas dobles.
*/
string miCadena = "lalal";
string miCadenaDos = "";


<<<><<<<<<<<<<<>>>>><<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>><<<<<<<<<<>>>>>><<<<<

¬¬ Pag 259

/*El metodo ToString: Este metodo es muy util cuando se quiere convertir un tipo de dato o su representacion a una "CADENA" y queremos desplegar informacion al usuario.
Imagenemos que tenemos una variable de tipo entero y queremos desplegar este valor al usuario.Para eso podemos convertir a cadena el valor.
*/
string cadena = valor.ToString();

// Como convertir y formatear fechas a cadenas: Uno de los usos mas comunes de las cadenas es poder formatear informacion que puede ser de cualquier tipo. Uno que es bien comun es la de formatear son las fechas- Se hace con una clase llamada DateTime();
// Esta clase esta relacionado con el tiempo como son las fechas y horas del dia. 

DateTime tiempo = DateTime.Now();

// La propieda Now tiene el tiempo Actual del sistema. ahora lo que necesitamos es pasar esa informacion a un formato util y practico para trabajar. existe un metodo llamado Format() de String , remplaza los contenidos de la cadena por un cadena con un formato en particular.
// para llevar a cabo un formato debemos usar los especificadores de formato DateTime contiene un conjunto de estos especificadores.

// Revisar la tabla de como se forma una fecha 

// Dia Semana , seguido del Año , Mes en numero.

string formato;
formato = String.Format("la fecha es : {0:dddd yyyy M}" , DateTime.Now); 







// ⏲

