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


<<<><<<<<<<<<<<>>>>><<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>><<<<<<<<<<>>>>>><<<<<

📚 260

// Revisar la tabla de como se forma una fecha 

// Dia Semana , seguido del Año , Mes en numero.

string formato;
formato = String.Format("la fecha es : {0:dddd yyyy M}" , DateTime.Now); 

// Adentro de format Colocamos la cadena de formato y como solo se va desplegar un valor , hacemos uso del {0} este tendra un valor en particular. Ponemos el formato al colocar : y los especificadores necesarios adentro del {}. de esta forma ese valor tendra el formato correspondiente. siempre que sean validos para el tipo que deseamos.


<<<><<<<<<<<<<<>>>>><<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>><<<<<<<<<<>>>>>><<<<<

📚 261 
  
 // Para Darles formato a valores numericos. Mira la tabla. Al igual con la informacion de la fecha y hora . es posible darle formato a los valores numericos que deseamos mostrar.
 
/*ver tabla de valores especifcados
*/

/*Cuando especificamos un formato podemos tener diferentes secciones.podemos tener un formato en particular , Una primera seccion para los numeros positivos , segunda seccion para los numeros negativos , tercera seccion para el valor cero.
*/
Console.WriteLine(String.Format("{0:$#,###0.00;Negativo $#,###0.00;Cero}",valor));

/*Si el valor contenido adentro de valor es positivo.se presentara normalmente y con un signo de moneda antes de el.Pero si el valor es negativo aparecera con la palabra Negativo y el signo de monedas antes.y si el valor fue cero aparecera la palabra Cero.
*/

¬¬ Pag 262

/*Como concatenar Cadenas : Otra manipulacion que podemos hacer es la concatenacion es muy sencilla de hacer existe una funcionalidad o sobrecarga del operador + para la clase String .
*/
string nombre = "tomas";
string apellido = "lopez"
NombreCompleto = "nombre +""+apellido;

/*Nota : Utilizar el operador + no es muy practico ya que al utilizar espacios vacios se pieden espacios en memoria. para eso es mejor utilizar Concat una clase especializada. solo requiere dos parametros . uno no tendria sentido unir.
*/
nombreCompleto = String.Concat(nombre , apellido);

/*El metodo Concat es estatico por eso es posible usarlo sin la necesidad de instanciarlo.

*/

¬¬ Pag 263

nombreCompleto = String.Concat(nombre , String.Concat(" ",apellido));

/*Uso de StringBuilder permite construir cadenas de forma efeciente.y se puedem usar en vez de usar las concatenaciones se puede usar el constructor por default que no necesita ningun parametro.la clase tiene varias propiedades como capacity que nos indica la capacidad actual o tambien chars que podemos modificar un caracter en particular.
*/

StringBuilder sb = new StringBuilder("Hola a todos");

sb.Chars[6]= 'o';



<<<><<<<<<<<<<<>>>>><<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>><<<<<<<<<<>>>>>><<<<<

📚 264 
// Si leemos la propiedad de Length Obtenemos la longitud que tiene el StringBuilder. Si colocamos en un valor en esta propiedad entonces el stringBuilder tendra el tamaño que indicamos. Si el nuevo tamaño es menor que el actual entonces se trunca el contenido del StringBuilder.
// Para llevar a cabo la concatenacion. debemos usar el metodo Append() este metodo tiene muchas sobre carga ya que no solamente puede concatenar en la cadena. hay que recordar el Append() es eficiente.

StringBuilder sb = new StringBuilder("Hola a todos");
.
.
sb.Append("Hola Mundo");


// En sb tendremos el contenido "Hola a todos Hola Mundo". Tambien podemos agregar una cadena de formato construida de forma similar a la forma como trabajamos con los formatos WriteLine() para eso usamos el metodo AppendFormat() Este metodo necesita dos parametros. pero puede llevar mas si fuera necesario en el prime colocamos la cadena de forma y en el segundo la siguiente lista de variables a utilizar. 

StringBuider sb = new StringBuider();
int valor = 5;
...
sb.AppendFormat("El valor es {0} , valor");



// Un metodo Importante en esta clase es ToString() que permite convertir StringBuilder es una cadena y de esta manera poder utilizar los contenidos creados por medio de esta clase.

String cadena = "";
cadena = sb.ToString();

// De esta forma la cadena tendra en su interior la cadena creada por medio del StringBuilder. Existen otros metodos mas que pertenecen a esta clase y pueden llegar a sernos utiles en el futuro.

<<<><<<<<<<<<<<>>>>><<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>><<<<<<<<<<>>>>>><<<<<

📚 265 

// Comparacion de Cadenas:En algunas de nuestras aplicaciones es posible que lleguemos a necesitar llevar a cabo una comparacion entre algunas cadenas. esto nos sirve para determinar si una cadena en especial a sifo intruducida por el usuario.
// La clase string nos da el metodo Compare()
// este metodo es estatico y es posible de usar sin necesidad declarar un objeto de tipo string el metodo necesita de dos parametros que son las cadenas a comparar. 
// el metodo regresa un valor entero y el valor se encargara de indicarnos su relacion que existe entre las cadenas que acabamos de comparar.
// si el valor regresado es igual a 0 significa que las cadenas son iguales. en caso que el valor es negativo cadena1 es menor a cadena2 y si el numero es positivo significa que cadena1 es mayor a cadena2.

int comparacion = 0;
string nombre = "juan";
..
..
comparacion = String.Compare("Pedro", nombre);
if(comparacion==0)
{
    Console.WriteLine("Los nombre son iguales");
}
else
{
    Console.WriteaLine("Los nombres son Distintos");
}   


<<<><<<<<<<<<<<>>>>><<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>><<<<<<<<<<>>>>>><<<<<

📚 266

// Existe otra forma de comparar dos cadenas es con el metodo Equals() que solamente dira si las dos cadenas son iguales. No realiza otra comparacion.el metodo es estatico y solo requiere dos parametros cadena1 cadena2 , Retorna True si son Iguales o false si son Distintos.

String cadena1 = "Hola";
string cadena2 = "Todos";

if(String.Equals(cadena1 , cadena2)==true)
Console.WriteLine("Las cadenas Son Iguales");

// Para Encontrar una Subcadena : la Cadena puede contener una frase con muchas palabras. y a veces necesitamos saber si determinada palabra se encuentra en la cadena. osea que buscamos una subcadena adentro de otra cadena. Esto puede servir cuando hacemos una busqueda o cuando queremos aplicar una logica. si se encuentra una palabra o frase en particular.El metodo que usaremos se llama Contains() y debe ser invocado por la cadena a la que realiza la busqueda. Eso es importante y no olvidemos que la invocacion de Contains() en la cadena incorrecta puede llevar a errores de logica.
// El metodo Contains solo necesita un parametro . este parametro es la subcadena a buscar. esta puede ser dada explicitamente o por medio de una variable de tipo string que la contenga. El metodo regresa un Bool si la cadena la encuentra retorna un true si la encontro o una false si no se encuentra.




<<<><<<<<<<<<<<>>>>><<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>><<<<<<<<<<>>>>>><<<<<

📚 267

String NombreCompleto = "Juan pedro Lopez";
String NombreBuscar = "pedro";
if(NombreCompleto.Contains(NombreBuscar)== true)
{
    Console.WriteLine("El nombre se encontro");
}


// Para Obtener Una Subcadena = Ahora que ya tenemos una forma de saber si existe una subcadena tambien podemos extraer una subcadena. Esto nos puede servir para los casos en los que necesitamos tener solamente una parte de la cadena original.
// La forma como lo hacemos es por medio del medio del metodo SubString().

// Para Evitar problemas con Contains
// Debemos tener en cuenta puntos relacionados con Contains() el primero es que la cadena vacia como "" siempre regresara True , otro punto importante es que la busqueda que realiza Contains() es sensible a Mayusculas o Minusculas.
// al Buscar "Hola" no es lo mismo que "hola"

// Para usar este metodo Necesitamos dos parametros que son valores de tipo entero. el primero indica el indice adentro de la cadena original. donde inicia la subcadena que nos interesa obtener. Y el segundo es la cantidad de caracteres que tiene una subcadena. El metodo regresa una cadena que contiene a la subcadena que hemos obtenido. 



<<<><<<<<<<<<<<>>>>><<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>><<<<<<<<<<>>>>>><<<<<

📚 268

String cadena = "Hola mundo Redondo";
string resultado = "";
...
...
resultado = cadena.Substring(5,5,);

// Retorna mundo
// Empiza de 0 a 4 .. y son cinco caracteres


// Para determinar si una cadena finaliza en Subcadena:Es posible determinar si una Subcadena particular termina en un punto o palabra particular. esto es util para verificar donde termina esta subcadena. Este metodo se llama EndsWith() y solo necesita un parametro que sera la subcadena que vamos a buscar. 


<<<><<<<<<<<<<<>>>>><<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>><<<<<<<<<<>>>>>><<<<<

📚 269

String cadena1 = "Juan Pedro Lopez";

String cadena2 = "Lopez"
if(cadena1.EndsWith(cadena2)==true)
{
    Console.WriteLine("La cadena finaliza en Lopez");
}

// La busqueda de la subcadena se hace al final de la cadena = Lopez

// Como copiar una parte de la cadena : Se puede Obtener o copiar una parte particular de la cadena y si la cadena contiene una frase , Podemos extraer una palabra en particular , Cuando necesitamos procesar una cadena es muy util hacer esto. El metodo que usaremos es el CopyTo() aunque es un poco mas complejo que los otros. Necesita los mismos cuatro parametros , la Cadena extraida sera colocada en un arreglo de tipo chars el metodo no regresa ningun valor.
// el primer parametro es el indice adentro de la cadena principal.Donse se empezara a copiar , El segundo parametro el la cadena de tipo char donde se pondra la cadena a extraer. El tercer parametro es el indice del arreglo a partir donde se empezaran a colocar los caracteres de la cadena copiada. Esto es util ya que podemos hacer la copia en cualquier posicion del arreglo.No solamente al inicio.El cuarto parametro indica la cantidad de caracteres a copiar. Con estos parametros podemos indicar sin problemas cualquier secciona a copiar.


char[] destino = new char[10];
string cadena = "Hola a todos mis amigos.";

cadena.CopyTo(7,destino,0,5);


<<<><<<<<<<<<<<>>>>><<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>><<<<<<<<<<>>>>>><<<<<

📚 270

// Como insertar una cadena : Tambien es posible realizar la inserccion de una cadena en otra. esto es util cuando debemos insertar nueva informacion en la cadena. pero ya no es posible por medio de concatenacion o formato.
// Para hacer esto recurrimos a utilizar el metodo Insert(); que nos brinda. Este metodo coloca la cadena dentro de la cadena principal.Este tambien necesitara dos parametros. 
// El primero indicara el Indice dentro de la cadena principal donde se va insertar la nueva cadena.
// Este valor debe de ser de tipo entero y nunca pasarle el valor negativo , El Segundo parametro es la cadena que deseamos insertar que puede ser colocado explicimante o mediante una variable de tipo string. 
// El metodo insert(); regresa un valor de tipo String. Este valor regresado seria la instancia de la nueva cadena que ya contiene la insercion  

String cadena1 = "Hola a todos";
String cadena2 = "Hola";
String resultado = "";

resultado = cadena1.Insert(5 , cadena2);


<<<><<<<<<<<<<<>>>>><<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>><<<<<<<<<<>>>>>><<<<<

📚 271

// Para Encontrar la posicion de una Subcadena: En algunas situaciones necesitamos encontrar donde se encuentra determinada subcadena para poder llevar a cabo alguna operacion en ese indice en particular. Para poder hacer esto hacemos uso del metodo LastIndexOf() un punto importante a tener en cuenta es que este metodo es no regresa el indice de la ultima posicion encontrada. Es Decir que si la cadena tiene dos repiticiones de esa cadena , Nos da el indice de la segunda repiticion. 
// Este metodo tiene varias sobreCargas. pero la que veremos solo necesita un parametro y la subcadena a encontrar. Como siempre la cadena puede ser dada forma explicita o por medio de una variable de tipo String. El metodo regresa un valor de tipo entero. que contiene el indice de la ultima ocurrencia de la subcadena. 

int indice = 0;
String cadena = "Hola a todos. Hola";
...
...
indice = cadena.LastIndexOf("Hola");

<<<><<<<<<<<<<<>>>>><<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>><<<<<<<<<<>>>>>><<<<<

📚 272

// Justificacion de texto : Hasta el momento hemos visto metodos para manipular cadenas. pero tambien hay otros metodos que sirven para hacer otras modificaciones. Por ejemplo justificar el texto hacia la derecha , supongamos que tenemos
// una cadena de 10 caracteres como "0123456789"
// para justificarla necesitamos saber el tamaño de la cadena resultante sera de 25 caracteres. Esto nos daria 15 caracteres del que tenemos que insertar del lado izquierdo para obtener "0123456789" que se encuentran justificada hacia la derecha. para esto necesitamos un metodo que nos permita empotrar esos caracteres de espacio. El metodo que nos permite es 
// PadLeft(); requiere de un parametro que es la cantidad de caracteres de la cadena final. este es un valor entero y representa los caracteres originales mas los espacios en blanco.


String cadena = "Hola";
String resultado = "";
...
...
resultado = cadena.PadLeft(10);

"" "" "" "" "" "" "h" "o" "l" "a"

// Tambien se puede justificar hacia la izquierda en este caso los caracteres en blanco seran insertados hacia la derecha de la cadena. Para esto usaremos el metodo equivalente a.
// PadLeft(). tambien se necesita un parametro que es un valor entero que indica la cantidad total de caracteres de la cadena final.


<<<><<<<<<<<<<<>>>>><<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>><<<<<<<<<<>>>>>><<<<<

📚 273

// Para eliminar caracteres de la Cadena : Otra manipulacion que podemos hacer sobre la cadena es la eliminacion de caracteres. Es posible borrar determinada parte de la cadena. segun sea lo que necesitamos en la logica del programa.
// El metodo que podemos utilizar se conoce como Remove() este metodo esta sobrecargado pero veremos la version mas flexible , la eliminacion de los caracteres puede hacerse en cualquier parte de la cadena. solo debemos teber cuidado de generar un error. 
// El metodo Remove() necesita dos parametros. y valores enteros El primer parametro se usa para indicar el indice a partir del cual se empezara a eliminar los caracterer de la cadena y el segundo parametro colocamos la cantidad de caracteres a eliminar , el metodo regresa una cadena que es la resultante de la eliminacion 


String cadena = "hola mundo , hola a todos";
String resultado = "";
...
...
resultado = cadena.Remove(12,4);


<<<><<<<<<<<<<<>>>>><<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>><<<<<<<<<<>>>>>><<<<<

📚 274


// Como Remplazar una Subcadena : Remplazar una parte de la cadena principal con otra cadena puede ser un proceso que toma tiempo programar. esto se debe a que necesitamos encontrar la subcadena a eliminar, luego eliminarla y al final introducir los caracteres de la nueva cadena.Como siempre la clase String nos provee de un metodo que nos facilita la manipulacion de las cadenas para el remplazo. Este es el metodo Replace(). Existen dos versiones una funciona con caracteres y la otra con cadenas.
// Es esta la que usaremos. Esto nos permite remplazar una palabra en particular contenida dentro de la cadena por otra palabra. El metodo llevara a cabo el remplazo en todas las ocurrencias de la palabra que tengamos.
// El metodo necesita dos parametros. el primero es la cadena que simboliza la palabra que deseamos remplazar . el Segundo es la cadena con que vamos remplazar. El metodo regresa una cadena que es el resultado con los remplazos.

String cadena1 = "Hola a todos , Hola Mundo";
String cadena2 = "Adios";
String Resultado = "";


resultado = cadena1.Replace("Hola", cadena2);

// Como se ve. es posible colocar el parametro de forma explicita o por medio de una variable.


// Cómo dividir la cadena
// Otro problema clásico con la manipulación de las cadenas es la subdivisión cuando se
// encuentra algún carácter en particular. Por ejemplo, si la cadena contiene un párrafo
// de un texto, podemos dividirla en subcadenas, cada una de ellas delimitada por un
// signo de puntuación. Para lograr esto necesitamos tener un arreglo de caracteres que
// contenga los caracteres que tomaremos como delimitadores. Cada vez que el método encuentre uno de estos caracteres, llevará a cabo el corte de la subcadena. 
// El método que usaremos se conoce como Split(), éste sólo requiere de un parámetro, que es el arreglo de caracteres delimitadores. El método regresará un arreglo de tipo String. Cada uno de los elementos presentes en el arreglo regresado será una de las subcadenas que se habrán recortado. Después debemos proceder a
// hacer uso de las cadenas en el arreglo y procesarlas o utilizarlas según sea necesario en la aplicación que estamos desarrollando.

String cadena = "Hola a todos . Este es un ejemplo de lo que podemos hacer");

String resultado[] = cadena.Split(new char[] {',', '.' , ';'});

<<<><<<<<<<<<<<>>>>><<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>><<<<<<<<<<>>>>>><<<<<

📚 275

// Intercambiar mayúsculas y minúsculas
// En muchas ocasiones tendremos cadenas que estarán escritas con letras en mayúscula y minúscula mezcladas, pero puede suceder que para facilitar la lógica de
// aplicación debamos tener la cadena exclusivamente en mayúscula o minúscula
// Esto nos puede ayudar a reducir la cantidad de comparaciones o búsquedas que
// necesitamos hacer. Si lo que deseamos hacer es convertir la cadena a minúscula,
// entonces debemos hacer uso del método ToLower(). Este método no necesita ningún parámetro. La fuente de información para hacer la conversión es la misma
// cadena que lo invoca, pero en esta ocasión nos daremos cuenta de que el método
// sí se encargará de regresar un valor, el valor que se devuelve será la cadena convertida totalmente a letras minúsculas. 
// Por ejemplo, podemos tener lo siguiente

String cadena = "Hola Hola";
String resultado = "";
...
...
resultado = cadena.ToLower();

// Al finalizar el código la variable resultado tendrá en su interior a la cadena “hola hola”.
// De forma similar, podemos pasar la cadena a mayúscula. La forma de hacer esto es
// con el método ToUpper(), que toma la cadena y pasa todas sus letras a mayúscula.
// El método no necesita ningún parámetro, ya que al igual que ToLower(), toma la
// información directamente de la cadena que lo invoca y regresa una cadena, que es
// la resultante con todas las letras en mayúscula.

String cadena = "Hola Hola";
String resultado = "";
....
....
resultado = cadena.ToUpper();


// La variable resultado tendrá en su interior “HOLA HOLA”.
// Los dos métodos tienen otra versión que tiene en cuenta las reglas culturales para poder llevar a cabo la conversión. En ese caso tendríamos que pasar como parámetro el
// identificador de la cultura que se usará como base para convertir los caracteres.
// En MSDN podemos encontrar la información sobre los diferentes identificadores
// de cultura que puede manejar .NET. Para hacer uso del identificador de cultura
// debemos usar un objeto de tipo CultureInfo. En su constructor debemos pasar el ID
// de la cultura correspondiente. Por ejemplo, para pasar a mayúscula con las reglas de
// la cultura en México podemos colocar lo siguiente:

String cadena = "Hola Hola";
String resultado = "";
...
...
resultado = cadena.ToUpper("new CultureInfo("es-MX"));

<<<><<<<<<<<<<<>>>>><<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>><<<<<<<<<<>>>>>><<<<<

📚 277

// Cómo podar la cadena
// Cuando trabajamos con las cadenas podemos encontrarnos con situaciones como
// cuando la cadena tiene exceso de espacios, ya sea al inicio o al final. Algunas veces
// esto puede ser útil, como cuando justificamos, pero otras veces estos espacios extras
// pueden ser indeseados. Los espacios extras al inicio o al final pueden deberse a operaciones realizadas sobre la cadena o simplemente a entradas erróneas del usuario,
// y para librarnos de estos caracteres tenemos diferentes opciones. En primer lugar
// conoceremos un método que elimina los espacios en blanco extras tanto al inicio
// como al final de la cadena. Este método se conoce como Trim().
// El uso de Trim() es muy sencillo ya que no necesita ningún parámetro, simplemente
// trabajará sobre la cadena que lo invoca. Este método regresará una cadena nueva,
// que es la cadena original sin los espacios extras.
// Es necesario que tengamos en cuenta que la cadena original no se modifica, por esta razón recibiremos una cadena completamente nueva


String cadena = "Hola a todos";
String resultado = "";
...
...
resultado = cadena.Trim();

// En la cadena resultado tendremos “Hola a todos”, que es la cadena sin los espacios
// extras. El método Trim() poda los espacios tanto del inicio como del final de la cadena. Sin embargo, puede haber ocasiones en las que necesitemos podar únicamente el
// inicio de la cadena. El método para lograr esto es TrimStart(). Este método es un poco más complejo que Trim() ya que necesita un parámetro. Este parámetro es un arreglo de caracteres y en él tenemos que colocar los caracteres que nos interesa extraer del
// inicio de la cadena. El método regresará otra cadena, que es la resultante de la cadena
// original sin los caracteres podados a su inicio.
// Es posible que creemos el arreglo de caracteres o también que lo coloquemos explícitamente. Es conveniente pensar bien cuáles serán los caracteres a podar para evitar la eliminación de caracteres que sí pueden ser útiles.
// Veamos cómo podemos utilizar este método

String cadena = "x x x x x x Hola a todos 
            ";
String resultado = "";            


resultado = cadena.TrimStart('','x');

// En este ejemplo se podan los caracteres espacio y x. La cadena final resultante es
// “Hola a todos. “. Debemos notar que los caracteres al final no han sido podados, ya que solamente trabaja sobre los caracteres al inicio de la cadena.
// Si lo que necesitamos es podar el final de la cadena, entonces tenemos que usar
// el método TrimEnd(). Este método es equivalente a TrimStart(), pero funciona
// únicamente al final de la cadena.
// Recordemos que el método necesita un parámetro. El parámetro es un arreglo de
// caracteres. En este arreglo es necesario que coloquemos los caracteres que deseamos
// eliminar del final de la cadena con la que trabajamos. El método correspondiente
// se encargará de regresar una cadena, está será el resultado sin los caracteres que fueron eliminados al final de la cadena original.
// Veamos un ejemplo del uso de este método

String cadena = "x x x x x x hola a todos";
String resultado = "";
...
...
resultado = cadena.TrimEnd('','');

// En la cadena de resultado tendremos “x x x x x x Hola a todos”, el espacio fue eliminado al final ya que se encuentra dentro de la lista de caracteres a podar.
// Con esto hemos visto el uso y la manipulación de las cadenas, así como los métodos más importantes que nos permiten trabajar con ellas

<<<><<<<<<<<<<<>>>>><<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>><<<<<<<<<<>>>>>><<<<<

📚 282

// Estructuras y enumeraciones : 

// En este capítulo aprenderemos un tema
// muy útil. Empezaremos por cómo utilizar
// los tipos definidos por el programador,
// es decir, los tipos de datos definidos
// por nosotros. Estos tipos nos darán
// la flexibilidad de poder guardar
// lo que nosotros necesitemos en nuestra
// aplicación y poder utilizarlos de forma
// similar a las variables

// Las estructuras
// Las estructuras son tipos definidos por el programador y son un conjunto de datos
// agrupados. Supongamos que programamos una agenda telefónica. Desde luego, la
// agenda necesita guardar mucha información, por lo que ya hemos pensado en usar
// arreglos. Pero también necesitamos pensar en los datos que debe contener como:
// nombre, edad, teléfono. Esto nos lleva a tener tres arreglos. Si necesitamos más datos, entonces más arreglos serán necesarios. Al final es posible que sea un poco complicado administrar tantos arreglos y esto reduce la flexibilidad de nuestro software.
// Lo mejor sería poder agrupar esa información, de forma tal que solamente tengamos que administrar un solo arreglo. La forma de poder agrupar la información
// es por medio del uso de las estructuras.
// Cuando creamos una estructura, definimos un nuevo tipo y adentro de este tipo
// podremos colocar datos. Estos datos se conocen como campos. Cada campo está
// representado por una variable, que puede ser de cualquier tipo. Luego que hemos
// terminado de definir la estructura podemos crear variables de esta estructura y guardar la información que necesitemos en ellas.

// Cómo definir una estructura
// Definir una estructura es sencillo. Sin embargo, el primer paso no se lleva a cabo en
// la computadora. Lo primero que tenemos que hacer es encontrar cuáles son los campos y el tipo que debe guardar la estructura. En el programa la definiremos utilizando el código que comentamos en el siguiente bloque:


acceso struct nombre
{
 acceso tipo campo1
 ....
 acceso tipo campo2
}


// El acceso indica si la estructura puede verse por afuera del ámbito donde ha sido
// definida o no. Si el acceso es de tipo público, se puede acceder a la estructura por
// afuera del ámbito. Para esto pondremos como acceso public. Si no deseamos que
// el exterior pueda acceder a la estructura, entonces la colocamos como privada.
// Para esto colocamos el acceso como private. En este libro siempre trabajaremos
// con acceso de tipo public. Para indicar que definimos una estructura usamos struct
// seguido del nombre de la estructura. Éste puede ser cualquier nombre válido en
// C#. No hay que confundir el nombre de la estructura con la o las variables que
// usaremos de ella. Con este nombre identificaremos el nuevo tipo. 
// Luego tenemos que crear un bloque de código. Dentro de este bloque definiremos
// los campos que necesitamos. Éstos se definen igual que las variables, pero es necesario colocar el acceso. En este libro utilizaremos un acceso de tipo public, de forma tal que podamos leer la información contenida adentro de la estructura.
// Por ejemplo, la estructura de nuestra agenda puede ser definida de la siguiente forma:

<<<><<<<<<<<<<<>>>>><<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>><<<<<<<<<<>>>>>><<<<<

📚 283

public struct agenda
{
    public String Nombre;
    public int Edad;
    public String Telefono;
}

// Así de sencilla es la definición. Ya tenemos una estructura llamada Agenda que contiene los campos: Nombre, Edad y Telefono

// Nosotros podemos definir tantas estructuras como sean necesarias y también cada
// estructura puede tener la cantidad necesaria de campos


<<<><<<<<<<<<<<>>>>><<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>><<<<<<<<<<>>>>>><<<<<

📚 284


// Cómo crear una variable del nuevo tipo
// Ya que tenemos definida la estructura, es necesario poder definir sus variables
// para guardar información. Como hemos realizado la declaración de un nuevo tipo, entonces nos será posible crear variables de ésta, y la forma de hacer esto es
// similar a la de cualquier otro tipo.
// Para definir la variable sólo deberemos poner el nombre del tipo seguido del nombre que le daremos a nuestra variable. No debemos olvidar colocar ; (punto y coma) al final de la sentencia. Supongamos que deseamos crear una variable cuyo
// nombre será amigo y es del tipo agenda.

Agenda amigo;

// Ahora, adentro del nuevo tipo de variable declarada llamada amigo, se encuentran
// los campos Nombre, Edad y Telefono. Es posible declarar varias variables de Agenda

Agenda amigo1 , amigo2 , amigo3;


// En el caso de necesitar hacer uso de éste, podemos crear un arreglo de la estructura. Este arreglo puede ser del tamaño que necesitemos para nuestra aplicación, y es
// entonces de esta forma que para la estructura agenda podemos tener un arreglo
// donde guardamos la información de los amigos, y otro arreglo donde se guardará
// la información de los clientes

Agenda[] amigos = new Agenda[15];
Agenda[] clientes = new Agenda[5];


<<<><<<<<<<<<<<>>>>><<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>><<<<<<<<<<>>>>>><<<<<

📚 285


// Cómo acceder a los campos de la estructura
// Ya tenemos variables de la estructura y sabemos que adentro de éstas se encuentran los campos que guardarán la información. Tenemos que tener acceso a los
// campos para poder guardar, leer o modificar los datos. El acceso al campo se lleva a cabo de la siguiente manera:

VariableEstructura.Campo

// Esto quiere decir que primero debemos indicar cuál es la variable con la que deseamos trabajar. Luego necesitamos utilizar el operador punto y seguido de él colocamos el nombre del campo a acceder. Veamos un ejemplo de esto:

amigo.Edad = 25;

// En este caso decimos que al campo Edad de la variable amigo le colocamos en su
// interior el valor 25. Podemos utilizar los campos en cualquier tipo de expresión válida, tal y como una variable:

if(amigo.Edad>18)
{
    ....
    diasVividos = amigo.Edad * 365;
    ...
    Console.WriteLine("el nombre es {0}",amigo.Nombre);
}

// Cómo mostrar los campos de la estructura
// Algo que necesitaremos constantemente es presentar los campos de la estructura.
// La manera más evidente de hacerlo es con el método WriteLine(). Simplemente
// mostramos el contenido del campo como si fuera otra variable del programa


<<<><<<<<<<<<<<>>>>><<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>><<<<<<<<<<>>>>>><<<<<

📚 286

Console.WriteLine("la edad es {0}",amigo.Edad);

// Esta forma es sencilla y útil en los casos en los que solamente necesitamos mostrar
// un campo de la estructura. Sin embargo, de necesitar mostrar todos los campos,
// deberemos colocar WriteLine() para cada campo, o uno solo con una cadena de
// formato larga. En cualquier caso resulta incómodo.
// La mejor forma de mostrar todos los datos contenidos en los campos sería mediante la conversión de la estructura a una cadena. Sabemos que existe un método llamado ToString() que hemos usado con las variables numéricas. Sin embargo, C# no
// se lo puede dar directamente a nuestra estructura porque no puede saber cuáles son
// los campos que contiene ni cómo los deseamos mostrar. Por esto, cae en nuestra
// responsabilidad programar el método ToString() de nuestra estructura.
// Veamos esto en el siguiente ejemplo

public struct Agenda
{
    public String Nombre ;
    public int Edad;
    public String Telefono;

}

public override String ToString()
{
    StringBuilder sb = new StringBuilder();
    sb.AppendFormat("Nombre : {0} , Edad : {1} , Telefono : {2} " , Nombre , Edad , Telefono);
    return (sb.ToString());
}

// Podemos observar que adentro del bloque de código de la estructura hemos colocado nuestra versión del método ToString(). El acceso debe ser público para que se
// pueda invocar desde el exterior de la estructura. Este método debe regresar un objeto de tipo String y no necesita ningún parámetro.
// En el interior del método simplemente colocamos el código necesario para darle formato a la cadena y en nuestro caso hacemos uso de StringBuilder, aunque es válido
// usar cualquier otro método. Al finalizar ya tenemos la cadena con la información
// de nuestros campos y la regresamos por medio de return. 
// Ahora que ya tenemos implementado ToString() mostrar la información contenida será tan sencillo como:

Console.WriteLine(amigo.ToString());


<<<><<<<<<<<<<<>>>>><<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>><<<<<<<<<<>>>>>><<<<<

📚 287


// Veamos un ejemplo completo de estos conceptos:

public struct Agenda 
{
    public String Nombre;
    public int Edad;
    public String Telefono;
}

public override String toString()
{
    StringBuilder sb = new StringBuilder();
    sb.AppendFormat("Nombre : {0} , Edad : {1} , Telefono : {2}",Nombre , Edad , Telefono);
    return (sb.ToString());
}


static void Main(string[]args)
{
    
// TODO: agregar aquí código para iniciar la aplicación
   Agenda []amigos = new agenda[5]; 
   amigos[1].Edad =25;
   amigos[1].Nombre = "Tomas";
   amigos[1].Telefono = "(555) 123-4567";
   Console.WriteLine(amigos[1].ToString());
}


<<<><<<<<<<<<<<>>>>><<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>><<<<<<<<<<>>>>>><<<<<

📚 288

// Como parte del ejemplo creamos un arreglo de la estructura Agenda que se llama
// amigos y tiene 5 elementos, luego, para el elemento en el índice 1 colocamos los
// datos. Para finalizar simplemente imprimimos el elemento 1 del arreglo amigos,
// pero usamos el método ToString() programado por nosotros. Si compilamos y ejecutamos el programa obtendremos lo siguiente:

// Creación de un constructor para la estructura
// En el ejemplo anterior hemos visto la manera de cómo cada uno de los campos
// que componen la estructura ha tenido que inicializarse en forma individual. Esto
// es correcto y no presenta ningún problema, sin embargo, hay una forma de poder inicializar los campos más fácilmente, sin tantas complicaciones.
// Para hacer esto podemos hacer uso de un constructor. El constructor no es otra cosa que un método que nos permitirá llevar a cabo la inicialización de los campos. Sin
// embargo, este método tiene algunas características especiales. La primera característica es que siempre se llamará igual que la estructura a la que pertenece. La segunda es
// muy importante: el constructor se invoca automáticamente cuando llevamos a cabo
// la instanciación de la variable de la estructura. La última característica del constructor
// es que no tiene tipo. No sólo no regresa nada, no tiene tipo


<<<><<<<<<<<<<<>>>>><<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>><<<<<<<<<<>>>>>><<<<<

📚 289

// Adentro del constructor podemos colocar cualquier código válido de C#, pero es
// evidente que colocaremos código dedicado a la inicialización de los campos. Veamos un primer ejemplo de cómo podemos crear un constructor. El constructor siempre va adentro del bloque de código de la estructura.

public Agenda(String pNombre , pEdad , pTelefono)
{
     Nombre = pNombre;
     Edad = pEdad;
     Telefono = pTelefono;
}



// En el código del constructor vemos que el acceso es público. Esto es necesario y
// siempre debemos dejarlo así. Si observamos luego se coloca directamente el nombre del constructor. El nombre es Agenda, ya que pertenece a la estructura Agenda.
// A continuación tenemos la lista de parámetros. Los valores pasados como parámetros serán asignados a los campos correspondientes. En la declaración de la variable
// lo tendremos que usar de la siguiente forma:

Agenda amigo = new Agenda("Tomas",34,"(544) 123456789");


// Aquí vemos que declaramos la variable amigo que es de tipo Agenda. Al hacer la instanciación por medio de new vemos que pasamos los parámetros. Éstos serán los
// datos que quedarán guardados en los campos de la variable amigo. La cadena “Juan”
// quedaría adentro del campo Nombre, el valor de 25 adentro del campo Edad y la cadena “(555) 123-4567” en el campo Telefono.
// Veamos cómo quedaría un programa completo con el constructor

<<<><<<<<<<<<<<>>>>><<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>><<<<<<<<<<>>>>>><<<<<

📚 290

public struct Agenda
{
   public String Nombre;
   public int Edad;
   public String Telefono;

   public Agenda(String pNombre , pEdad , pTelefono)
    {
     Nombre = pNombre;
     Edad = pEdad;
     Telefono = pTelefono;
    } 

    public override String ToString()
    {
        StringBuilder sb = new StringBuider();
        sb.AppendFormat("Nombre : {0} , Edad :{1} , Telefono :{2}" , Nombre , Edad , Telefono);
        return (sb.ToString());
    }
}

static void Main(string[]args)
{
    // TODO: agregar aquí código para iniciar la aplicación
    Agenda amigo = new Agenda("Tomas",34,"(544) 123456789");
    Console.WriteaLine(amigo.ToString());
}

// Ejecutemos el programa y veamos el resultado que obtenemos

<<<><<<<<<<<<<<>>>>><<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>><<<<<<<<<<>>>>>><<<<<

📚291 - 294

// Cómo usar el constructor para validar información
// El constructor no solamente puede ser utilizado para colocar la información
// adentro de los campos, una de las grandes ventajas que éste nos da es la posibilidad de poder validar la información antes de que sea asignada a uno de sus campos. Es posible que existan ciertas reglas sobre lo que se considera información
// válida para nuestros campos, y por supuesto, podemos implementar estas mismas en el constructor. 
// Supongamos que el teléfono sólo se considera válido si tiene más de 8 caracteres.
// En caso de que sea menor es inválido y no debe ser asignado para evitar problemas. Esta simple regla es fácil de programar en el constructor. En nuestro caso
// podría quedar de la siguiente forma:

public Agenda(String pNombre , int pEdad , String pTelefono)
{
    // llevamos a cabo la asignacion .
    Nombre = pNombre;
    Edad = pEdad;
    if(pTelefono.Length > 8)
    {
       Telefono = pTelefono     
    }
    else
    {
       Telefono = "El numero de telefono esta Incorrecto el Formato";  
    }
}


// El programa completo es el siguiente

public Struct Agenda
{
    public String Nombre ;
    public int Edad;
    public String Telefono;
    // Constructor
    public Agenda(String pNombre , int pEdad , String pTelefono)
    {
        // Levamos a la asignacion 
        Nombre = pNombre;
        Edad = pEdad;
        if(pTelefono.Length>8)
        {
            Telefono = pTelefono;
        }
        else
        {
            Telefono = " Numero de telefono Invalido";
        }

        public override String ToString()
        {
              StringBuilder sb = new StringBuilder();
              sb.AppendFormat("Nombre : {0} , Edad : {1} , Telefono : {2}" , Nombre , Edad , Telefono); 
              return (sb.ToString()); 
        }
    }

    static void Main(string[]args)
    {
        // Agregar codigo para Iniciar Aplicacion 
        Agenda amigo = new Agenda("Tomas",25,"(555)1234567");
        Agenda amigo1 = new Agenda("Pedro",32,"(555)");
        Console.WriteLine(amigo.ToString());
        Console.WriteLine(amigo1.ToString());
    }

    // Si compilamos y ejecutamos el programa tendremos el siguiente resultado

}
    // Nota : 
// Sobrecarga es una técnica de programación que permite tener varias versiones de una función o un
// método. El compilador selecciona la versión a utilizar basándose en la cantidad de parámetros y los
// tipos. Esto nos permite agrupar métodos diferentes bajo un mismo nombre o concepto, facilitando
// la programación, solamente recordando un nombre, y no los nombres para cada versión.

// La sobrecarga del constructor
// El constructor puede ser sobrecargado y esta habilidad nos brinda mucha flexibilidad para poder utilizarlo. Supongamos que tenemos amigos que tienen teléfono
// y otros que no. Si no tienen teléfono, no tiene sentido utilizar un constructor que
// lo solicite. Lo mejor sería tener una segunda versión del constructor que solamente

🛑 Paginas 295
// necesite el nombre y la edad, y podemos hacer que esta versión coloque un mensaje que indique que no tiene teléfono.
// Para hacer la sobrecarga colocamos la segunda versión debajo de la que ya tenemos. 
// Por ejemplo, nuestra segunda versión queda de la siguiente forma

public Agenda(String pNombre , int pEdad)
{
    // Llevamos a cabo la asignacion.
    Nombre = pNombre;
    Edad = pEdad;   
    Telefono = "Sin Telefono";

}

// Como podemos ver, solamente recibimos dos parámetros, pero aun así los tres campos son asignados con un valor. Ningún campo se queda sin asignar. Para declarar
// la variable le pasamos los 2 parámetros necesarios.

Agenda amigo = new Agenda("Tomas", 36);

// Veamos un ejemplo que utilice la sobrecarga del constructor de la estructura

public struct Agenda
{
    public string Nombre;
    public int Edad;
    public String Telefono;

    public Agenda(String pNombre , int pEdad , String pTelefono)
    {
        // llevamos a cabo la asignacion.
        Nombre = pNombre;
        Edad = pEdad;
        if(pTelefono.Length > 8 )
        {
🛑 Paginas 296
            Telefono = pTelefono;
        }
        else
        {
            Telefono = "El telefono no es valido ";
        }
    }

    public Agenda(String pNombre , int pEdad)
    {
        // llevamos a cabo la asignacion sin agregar el campo telefono
            Nombre = pNombre;
            Edad = pEdad;
            Telefono = " Sin Telefono ";   
    }

    public Agenda(String pNombre)
    {
        // Asignamos el nombre
        Nombre = pNombre;
        //Pedimos la edad 
        Console.WriteLine("Dame la Edad ");
        Edad = Convert.ToInt32(Console.ReadLine());
        // Pedimos el telefono
        Console.WriteaLine("Dame el telefono");
        telefono = Console.ReadLine();
        if(Telefono.Length < 8 )
        {
            Telefono = "El numero es incorrecto , Debe Agregar  un numero Valido";
        }    
    }   

    public override String ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendFormat("Nombre : {0} , Edad : {1} , Telefono : {2}",Nombre , Edad , Telefono);
        return(sb.ToString());
    }

    static void Main(string[]args)
    {
        Agenda amigo = new Agenda("Tomas" , 27, "(555)12345678");
        Agenda amigo1 = new Agenda("Luis" 41 , "(555) 14575448");
        Agenda amigo2 = new Agenda("Carlos" , 54);
        Console.WriteLine(amigo.ToString());
        Console.WriteLine(amigo.ToString());
        Console.WriteaLine(amigo2.ToString());
    }
}

🛑 Paginas 297
// Si compilamos la aplicación, veremos el resultado en la siguiente figura:    

// Incluso podemos hacer que el constructor le solicite la información directamente
// al usuario. Hay que recordar que podemos colocar cualquier código válido en su
// interior. Esto lo logramos al crear una nueva sobrecarga.
// Veamos cómo puede quedar esta nueva versión del constructor:

public Agenda(String pNombre)
{
    // Asignamos el nombre
    Nombre = pNombre;
    //Pedimos la edad 
    Console.WriteLine("Dame la Edad ");
    Edad = Convert.ToInt32(Console.ReadLine());
🛑 Paginas 298 
    // Pedimos el telefono
    Console.WriteaLine("Dame el telefono");
    telefono = Console.ReadLine();
    if(Telefono.Length < 8 )
    {
        Telefono = "El numero es incorrecto , Debe Agregar  un numero Valido";
    }    
}

// Lo primero que hacemos es asignar el nombre que hemos recibido por parámetro.
// Luego de la forma usual pedimos la edad, notando cómo está colocada la sentencia. Sabemos que ToInt32() necesita un parámetro que es la cadena a convertir y
// ReadLine() regresa una cadena. De esta forma, aprovechamos y colocamos todo el
// código adentro de una sola línea. Otra opción que podríamos haber utilizado es
// una función que pida el dato, tal y como lo vimos en un capítulo anterior. Enseguida solicitamos el teléfono y aprovechamos para validar la información.
// El programa completo queda de la siguiente manera:



// Notas : CONSTRUCTOR EN LA ESTRUCTUR
// Cuando utilizamos el constructor con nuestra estructura o cuando tenemos sobrecargas, tenemos
// que tener cuidado con la cantidad de parámetros. Dentro de las estructuras el constructor
// necesita tener al menos un parámetro ya que no es válido colocar un constructor sin parámetros.
// Si olvidamos colocar los parámetros, tendremos un error durante la compilación del programa



🛑 Paginas 301
// Estructuras enlazadas
// Las estructuras nos dan la facilidad de poder agrupar información que está relacionada adentro de un mismo elemento. Ya vimos que se puede colocar como dato a
// cualquier tipo que sea válido en C#. Estos tipos válidos también corresponden a tipos definidos por el programador, es decir otras estructuras.
// Tenemos una estructura que se llama Agenda, pero esta agenda está un poco incompleta, debido a que nos hace falta colocar la dirección o el domicilio de la persona. Esto lo podemos resolver de una manera práctica, colocando dos campos
// nuevos como la calle y el número de la casa, pero también podríamos pensar en
// otra estructura llamada Direccion que contenga esta información.
// Por ejemplo, la estructura podría quedar de la siguiente forma

public struct Direccion 
{
    public String Calle ;
🛑 Paginas 302 
    public Int Numero;

    public Direccion(String pCalle , int pNumero)
    {
       Calle = pCalle;
       Numero = pNumero;     
    }
}



// Como vemos, los campos son Calle y Numero. Se ha creado un constructor para ayudarnos a colocar la información fácilmente cuando se instancie una variable de este nuevo tipo. Ahora que ya tenemos definido el nuevo tipo Direccion, podemos
// usarlo en nuestra estructura Agenda, pero serán necesarios algunos cambios.
// Primero veamos cómo agregar un campo de tipo Direccion a la estructura

public struct Agenda
{
    public String Nombre;
    public int Edad;
    public String Telefono;
    public Direccion Domicilio;
}

// Agregar un campo es muy sencillo, simplemente definimos la variable. Sin embargo, si dejamos la estructura con ese cambio tendremos problemas, ya que el campo
// Domicilio no estará instanciado. Esta instanciación se puede llevar a cabo cuando se
// asignan los datos, por ejemplo, en el constructor.
// Cambiemos el primer constructor para instanciar y asignarle datos al campo Domicilio

public Agenda(String pNombre , int pEdad, String pTelefono , String pCalle , int pNumero )
{
  // LLevamos a cabo la asignacion 
     Nombre = pNombre;
     Edad = pEdad;
     if(pTelefono.Lengt>8)
     {
🛑 Paginas 303
       Telefono = pTelefono;
     }
     else
     {
        Telefono = " Telefono no validos";
        Domicilio = new Direccion(pCalle , pNumero);
     }
}

// Vemos que hemos llevado a cabo algunos cambios. En primer lugar, el constructor
// de Agenda recibe todos los datos necesarios, incluidos los de la estructura Direccion.
// En el interior del constructor asignamos los datos que le corresponden a Agenda y
// en la parte final hacemos la instanciación de Domicilio por medio de new y le pasamos a su constructor los datos que le corresponden. También puede suceder que el
// constructor de Agenda no reciba los datos de Domicilio. En ese caso, debemos instanciar también al campo domicilio y pasar algunos datos de default al constructor

public Agenda(String pNombre , int pEdad)
{
    // llevamos a cabo la asignacion
    Nombre = pNombre;
    Edad = pEdad;
    Telefono = "Sin Telefono";
    Domicilio = new Direccion ("Sin Direccion " , 0);
}
    
// En este caso, vemos que la instanciación se lleva a cabo, pero simplemente pasamos
// algunos parámetros de default. Si continuamos con estos cambios, el programa quedará de la siguiente manera:


public struct direccion 
{
    public String Calle;
    public int Numero;

    public direccion(String pCalle , int pNumero)
    {
⭕ Paginas 304 
    Calle = pCalle;
    Numero = pNumero;
    }

    public struct Agenda
    {
        public String Nombre;
        public int Edad;
        public String Telefono;
        public Direccion Domicilio;

        public Agenda(String pNombre , int pEdad , String pTelefono , String pCalle , int pNumero) 
        {
            // llevamos a cabo la asignacion 
            Nombre = pNombre;
            Edad = pEdad;
            if(Telefono.Length>8)
            {
              Telefono = pTelefono;      
            }
            else
            {
                Telefono = "telefono no valido ";
            }
            Domicilio = new Direccion(pCalle , pNumero);
        }

        public Agenda(String pNombre , int pEdad)
        {
            // llevamos a cabo la asignacion
            Nombre = pNombre;
            Edad = pEdad;
            Telefono = "Sin Telefono";
            Domicilio = new Direccion("Sin Direccion " 0);
        }
⭕ Paginas 305
        public Agenda(String pNombre)
        {
            // Asignamos el Nombre.
            Nombre = pNombre;
            
            //Pedimos la edad 
            Console.WriteLine("Indiqueme su Edad ");
            Edad = Convert.ToInt32(Console.ReadLine);

            // Pedimos el telefono 
            Console.WriteLine("Indiqueme su numero de telefono");
            Telefono = Console.ReadLine();
            
            if(Telefono.Length<8)
            {
              Telefono = "Sin Telefono ";      
            }
           
            Domicilio = new Direccion("Sin direccion ", 0);
        }

        public override String ToString()
        {
            StringBuilder sb = new StringBuider();
            sb.AppenFormat("Nombre : {0} , Edad : {1} , Telefono : {2} , Nombre , Edad , Telefono");
            Return(sb.ToString());
        }        
    }

    static void Main(String[]args)
    {
        Agenda amigo = new Agenda("Juan" , 24 , "(555) 4545 878 8" , "Av Diagonal" 484);
        Agenda amigo1 = new Agenda("Pedro",38 , (555), "Calle dos" , 556);
        Agenda amigo2 = new Agenda("Tomas" , 28);
        Agenda amigo3 = new amigo("Lalal");
        Console.WriteLine(amigo.ToString());
        Console.WriteLine(amigo1.ToString());
        Console.WriteLine(amigo2.ToString());
        Console.WriteLine(amigo3.ToString());
    }

}


⭕ Paginas 306
// Podemos observar que en las variables amigo y amigo1 ya hemos colocado previamente los parámetros necesarios por el constructor modificado. Sólo queda que
// compilemos y ejecutemos el programa

// Al parecer tenemos un problema ya que obtenemos el mismo resultado que el programa anterior a pesar de los cambios. Esto sucede debido a que no hemos actualizado el método ToString() de Agenda ni creado el propio de Direccion.

⭕ Paginas 307


// Para Direccion
public override String ToString()
{
    StringBuilder sb = new StringBuilder();
    sb.AppendFormat("Direccion : {0}  #{1}" , Calle , Numero);
    return(sb.ToString());

}

// Para Agenda

public override String ToString()
{
    StringBuilder sb = new StringBuilder();
    sb.AppendFormat("Nombre : {0} , Edad:{1} , Telefono : {2}" , Nombre , Edad , Telefono);
    return(sb.ToString());

    // Adicionamos la cadena que viene de 
    // Domicilio    

    sb.AppendFormat(Domicilio.ToString());
    return(sb.ToString());

}

// Vemos que adentro del ToString() de Agenda agregamos la cadena que nos regresa el ToString() de Domicilio. De esta forma, cuando se impriman los contenidos
// de Agenda también se imprimirán los del campo Domicilio. El programa completo queda de la siguiente forma

public struct Direccion
{
    public String Calle;
    public int Numero;

    public Direccion(String pCalle , int pNumero)
    {
        Calle = pCalle;
        Numero = pNumero;
    }

⭕ Paginas 308
    public override String ToString()
    {
        StringBuilder sb = new StringBuider();
        sb.AppendFormat("Direccion : {0} #{1}" , Calle , Numero);
        return(sb.ToString());
    }

    public struct Agenda
    {
        public String Nombre;
        public int Edad;
        public String Telefono;
        public Direccion Domicilio;

        public Agenda(String pNombre , pEdad , pTelefono , String pCalle , int pNumero)
        {
            // LLevamos a cabo la asignacion 
            Nombre = pNombre;
            Edad = pEdad;
            if(pTelefono.Length > 8)
            {
                Telefono = pTelefono;
                else
                {
                    Telefono = "Numero de telefono no valido";
                    Domicilio = new Direccion(pCalle , pNumero);
                }
            }
        }

        public Agenda(String pNombre , int pEdad)
        {
            //LLevamos a cabo la asignacion
            Nombre = pNombre;
            Edad = pEdad;
            Telefono = "Debe Ingresar un numero de telefono";
            Domiilio = new Direccion("Sin Direccion" , 0);
        }

        public Agenda(String pNombre)
        {
            // Asignamos el nombre;
            Nombre = pNombre;

            //Pedimos la Edad
            Console.WriteLine("Dame la edad");
            Edad = Convert.ToInt32(Console.ReadLine());

            // Pedimos el telefono
            Console.WriteLine("Dame el telefono");
            Telefono = Console.ReadLine();
            if(Telefono.Length < 8)
            {
               Telefono = "Sin telefono";     
            }
⭕ Paginas 309            
            Domicilio = new Direccion("Sin Direccion" , 0);
        }

        public override String ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Nombre : {0} , Edad : {1} , Telefono : {2}" , Nombre , Edad , Telefono);
            // Adicionamos la cadena que viene  de domicilio ...
            sb.Append(Domicilio.ToString());
            return(sb.ToString());
        }

⭕ Paginas 310        
        static void Main(string[]args)
        {
            // Agregar aqui el codigo para iniciar la aplicacion .
            Agenda amigo = new Agenda("Tomas" , 41 , "(555)123456789" , "Calle Principal" , 457);
            Agenda amigo1 = new Agenda("Carlos" , 54 , "(555)" , "Calle Dos" , 4170);
            Agenda amigo2 = new Agenda("Cesar",28);
            Agenda amigo3 = new Agenda("Maria");

            Console.WriteLine(amigo.ToString());
            Console.WriteLine(amigo1.ToString());
            Console.WriteLine(amigo2.ToString());
            Console.WriteLine(amigo3.ToString());     
        }
    }

}

// Ahora ejecutemos el programa y veamos el resultado

⭕ Paginas 311

// Las enumeraciones
// Ya hemos aprendido las estructuras y ahora conoceremos otro nuevo tipo que puede ser definido por el programador. Este nuevo tipo se conoce como enumeraciones. Éstas son tipos que nosotros podemos definir, pero tendrán un número finito
// de valores posibles, es decir, que podemos definir el tipo y los valores a guardar.
// Las enumeraciones son útiles cuando tenemos información que sabemos que solamente puede tener uno de una serie de posibles valores. Por ejemplo, sabemos que
// la semana tiene siete días. Entonces, un día no puede tener un valor que no sea el
// de un día de la semana. La semana sería una enumeración. 
// Esto lo podemos utilizar para cualquier otro ejemplo donde sepamos los valores posibles a utilizar. Otro ejemplo, supongamos que estamos haciendo un programa para una empresa que vende quesos. Tendremos un número finito de posibles tipos
// de queso. Entonces, podemos colocarlos adentro de una enumeración.
// Al parecer, las enumeraciones son muy sencillas, pero podemos correr el riesgo de
// pensar que no son muy útiles. Sin embargo, nos dan grandes beneficios. También
// nos sirven para reducir la cantidad de errores que podemos tener en nuestra aplicación al asignar y utilizar valores. Como beneficio, reducen la lógica que debemos utilizar e incluso mejoran el desempeño de nuestra aplicación. Por eso es útil
// aprender a usarlas correctamente.

// Veamos un ejemplo donde podemos utilizar la enumeración para mejorar nuestra
// aplicación. Si nuestro programa necesita guardar por algún motivo el día de la semana podemos pensar en diferentes opciones. La primera puede ser la utilización
// de una variable de tipo entero, ya que cada día de la semana puede ser definido
// por un número del 1 al 7. Sin embargo, esto nos presenta algunos problemas. El
// primer problema es que usamos un tipo que puede guardar miles de valores posibles, pero sólo usamos 7, entonces tenemos un desperdicio de memoria.
// El segundo problema es que el tipo, al poder guardar muchos valores, puede guardar datos que no correspondan a la realidad como el día 8 de la semana. Para evitar esto necesitamos agregar lógica de control con el uso de uno o varios if. D

⭕ Paginas 312

// esta manera, se complica nuestra aplicación. Otro problema que esto nos presenta es el despliegue de la información. Cada vez que queremos mostrar el día tenemos que poner lógica para transformar 1 a “Lunes”, 2 a “Martes”, y así sucesivamente para poder listar cada día de la semana.
// Quizás otra solución sería el uso de una cadena para guardar el día de la semana, pero también presenta problemas. Un problema que podemos tener es que si nuestra
// lógica funciona con “Lunes”, cuando el usuario introduzca un valor como “lunes” ya
// no funcionará. Para corregir esto podemos usar el método ToUpper(), pero agrega
// más lógica y proceso extra a nuestra aplicación que no es necesario. También gastamos memoria de más ya que guardar una cadena requiere más memoria que
// guardar un simple número. Desde luego, la impresión sería más sencilla, pero la
// administración de la información más complicada.
// Nuestra mejor opción es el uso de las enumeraciones. Ahora aprenderemos cómo
// usarlas y cómo el problema anterior se resolvería fácilmente con ellas.

// Declaración y asignación de valores
// Para declarar una enumeración usamos el siguiente formato

enum nombre {valor1, valor2, …, valorn};

// En primer lugar, tenemos que colocar la palabra clave enum seguida del nombre con
// el que identificaremos al nuevo tipo de enumeración. Luego entre {} debemos colocar los valores que puede tener este tipo. Hay que recordar que los valores son finitos.
// Veamos cómo declarar una enumeración para nuestro ejemplo de la semana:

enum semana{Lunes , Martes , Miercoles , Jueves , Viernes , Sabado , Viernes};

// NOTA: LOS VALORES DE LAS ENUMERACIONES
//       Cuando declaramos la enumeración llevamos a cabo el listado de todos los valores posibles.
// Podemos pensar que internamente se guardan con un número de identificación. El primer
// elemento tendrá el valor de cero, el segundo de uno y así en forma consecutiva. Sin embargo,
// también es posible indicar cuál será el valor para el primer elemento de la enumeración.


⭕ Paginas 313

// En este caso, hemos declarado la enumeración con el nombre de semana. Cada uno
// de los días que hemos listado entre {} serán los posibles valores que puede tener. Con
// esto, el siguiente paso sería simplemente la creación de una variable de tipo semana.
// La declaración y asignación de la variable la hacemos de la forma tradicional.

semana miDia 

// Aquí declaramos la variable miDia que es de tipo semana, por lo que solamente podrá tener los valores listados en la enumeración. Si lo hubiéramos deseado, también
// podríamos haber declarado e inicializado la variable con algún valor.

semana miDia = semana.Martes;

// La asignación del valor en esta variable se puede llevar a cabo en cualquier momento,
// dentro de nuestra aplicación, después de su declaración, como en cualquier otra variable, pero con uno de los valores contenidos en semana.

miDia = semana.Viernes;

// Para imprimir el valor de una enumeración
// Si deseamos mostrar el valor de una variable de tipo enumeración, lo único que necesitamos es utilizar el método ToString(). Éste nos dará una cadena con el valor correspondiente y podemos utilizarla dentro de nuestra lógica para desplegar valores.
// El método ToString() regresa una cadena y esa cadena será el valor correspondiente. Por ejemplo, si en la enumeración listamos un valor como Lunes, entonces la
// cadena regresada será “Lunes”.

String Mensajes = "El dia es ";
...
...
...
Mensajes = Mensajes + miDia.ToString();

Console.WriteLine("El dia es {0} ",miIdea);


⭕ Paginas 314

// Para pasar de enumeración a valor numérico
// Si necesitamos pasar el valor de la enumeración a una variable numérica, lo único que necesitamos hacer es colocar un type cast. En nuestro ejemplo, Lunes al
// ser el primer valor definido, se pasará como 0 a la variable numérica, Miercoles
// será el valor 2 y así sucesivamente

int valor = 0;
...
...
...
valor=(int)miDia;


// Por ejemplo, supongamos que para nuestros propósitos en la enumeración de la semana, el día Lunes debe tener el valor 3. Para esto colocamos lo siguiente:

enum Semana{Lunes = 3 , Martes , Miercoles , Jueves , Viernes , Sabado , Domingo };

// De esta forma, Lunes tendrá un valor de 3, Martes de 4 y así sucesivamente hasta
// Domingo con un valor de 9

// La enumeración en expresiones
// Como nosotros trabajamos con una variable de tipo enumeración, podemos utilizarla en cualquier tipo de expresión. Sólo debemos ser cuidadosos con los tipos con
// los que interactuamos en la expresión. Si fuera necesario, podemos hacer uso de
// type cast para que la expresión quede correctamente escrita


⭕ Paginas 315

// Por ejemplo, para una expresión aritmética podemos realizar lo siguiente:

int Salario = 0;
int pagoDia = 200;
..
..
..
salario = pagoDia*((int)miDia);

// En las expresiones aritméticas es muy común que usemos type cast. Si lo deseamos,
// podemos hacer uso de los paréntesis para ayudarnos a leer la expresión. En una expresión relacional también podemos hacer uso de la enumeración. Si comparamos
// hacia el mismo tipo no es necesario hacer uso de un type cast.

if(miDia == semana.Martes)

type cast
if((int)miDia == 3)

// Dentro de una expresión lógica podemos hacer uso de algo similar

i((miDia>Semana.Lunes) && (int)miDia<5)


// Ejemplo de aplicación
// Ahora que ya conocemos los conceptos más importantes de las enumeraciones, es
// momento de hacer una aplicación. Nuestra aplicación será sencilla y simplemente
// probará los conceptos que hemos aprendido.
// Nuestra aplicación puede quedar de la siguiente manera:

⭕ Paginas 316

// Declaramos la enumeracion
enum Semana{Lunes,Martes,Miercoles,Jueves,Viernes};
enum Colores{Rojo = 1 , Verde , Azul , Amarillo};

static void Main(string[]args)
{
    int numerico = 0;
    //Creamos una variable de tipo Semana
    Semana miDia;
    // Asignamos un valor 
    miDia = Semana.Lunes;
    // Pasamos de enumeracion a Entero
    numerico = (int)miDia;
    // Mostramos la Informacion
    Console.WriteLine("El dia es {0} con valor {1} ",miDia , numerico);
    // Creamos una variable de color
    Colores miColor = Colores.Rojo;
    // Pasmaos a numero Entero
    numerico = (int)miColor;
    // Mostramos la informacion
    Console.WriteLine("El color es {0} con valor {1}",miColor , numerico);
}


// En primer lugar, declaramos dos enumeraciones. La primera es semana y Lunes
// tendrá como valor 0. La segunda enumeración se llama colores y la iniciaremos
// con un valor inicial Rojo que será 1.
// Dentro de la función Main() declaramos una variable de tipo entero, que usaremos
// para nuestros experimentos de convertir las enumeraciones a valores numéricos.
// Posteriormente, declaramos una variable de tipo semana llamada miDia. En la línea siguiente le damos el valor de Lunes contenido en la enumeración semana. A
// continuación convertimos miDia a entero y se lo asignamos a la variable numérico.
// Luego mostramos los valores de las variables. Creamos una variable de tipo colores e inmediatamente le asignamos el valor de Rojo de la enumeración colores. La
// convertimos a valor numérico y luego la mostramos. Si ejecutamos el programa,
// obtendremos la siguiente salida en la consola:

⭕ Paginas 317

// Con esto ya hemos aprendido a lo largo de este capítulo, en complemento con otros,
// las bases del manejo de las estructuras y las enumeraciones. Su uso es recomendable y debemos utilizarlas cuando tengamos programas grandes ya que nos ayudan a
// administrar la información y reducir la cantidad de errores.

// Resumen : Las estructuras nos permiten crear un tipo nuevo y agrupar información que está
// relacionada adentro de una unidad. Los datos adentro de la estructura se llaman campos.
// También es posible crear variables del tipo estructura y poder asignarles información a
// sus campos. El constructor nos ayuda a introducir la información original y a verificar que
// sea válida. Las estructuras pueden estar enlazadas. En las enumeraciones nosotros
// creamos un tipo que tendrá un número finito de valores posibles. Podemos darle un valor
// inicial a la enumeración e incluso convertirla a valores numéricos

⭕ Paginas 319

// Cómo crear
// nuestras
// propias clases:En este capítulo empezaremos a ver
// temas más avanzados. Hasta ahora
// hemos utilizado C# para la programación
// estructurada, pero ahora iremos hacia
// otro paradigma de programación,
// el de la orientación a objetos. C#
// es un lenguaje orientado a objetos, por
// lo que se puede obtener su mayor poder
// y beneficio si programamos con ese
// paradigma. Parte fundamental de la
// programación orientada a objetos es la clase.

⭕ Paginas 320

// La programación orientada a objetos
// La programación estructurada es muy sencilla e intuitiva. En ella simplemente
// tenemos un problema y lo subdividimos en problemas cada vez más pequeños.
// Usamos funciones para colocar zonas especializadas de código o código que se
// usa constantemente en su interior.
// El paradigma estructurado es correcto, pero tiene algunas limitaciones y algunos
// problemas cuando el programa a realizar es grande. Unos de estos problemas se
// conoce como la corrupción de información. Supongamos que tenemos una variable y ésta es utilizada en diversas partes del programa. Una forma sencilla para
// poder tener acceso a la variable es declararla de forma global, así todo el programa la conoce. Al hacer esto cualquier parte del programa no sólo puede leerla sino también modificarla. Debido a este esquema, una parte del programa puede
// cambiarse sin que otra sepa de este cambio y así se producen errores en la información. Para evitar esto es posible pasarle la variable como parámetro a quien la
// necesite, pero esto complica su administración. 
// Los programas estructurados muy grandes también son difíciles de extender y mantener, y llevar a cabo un cambio puede ser costoso. Generalmente, un cambio en una
// parte del programa produce cambios en otras partes que quizá no estén relacionadas
// directamente. En general, los programas estructurados son poco flexibles.
// La programación estructurada es buena para los programas pequeños y para
// aprender las bases de programación. Sin embargo, el mundo actual pide el desarrollo orientado a objetos. Como recomendación, después de este libro, podemos aprender análisis y diseño orientado a objetos y luego continuar aprendiendo más C# con todas las técnicas orientadas a objetos. Esto ya sería un nivel avanzando - experto de programación.
// En la programación orientada a objetos tomamos una idea diferente en la resolución
// de los problemas. En lugar de subdividirlos, lo que hacemos es ver cuáles son los componentes u objetos que componen el problema y la forma cómo interactúan. Nosotros programaremos estos objetos y haremos que se comuniquen entre sí. Cuando
// los objetos hagan su labor y se comuniquen, el problema estará resuelto.

// Las clases
// El componente principal de la programación orientada a objetos es la clase. Nosotros
// podemos pensar en la clase como si fuera un plano por medio del cual podemos crear objetos, por ejemplo, pensemos en una casa. Para hacer una casa lo primero que
// hacemos es pensar en los cuartos que deseamos que tenga y luego diseñamos un plano. El plano no es la casa, ya que no podemos vivir ni actuar en él. Sin embargo, éste nos proporciona las características de la casa. Por medio del plano podemos construir la casa y en esta construcción sí podemos llevar a cabo nuestras actividades


⭕ Paginas 321

// El plano sería equivalente a la clase y la casa construida al objeto. La clase es un plano, una descripción, y el objeto tiene esas características y puede llevar a cabo trabajo concreto. Si necesitásemos hacer otra casa igual, no sería necesario hacer un
// nuevo plano, simplemente tomaríamos el plano ya realizado y crearíamos otra casa. Una clase nos puede servir para crear muchos objetos independientes pero que
// tienen las mismas características. El proceso de crear un objeto a partir de una clase es lo que conocemos como instanciación.
// Adentro de la clase, nosotros colocaremos información y más importante aún,
// los métodos que trabajan sobre esta información, es decir, que los datos y los
// métodos que los procesan están contenidos dentro de una sola unidad. A esto lo
// llamamos encapsulamiento. Al encapsular datos y métodos los protegemos contra la corrupción de información.
// Los objetos se comunicarán por medio del uso de mensajes. En estos mensajes es posible solicitarle un dato a otro objeto, pedirle que lleve a cabo un proceso, etcétera.
// Los datos
// Los datos son la información con la que trabajará la clase. La clase solamente debe
// tener los datos que necesita para poder llevar a cabo su trabajo. Declarar un dato es
// muy similar a declarar una variable, pero al igual que en las estructuras, necesitamos indicar el acceso ya que tenemos básicamente tres tipos de acceso: público, privado y protegido. Cuando nosotros tenemos un dato con acceso público cualquier
// elemento del exterior, como la función Main() o algún otro objeto, puede acceder
// al dato, leerlo y modificarlo. Cuando tenemos el acceso privado solamente los métodos definidos dentro de la clase podrán leerlo o modificarlo. El acceso protegido
// es un poco más avanzado y está por afuera de los límites de este libro.
// Un punto muy importante con relación a los datos que no debemos olvidar es que
// los datos definidos en la clase son conocidos por todos los métodos de la misma clase. Es decir, actúan como si fueran globales para la clase. Cualquier método puede
// acceder a ellos directamente sin necesidad de que los pasemos como parámetro.
// En algunos casos podremos colocar el acceso a nuestros datos como público, aunque preferentemente no lo haremos. Si nos excedemos o usamos el acceso público
// en un mal diseño, corremos el riesgo de corrupción de información. Por lo general

// La Herencia : Es una característica de la programación orientada a objetos. Ésta permite crear una nueva
// clase que hereda las características (datos y métodos) de otra clase, de forma tal que solamente
// tengamos que agregar los elementos necesarios para la nueva. Es una gran forma de
// reutilización de código si se usa en forma adecuada.

⭕ Paginas 322

// nuestros datos serán privados, aunque esto puede parecer un problema ya que si el
// exterior necesita alguna información calculada por el objeto no podrá tener acceso
// a ella. Para resolver esto hacemos uso de las funciones de interfaz.
// Una función de interfaz es aquella que puede ser invocada desde el exterior y que
// regresa una copia del valor de algún dato dentro del objeto. También podemos usarla para colocar un valor determinado en un dato. La ventaja que nos da la función
// de interfaz es que podemos administrar el acceso a nuestra información, y podemos
// colocar dentro de ésta código de seguridad que verifique o valide la información que
// entra o sale. De esta forma evitamos la corrupción de información. 
// Los métodos
// Los métodos son las funciones que llevan a cabo el proceso o la lógica de la clase, y
// crear un método dentro de la clase es muy parecido a la forma que hemos utilizado
// anteriormente. Los métodos también tendrán un tipo de acceso, al igual que los datos. Trabajarán sobre los datos de la clase. No hay que olvidar que todos los métodos conocen todos los datos definidos dentro de la clase, y pueden recibir parámetros y regresar valores. A un dato definido dentro de la clase no necesitamos pasarlo
// como parámetro ya que el método lo conoce. Solamente los métodos que necesiten
// ser invocados desde el exterior deben tener acceso público. Si el método sólo se invoca desde el mismo interior de la clase su acceso debe ser privado. Esto lo hacemos
// con fines de seguridad y para mantener el encapsulamiento correctamente.
// Cómo declarar la clase y los datos
// La declaración de la clase es un proceso sencillo. Las clases se declaran dentro de un
// namespace y cualquiera que tenga acceso a ese namespace puede crear objetos de
// la clase. No olvidemos que la clase es como el plano y los objetos son realmente los
// que usamos para llevar a cabo el trabajo.
// Para declarar la clase tendremos un esquema como el siguiente:

class Nombre 
{
    // Datos
    ...
    ...
    // Metodos 
    ...

}

⭕ Paginas 323

// El nombre de la clase puede ser cualquier nombre válido dentro de C#. El nombre debe ser único para el namespace, es decir no podemos tener dos clases que
// se llamen igual adentro del mismo namespace. La clase necesita un bloque de
// código y en su interior llevamos a cabo las declaraciones de los elementos que la
// componen. Generalmente, declaramos primero los datos. Esto nos permite tener
// un programa organizado y luego facilita la lectura. Además, es posible declarar
// los métodos implementados antes.
// La mejor forma de hacer esto es por medio de un ejemplo. Supongamos que crearemos un programa que calcula el área y el volumen de cubos y prismas rectangulares.
// Como en esta ocasión lo hacemos vía programación orientada a objetos, lo primero
// que hacemos es pensar en los objetos que componen el problema.
// Los objetos son: cubo y prisma rectangular. Ahora que ya conocemos los objetos,
// debemos pensar en los datos y las operaciones que se realizan sobre éstos.
// Para el cubo necesitaremos como datos primordiales la longitud de su lado, el
// área y su volumen. En el caso del prisma requerimos aún más datos, que son el
// ancho, el alto, el espesor, el área y el volumen.
// Enseguida debemos pensar en las operaciones que se realizan sobre estos datos.
// El cubo es más sencillo de resolver, ya que solamente necesitamos dos métodos, uno
// llamado CalculaArea() y el otro llamado CalculaVolumen(). Para comprender mejor
// las clases y por motivos ilustrativos el prisma necesitará tres métodos. El primero se
// llamará CalculaArea(), el segundo CalculaVolumen() y el tercero AreaRectangulo().
// Como el área del prisma es igual a la suma de los rectángulos de sus caras nos apoyaremos en este método para calcularla.
// Podemos diagramar las clases si hacemos uso de UML. La clase del cubo quedará
// como se muestra en la siguiente figura:

⭕ Paginas 324

// De igual forma es posible crear el diagrama de clases correspondiente al prisma: 

Nombre de la clase : Prisma
Tipo de Datos : +Alto int
Metodo : CalculaArea() : void

// Los diagramas anteriores se pueden leer fácilmente. Hay un rectángulo que representa a la clase. El rectángulo está dividido en tres secciones. La sección superior, que es utilizada para colocar el nombre de la clase, la sección intermedia, que
// se usa para indicar los datos que tendrá la clase y la sección inferior, que es para
// indicar cuáles son los métodos a utilizar.
// El acceso se muestra por medio de los signos + o -. Cuando usamos el signo más estamos indicando que ese dato o método tiene un acceso del tipo público. En el caso de que coloquemos el signo menos, el acceso es del tipo privado.
// El formato de los datos lleva primero el acceso seguido del nombre del dato. Luego se coloca : y el tipo que tiene este dato. El tipo puede ser nativo o definido por
// el programador. En el caso de los métodos, primero indicamos el acceso seguido del
// nombre del método. Como ninguno de nuestros métodos necesita parámetros, entonces los dejamos vacíos. El tipo del método, es decir el tipo de valor que regresa,
// se indica por medio de : seguido del tipo. En nuestro ejemplo hasta el momento
// ningún método regresa algo, por lo que todos son de tipo void.
// Ahora podemos comenzar a declarar nuestras clases:

// El Uso de UML
// UML es un lenguaje unificado de modelado, un lenguaje visual que nos sirve para llevar a cabo
// diagramas y modelado de sistemas. Resulta muy útil en la programación y el diseño orientado a
// objetos, ya que facilita el diseño y la depuración de la aplicación aun antes de que se escriba una
// línea de código. Es recomendable buscar información adicional sobre éste y aprenderlo.


⭕ Paginas 325

class cubo
{
    // Declaramos los Datos
    public int lado;
    public int area;
    public int volumen;
}

class prisma
{
    //Declaramos los Datos
    public int ancho;
    public int alto;
    public int espesor;
    public int area;
    public int volumen;
}

// Como podemos observar, declaramos dos clases. En cada una hemos declarado los
// datos que le corresponden. La declaración de los datos es muy similar a la declaración de variables, y si prestamos atención, podemos notar que ambas clases tienen
// nombres que se repiten en sus datos como area y volumen. Esto es posible porque
// cada clase es una entidad diferente, y estos nombres nunca se confundirán entre sí.
// Continuemos con nuestra clase cubo. Ahora lo que necesitamos hacer es colocar los
// métodos de la clase. Las operaciones son muy sencillas. Nuestra clase cubo quedará como se muestra en el siguiente bloque de código


class cubo
{
    // Declaramos los Datos
    public int lado;
    public int area;
    public int volumen;
    // Metodo para calcular el area.
    public void CalculaArea()
    {
        area = (lado * lado ) * 6;
    }

⭕ Paginas 326
    //Metodo para calcular el volumen
    public void CalculaVolumen()
    {
        volumen = lado*lado*lado;
    }
}

// La declaración de los métodos se hace adentro del bloque de código de la clase y cada
// uno de ellos tiene su propio bloque de código. Como podemos observar, usan los datos directamente. Esto se debe a que cualquier dato declarado en la clase es conocido
// por todos los métodos de esa clase. Más adelante continuaremos con la clase prisma.

cubo miCubo = new cubo();

// Quien realiza realmente la instanciación es new y esa instancia queda referenciada
// como miCubo. A partir de miCubo podremos empezar a trabajar con él

// Cómo asignarles valores a datos publicos
// Como ya tenemos la instancia, ya podemos comenzar a trabajar con ella. Lo primero que haremos será asignarle un valor al dato lado. Haremos la asignación
// por medio del operador de asignación = (igual), pero también deberemos indicar a cuál de todos los datos de la clase vamos a acceder. Esto lo hacemos con e

// Al Acceso Protegido
// El acceso privado es utilizado cuando hacemos uso de la herencia. Si declaramos un dato como
// protegido, la propia clase y las clases que hereden de ellas podrán acceder a él, leerlo y
// modificarlo. Todas las demás clases lo verán como si su acceso fuera privado y no podrán
// acceder a él directamente

⭕ Paginas 327

// operador punto. Por ejemplo, asignemos el valor de 5 al lado, realizando esto como vemos en el código a continuación:

// miCubo.lado = 5;

// Cómo invocar métodos de un objeto
// Cuando invocamos el método de un objeto, éste ejecuta el código que tiene en
// su interior. Desde el exterior de la clase solamente podemos invocar métodos que
// sean públicos. La invocación del método es muy similar a lo que aprendimos en
// el Capítulo 3, con todos los casos que vimos. En este caso sólo tenemos que indicar con qué objetos trabajaremos, seguido el operador . y el nombre del método con sus parámetros, si los necesita.
// Invoquemos los métodos para calcular el área y el volumen del cubo

// Invocar los Metodos.
miCubo.CalculaArea();
miCubo.CalcuraVolumen();

// Cómo imprimir un dato público
// Como ya tenemos los valores calculados, ahora los podemos mostrar. Para esto los
// usaremos como cualquier variable normal, pero debemos indicar el objeto con el
// que trabajamos, seguido del operador . y en nombre del dato

// Desplegamos los Datos.
   Console.WriteLine("Area={0},Volumen={1}", miCubo.area , miCubo.volumen);

// Nuestro programa queda de la siguiente manera:

class cubo
{
    // Declaramos los Datos
    public int lado;
    public int area;
    public int volumen;
    // Metodo para calcular el area.

⭕ Paginas 328
    public void CalculaArea()
    {
        area = (lado * lado ) * 6;
    }
    //Metodo para calcular el volumen
    public void CalculaVolumen()
    {
        volumen = lado*lado*lado;
    }
}


class prisma
{
    //Declaramos los Datos
    public int ancho;
    public int alto;
    public int espesor;
    public int area;
    public int volumen;
}

class Program
{
    static void Main(string[]args)
    {
        // Instanciamos la clase cubo 
        cubo miCubo = new Cubo();
        //Asignamos el valor del lado
        miCubo.lado = 5;
        // Invocamos los metodos.
        miCubo.CalcularArea();
        miCubo.CalcularVolumen();
        // Desplegamos los Datos.
        Console.WriteLine("Area={0},Volumen={1}", miCubo.area , miCubo.volumen);

    }
}


⭕ Paginas 329
// Si ejecutamos el programa obtendremos lo siguiente
// Una de las ventajas que tiene la programación orientada a objetos es la reutilización
// de código. Si necesitáramos dos cubos o más, simplemente creamos nuevas instancias. Cada una de ellas tendría en su interior sus propias variables y podría llevar a
// cabo los cálculos que fueran necesarios. 
// Por ejemplo, modifiquemos el programa para que se tengan dos cubos. El segundo
// cubo estará en la instancia tuCubo y tendrá un valor de lado de 8.

static void Main(string[] args)
{
// Instanciamos a la clase cubo
cubo miCubo = new cubo();
cubo tuCubo = new cubo();
⭕ Paginas 330
// Asignamos el valor del lado
miCubo.lado = 5;
tuCubo.lado = 8;
// Invocamos los métodos
miCubo.CalculaArea();
miCubo.CalculaVolumen();
tuCubo.CalculaArea();
tuCubo.CalculaVolumen();
// Desplegamos los datos
Console.WriteLine(“Mi cubo Area={0}, Volumen={1}”, 
miCubo.area, miCubo.volumen);
Console.WriteLine(“Tu cubo Area={0}, Volumen={1}”, 
tuCubo.area, tuCubo.volumen);
}
// Este cambio solamente fue necesario en Main(), ya que todo el comportamiento que
// necesitamos se encuentra en la clase. Ejecutemos el programa y veamos el resultado.



⭕ Paginas 331

// Protección de datos y creación de propiedades
// Con la clase cubo hemos visto cómo crear una clase sencilla que ya tiene funcionalidad. Sin embargo, presenta un problema. El primero es que todos sus datos son
// públicos, lo que nos puede llevar a corrupción de información. Para proteger los datos tenemos que hacerlos privados y proveer una función de interfaz a aquellos a los
// que se necesita acceder por el exterior.
// Para tener una comparación, trabajaremos sobre nuestra clase prisma. Lo primero
// que hacemos es cambiar el acceso de los datos a privado.

class prisma
{
    private int ancho;
    private int alto;
    private int espesor;
    private int area;
    private int volumen;
}

// Las propiedades son funciones de interfaz. Nos permiten acceder a los datos privados de una manera segura y controlada, pero van más allá de simples funciones ya
// que también nos brindan una forma de acceso intuitiva y sencilla.
// La propiedad puede ser de varios tipos: lectura, escritura y la combinación de ambas(lectura-escritura). Una propiedad de lectura solamente nos permite leer el dato, pero no podemos agregarle información. Una propiedad que es de tipo escritura sólo nos permite colocar información en el dato, pero no podemos leerlo. La propiedad de lectura-escritura permite llevar a cabo ambas acciones.
// Para lograr esto, la propiedad tendrá dos métodos. El método relacionado con la
// lectura se conoce como get y el relacionado con la escritura es set. Dependiendo de cuál método coloquemos en la propiedad, será su tipo.
// La propiedad de éste tiene la siguiente forma de declaración:

public tipo Nombre
{
    get
    {
        ...
        return x;
    }

⭕ Paginas 332

    set
    {
        ...
        x = value;
    }
}

// Las propiedades son públicas para poder llamarlas desde el exterior de la clase. El
// tipo está referenciado al tipo del valor que leerá o colocará, ya sea entero, flotante,
// doble, etcétera. En su interior tenemos get, donde colocamos el código para sacar
// un valor de la clase por medio de return, y a set, donde ponemos el código necesario para introducir un valor en la clase.
// Empecemos por crear propiedades para la clase prisma. Lo primero que tenemos
// que preguntarnos es a qué datos se necesita acceder por el exterior y qué tipo de acceso requieren. Podemos ver que los datos ancho, alto y espesor necesitarán de escritura, pero también de lectura. Esto es en caso de que necesitemos saber las dimensiones. A sus propiedades las llamaremos: Ancho, Alto y Espesor.
// Los otros datos que necesitan tener una propiedad son area y volumen, pero en este caso solamente necesitamos leerlos. No tiene sentido escribir sobre esos datos, ya
// que la clase calculará sus propios valores.
// Ahora que ya sabemos cuáles son las propiedades necesarias podemos decidir si es
// necesario algún tipo de validación. Sabemos que no podemos tener prismas con
// cualquiera de sus lados con valor de 0 o negativos y ése es un buen punto para validar. Si el usuario diera un valor incorrecto, entonces colocaremos por default el
// valor 1. Hay que recordar que esto lo hacemos como ejemplo y cada aplicación puede tener sus propias reglas de validación para la información.
// Cuando usemos el método set tendremos una variable previamente definida por el
// lenguaje que se llama value. Esta variable representa el valor que el usuario asigna y
// podemos usarlo en la lógica que necesitemos.
// Nuestras propiedades de lectura y escritura quedan de la siguiente forma:

// Definimos las Propiedades.


⭕ Paginas 333
public int Ancho
{
    get
    {
        return ancho;
    }
    set
    {
        if(value <= 0)
        {
            ancho = 1;
        }
        else 
        {
            ancho = value;
        }
    }
}


public int Alto
{
    get
    {
        return alto;
    }
    set
    {
        if(value <= 0)
        {
            alto = 1;
        }
        else 
        {
            alto = value;
        }
    }
}

⭕ Paginas 334
public int Espesor
{
    get
    {
        return espesor;
    }
    set
    {
        if(value <= 0)
        {
            espesor = 1;
        }
        else 
        {
            ancho = value;
        }
    }
}

// El uso de las Propiedades :
// En ocasiones, dentro de los métodos get y set de la propiedad, tendremos un return o una
// asignación. Aunque esto es correcto, no debemos olvidar que en las propiedades podemos
// colocar cualquier lógica válida de C# que nos permita validar la información que sale o entra. Esto
// hará que nuestro código sea más seguro y evitaremos problemas con nuestra información.

// Ahora crearemos las propiedades de sólo lectura para el área y el volumen

public int Area
{
    get
    {
        return area;
    }
}

public int Volumen
{
    get
    {
        return volumen;
    }
}
// Como estas propiedades son de sólo lectura únicamente llevan el método get

⭕ Paginas 335


// Cómo acceder a las propiedades
// Acceder a las propiedades es muy sencillo ya que únicamente necesitamos colocar
// el objeto con el que queremos trabajar seguido del operador . y el nombre de la propiedad. La asignación se lleva a cabo por medio del operador =.
// Por ejemplo, si deseamos indicar que el ancho tiene 5 unidades, hacemos lo siguiente:

miPrisma.Ancho = 5 ;

// Y si deseamos imprimir el valor de la propiedad Volumen:

Console.WriteLine("El volumen es {0}" , Volumen);

// Métodos públicos y privados
// Como mencionamos anteriormente, los métodos pueden ser públicos o privados.
// Los primeros pueden ser invocados desde el exterior del objeto y los privados solamente desde su interior. Al programar la única diferencia es el tipo de acceso que
// colocamos. En nuestro ejemplo necesitamos dos métodos públicos para invocar al
// cálculo del área y el volumen, y un método privado que nos apoyará en el cálculo
// del área. Veamos cómo programarlos:

public void CalculaVolumen()
{
    volumen = ancho *alto *espesor;
}

public void CalculaArea()
{
    int a1 = 0 , a2 = 0 , a3 = 0;
    a1 = 2 * CalculaRectangulo(ancho , alto);
    a2 = 2 * CalculaRectangulo(ancho , espesor);
    a3 = 2 * CalculaRectangulo(alto , espesor);

    area = a1 + a2 + a3;
}


private int CalculaRectangulo(int a , int b)
{
   ⭕ Paginas 336
    return = (a * b);

}

// Los métodos son muy sencillos, lo importante es notar que el método CalculaRectangulo() tiene acceso privado, por lo que nadie del exterior puede invocarlo. Sin
// embargo, CalculaArea() lo invoca sin problemas ya que pertenece a la misma clase.


// Convertir un objeto a cadena
// Tenemos varias opciones para imprimir la información que guarda un objeto en
// la consola. La primera consiste en leer la propiedad e imprimir de la forma tradicional. Otra opción puede ser crear un método dentro del objeto que se especialice en la impresión de la información. Esto puede ser útil si deseamos imprimir tan
// solo uno o algunos datos.
// La última opción y la que aprenderemos a usar es la de programar el método ToString()
// para la clase. Esto ya lo hemos hecho en el capítulo anterior para las estructuras. El mecanismo es similar, simplemente tenemos que implementar una versión del método
// ToString() para nuestra clase. Este método regresa una cadena que contiene la información en el formato que deseamos y tampoco necesita recibir ningún parámetro.
// Este método se implementa adentro de la clase y cada clase en la aplicación lo puede tener de ser necesario. Entonces, cuando necesitemos imprimir los contenidos
// del objeto simplemente lo invocaremos e imprimiremos la cadena resultante. El método debe tener acceso público ya que es necesario que el exterior pueda invocarlo.
// En nuestro caso, el método quedaría de la siguiente manera:

public override string ToString()
{
    string mensaje = "";
    mensaje += "Ancho" +ancho.ToString() + "Alto" + alto.ToString() + "Espesor" + espesor.ToString(); 
    mensaje += "Area" + area.ToString() + "Volumen" + volumen.ToString();  
    return mensaje:
}

// En este ejemplo hacemos uso de la concatenación para poder generar la cadena que
// el método regresará. Hacemos esto para comparar con el uso de StringBuilder, que se

//⭕ Paginas 337

// ha utilizado en el capítulo donde hablamos de las estructuras. La concatenación suele utilizarse para agrupar registros obtenidos de una base de datos. Podemos hacer uso
// de cualquiera de estos métodos según necesitemos de ellos. La impresión de los contenidos del objeto apoyándonos en este método puede ser de la siguiente forma:

Console.WriteLine(miPrisma.ToString());

// Si lo deseamos, podemos probar a éste en nuestro programa, y ver que obtendremos el resultado de la siguiente figur

// Para imprimir solamente algunos datos
// Si solamente necesitamos imprimir algunos datos, entonces es necesario crear un
// método especializado para ello. Este método deberá tener acceso público para
// que pueda ser invocado desde el exterior, y en el caso de llegar a necesitarlo, puede prepararse el método para recibir parámetros, aunque esto no es necesario.
// Supongamos que deseamos tener disponible un método que sólo imprima los resultados para el área y el volumen.

⭕ Paginas 338

// El trozo de código para ello, es el que mostramos el el siguiente bloque:

    public void ImprimeResultados()
    {
        Console.WriteLine("El area es {0} , El volumen es {1}" , area , volumen);
    }

// Figura 6. Ahora podemos comparar la impresión
// con la ayuda de ToString() y del método especializado.


// El constructor en las clases
// El constructor es un método especial que podemos utilizar con las clases. Éste generalmente es usado para inicializar los valores de los datos con los que trabajará el
// objeto. La forma como lo utilizamos con las clases es equivalente a la forma como
// lo utilizamos con las estructuras en el capítulo anterior. El constructor es un método especial y tiene ciertas características que lo distinguen de los demás métodos.

⭕ Paginas 339 

// Su primera característica es que tiene el mismo nombre de la clase y su segunda característica más importante es que no tiene tipo, es decir, que no solamente no regresa nada, sino que no tiene tipo alguno. 
// El constructor es invocado en forma automática cuando el objeto es instanciado, ya
// que esto nos da la oportunidad de llevar a cabo cosas en el instante que se instancia el objeto, como por ejemplo, hacer inicializaciones. El constructor puede tener
// en su interior cualquier código válido de C# y también puede tener parámetros o
// no. Si utilizamos los parámetros tendremos que pasar los valores necesarios en el
// momento en el que instanciamos el objeto. 
// Veamos un ejemplo de constructor para nuestra clase prisma. En este constructor
// no utilizaremos parámetros, veamos el siguiente ejemplo:

public Prisma()
{
    // Datos Necesarios
    String valor = "";

    // Pedimos los datos
    Console.WriteLine("Dame el ancho");
    valor = Console.ReadLine();
    ancho = Convert.ToInt32(valor);

    Console.WriteLine("Dame el alto");
    valor = Console.ReadLine();
    alto = Convert.ToInt32(valor);

    Console.WriteLine("Dame el espesor");
    valor = Console.ReadLine(valor);
    espesor = Convert.ToInt32(valor);
}

// NO HAY QUE CONFUNDIR EL CONSTRUCTOR
// Mucha gente confunde el constructor y cree erróneamente que es el encargado de construir el
// objeto. Esto es falso. El constructor no se encarga de instanciar el objeto, sólo se invoca en forma
// automática en el momento en que el objeto se instancia. No debemos tener esta confusión.


⭕ Paginas 340

// Como podemos observar dentro del ejemplo, el constructor tiene acceso de tipo
// público. Esto es importante, ya que como se invoca automáticamente, el exterior necesitará tener acceso a él.
// El constructor se encargará de solicitarle al usuario los datos necesarios. Cuando llevemos a cabo la instanciación, será de la siguiente forma

Prisma miPrisma = new Prisma();
// Si compilamos el programa, obtendremos el siguiente resultado

// CONSTRUCTORES PRIVADOS
// En las técnicas avanzadas de programación, como por ejemplo la programación de patrones,
// podemos encontrar constructores privados. Uno de los patrones que lo utilizan se conoce
// como singleton. Generalmente, haremos uso de constructores públicos hasta que
// aprendamos este tipo de técnicas avanzadas

⭕ Paginas 341 

// Sobrecarga del constructor
// El constructor puede ser sobrecargado, es decir, podemos tener más de una versión
// del constructor. Esto resulta útil ya que podemos seleccionar cómo se inicializarán
// los datos del objeto dependiendo del tipo de constructor que utilicemos.
// El compilador seleccionará automáticamente el tipo de constructor dependiendo
// de los tipos y la cantidad de parámetros.
// Ya tenemos un constructor que nos pide directamente los datos, pero ahora podemos hacer un constructor que recibe los valores con los que se inicializará el prisma
// en el momento de la instanciación. Para esto tenemos que colocar parámetros en la
// segunda versión del constructor.

public Prisma(int pancho , int palto , int pespesor)
{
    // Asignamos los valores ..
    ancho = pancho;
    alto = palto;
    espesor = pespesor;
}

// Cuando instanciemos el objeto con este constructor, lo usaremos así:

Prisma miPrisma = new Prisma(5,3,7);

// Observemos cómo los valores fueron pasados al momento de la instanciación. El
// valor 5 será colocado en el dato ancho, 3 en el dato alto y 7 en el dato espesor.
// Si tenemos el dato contenido en una variable, también es posible utilizarla cuando
// instanciamos el objeto. Solamente debemos asegurarnos de que el tipo de la variable sea el mismo que el tipo del parámetro que colocamos. Si no fueran del mismo
// tipo, lo recomendable es utilizar type cast. Supongamos que tenemos lo siguiente:

int variableLocal = 12;
...
...
...
Prisma miPrisma = new Prisma(5,3,variableLocal);

// Como vemos, pasamos una copia del valor de miNumero y ahora en el interior del
// objeto miPrimsa4 en dato espesor tendrá el valor de 11


⭕ Paginas 342

// Podemos continuar llevando a cabo más sobrecargas del constructor, tantas como
// sean necesarias. La cantidad de sobrecargas dependerá del análisis y las necesidades
// del programa. No debemos exagerar en las sobrecargas, debemos colocar solamente aquellas que sean realmente necesarias.
// El programa completo que tenemos luce de la siguiente manera:


class Cubo
{
    // Declaramos los datos
    public int lado;
    public int area;
    public int volumen;

    // metodo para calcular el area
    public void calcularArea()
    {
        area = (lado * lado) * 6;
    }

    // metodo para calcular el volumen
    public voi calcularVolumen()
    {
        volumen = lado * lado * lado;
    }
}


class Prisma
{
    // Declaramos los datos 
    private int ancho;
    private int alto;
    private int espesor;
    private int area;
    private int volumen;
   

   ⭕ Paginas 343
    // Definimos las propiedades 
    public int Ancho
    {
        get
        {   
           return ancho;  
        }
        set 
        {
            if(value <= 0)
            {
                ancho = 1;
            }
            else
            {
                ancho = value;
            }
        }
    }
     public int Alto
    {
        get
        {   
           return alto;  
        }
        set 
        {
            if(value <= 0)
            {
                alto = 1;
            }
            else
            {
                alto = value;
            }
        }
    }

    public int Espesor
    {
        get
        {   
           return espesor;  
        }
        set 
        {
            if(value <= 0)
            {
                espesor = 1;
            }
            else
            {
                espesor = value;
            }
        }
    }
   
    ublic int Area
    {
        get
        {   
           return area;  
        }
    }

    ublic int volumen
    {
        get
        {   
           return area;  
        }
    }

// LOS NOMBRES DE LAS PROPIEDADES
// Las propiedades pueden tener cualquier nombre válido de C#. El nombre de las propiedades
// debe reflejar de alguna forma el tipo de dato sobre el cual actúa. Si nuestro dato es costo,
// entonces la propiedad se puede llamar Costo. El dato y la propiedad no pueden tener el mismo
// nombre, pero recordemos que C# distingue entre mayúsculas y minúsculas

⭕ Paginas 344
    // Definimos los constructores
    public Prisma 
    {
        // Datos  necesarios
        String valor = "";
        // Pedimos los datos
        Console.WriteLine("Dame el Ancho");
        valor = Console.ReadLine();
        ancho = Convert.ToInt32(valor);

        Console.WriteLine("Dame el alto");
        valor = Console.ReadLine();
        alto = Convert.ToInt32(valor);

        Console.WriteLine("Dame el espesor");
        valor = Console.ReadLine();
        espesor = Convert.ToInt32(valor);
    }


    // PROBLEMAS CON LAS PROPIEDADES
    // Tenemos que decidir oportunamente el tipo de acceso que permitirá la propiedad. Si tratamos
    // de asignarle un valor a una propiedad de sólo lectura, el compilador nos indicará un error. Lo
    // mismo sucede si tratamos de leer una propiedad de sólo escritura. Por eso lo mejor es planificar
    // durante la etapa de análisis el acceso que les colocaremos a las propiedades de nuestra clase

    public Prisma(int pancho , int palto , int pespesor)
    {
    // Asignamos los valores ..
        ancho = pancho;
        alto = palto;
        espesor = pespesor;
    }   

    // Definimos los metodos
⭕ Paginas 346
    public void CalculaVolumen()
    {
        volumen = ancho * alto * espesor;
    }
    
    public void CalculaArea()
    {
        int a1 = 0 , a2 = 0 , a3 = 0;
        a1 = 2 * CalculaRectangulo(ancho , alto);
        a2 = 2 * CalculaRectangulo(ancho , espesor);
        a3 = 2 * CalculaRectangulo(alto , espesor);

        area = a1 + a2 + a3;
    }


    private int CalculaRectangulo(int a , int b)
    {
        return = (a * b);

    }

    public override string ToString()
    {
    string mensaje = "";
    mensaje += "Ancho" +ancho.ToString() + "Alto" + alto.ToString() + "Espesor" + espesor.ToString(); 
    mensaje += "Area" + area.ToString() + "Volumen" + volumen.ToString();  
    return mensaje:
    }

    public void ImprimeResultados()
    {
        Console.WriteLine("El area es {0} , El volumen es {1}" , area , volumen);
    }
    
⭕ Paginas 347

    class Program
    {
        static void Main(String[]args)
        {
            // Instanciamos a la clase Cubo
            Cubo miCubo = new Cubo();
            Cubo tuCubo = new Cubo();

            // Instanciamos el prisma
            Prisma prisma = new Prisma();
            //Instanciamos con la version sobrecargada
            Prisma MiPrisma = new Prisma(3,5,7);
            // Asignamos el valor del lado
            miCubo.lado = 5 ;
            miCubo.lado = 8;
            //invocamos los metodos
            miCubo.CalculaArea();
            miCubo.CalculaVolumen();
            tuCubo.CalculaArea();
            tuCubo.CalculaVolumen();

            // Asignamos los valores al prisma
            // quitar Comentatios para version sin constructor
            miPrisma.Ancho = 10;
            miPrisma.Alto  =  3;
            miPrisma.Espesor = 5;

            // Invocamos los metodos del prisma
            miPrisma.CalcularArea();
            miPrisma.CalcularVolumen();
            miPrisma2.CalcularArea();
            miPrisma2.CalcularVolumen();

            // Desplegamos los datos
            Console.WriteLine("Mi cubo Area={0} ,volumen {1}" , miCubo.Area , miCubo.Volumen);
            Console.WriteLine("Tu cubo Area={0} ,volumen {1}" , tuCubo.Area , tuCubo.Volumen);
            Console.WriteLine(miPrisma.ToString());
            miPrisma.ImprimeResultados();
            Console.WriteLine(miPrisma2.ToString());
        }
    }
 
// Hemos escrito bastante código para el funcionamiento de esta aplicación. Ejecutemos el programa y nuestro resultado es el siguiente

// Figura 8. Cada objeto usa el constructor que le corresponde


⭕ Paginas 349
// Si revisamos el código que hemos presentado en el bloque anterior, podemos darnos cuenta del funcionamiento de las sobrecargas del constructor que hemos agregado, es importante reafirmar la idea que ya explicábamos en en párrafos anteriores, tenemos la posibilidad de agregar cuantas sobrecargas sean necesarias pero siemre debemos tener en cuenta la necesidad de no exagerar.
// A través de este capítulo hemos analizado la importancia del uso de clases para la generación de nuestros programas, utilizando C#. Con esto hemos visto el inicio de los
// elementos para programar clases. Aún queda mucho por aprender sobre la programación orientada a objetos y su programación en C#, pero éstos serán temas de un
// libro más avanzado y especializado en la programación del experto en el lenguaje C#.

RESUMEN
// La programación orientada a objetos es un paradigma de programación diferente a la
// programación estructurada. Tenemos que reconocer los objetos que componen el sistema así
// como la comunicación que tienen entre ellos. La clase es el elemento fundamental de este
// tipo de programación y actúa como el plano sobre el que los objetos son construidos. Los
// objetos o las instancias son los que realmente llevan a cabo el trabajo. Los datos y los
// métodos pueden tener diferentes tipos de acceso: público, privado o protegido. Las
// propiedades nos sirven como funciones de interfaz para poder acceder a los datos privados de
// forma segura. Las clases pueden tener un constructor que nos ayuda a inicializar la
// información. Es posible hacer uso de la sobrecarga en el constructor.


⭕ Paginas 351

// Flujos y
// archivos
// Los flujos 350
// Los stream en la memoria 351
// El uso de archivos 363
// Resumen 371
// Actividades 372
// Capítulo 11
// A lo largo del libro hemos realizado
// muchos programas, y cada vez que usamos
// un programa, debemos introducirle
// información. Esto no ha sido un gran
// problema en los ejemplos realizados hasta
// aquí, porque generalmente manipulamos
// pocos datos. Sin embargo, en muchas
// aplicaciones reales necesitaremos tener
// alguna metodología para poder guardar
// la información y recuperarla cuando
// la aplicación se ejecute nuevamente.
// Para resolver esto, tenemos acceso
// a los archivos y los flujos.

// LOS FLUJOS
// Los flujos también son conocidos como streams por su nombre en inglés. Se los
// llama de esta forma porque nos recuerdan como fluye el agua, pero en este caso se
// tratará de flujos de información. El stream es utilizado para poder mover información de un lugar a otro. A veces, moveremos la información de la memoria a otra
// parte de la memoria, pero generalmente lo que haremos será mover la información
// de la memoria a un dispositivo de almacenamiento como el disco duro o del dispositivo nuevamente a la memoria.
// Cuando hacemos uso de los flujos, la información no es enviada en un solo movimiento, sino que se envía byte por byte de forma ordenada. Como el envío es de esta forma, tenemos que tener cuidado sobre qué byte procesamos en ese momento
// Para poder tener control sobre el byte a enviar, imaginaremos que tenemos un apuntador o indicador en nuestro flujo. Este indicador siempre nos señala cuál es el siguiente byte a enviar. Cada vez que enviamos un byte a su nuevo lugar por medio
// del flujo, el indicador se actualiza y nos señala el siguiente byte. Esta forma de trabajo funciona muy bien si el envío de datos es secuencial, pero también debemos
// tener un mecanismo que nos permita seleccionar a nosotros mismos el byte a enviar. Para hacer esto tenemos que indicar de alguna manera el byte y esto solamente lo podemos llevar a cabo si tenemos un punto de referencia dentro del flujo.
// En el flujo encontramos tres puntos de referencia. El primero es el inicio del flujo.
// Si queremos colocarnos en un byte en particular para enviar, simplemente tenemos
// que decir a cuántos bytes de distancia desde el inicio se encuentra el byte que deseamos procesar. El segundo punto de referencia será el final del flujo. De manera
// similar tenemos que decir a cuántos bytes de distancia se encuentra el byte a procesar desde el final del flujo. El tercer punto de referencia es la posición actual dentro del flujo, de igual forma a los casos anteriores, debemos dar la distancia desde
// nuestra posición actual al byte que nos interesa procesar. En todos los casos, este
// byte se volverá nuestro nuevo byte actual.

// Figura 2. Aquí vemos cómo un mismo byte
// del stream puede estar referenciado de formas diferentes
// Los stream en la memoria
// Empecemos a trabajar con el stream. Éste simplemente llevará la información de un
// lugar a otro. La forma más sencilla de aprenderlo es haciendo streams en memoria.
// Aquí veremos las operaciones básicas que podemos realizar con ellos y después este
// conocimiento puede ser llevado a streams que se comuniquen con dispositivos de
// almacenamiento masivo como discos duros.
// Para trabajar con streams en la memoria nos apoyaremos de una clase conocida como MemoryStream. Cuando necesitemos usar esta clase debemos agregar el namespace al que pertenece. Para esto colocamos el siguiente código en la parte superior
// de nuestro programa, antes de las declaraciones de las clases.

|| // Adicionamos para el uso de Stream
   using System.IO 



// Esta clase crea un stream, pero el lugar donde guarda la información es un sitio en
// memoria. La información es guardada como un arreglo de bytes sin signo. La clase MemoryStream tiene sobrecargado su constructor y seguramente podemos encontrar una versión de acuerdo con nuestras necesidades.El constructor puede crear el arreglo en la memoria vacío o puede inicializarlo a un tamaño en particular.
// Hay que recordar que el tamaño está en bytes.

// Notas: DISTANCIAS EN LOS FLUJOS
// Como hemos visto, para seleccionar un byte dentro del flujo debemos indicar su distancia desde
// el punto de referencia. Si es el mismo punto de referencia el que deseamos enviar, la distancia
// será cero. Las distancias se miden de izquierda a derecha, y negativas de derecha a izquierda.
// Por ello cuando usamos como referencia el final del flujo las distancias llevan el signo menos.


⭕ Paginas 354

// Nosotros usaremos la versión en la que podemos indicar el tamaño inicial del arreglo y para instanciar MemoryStream podemos hacerlo de la siguiente manera

||
// Creamos el Stream en Memory
// La iniciamos con capacidad de 50 bytes
   MemoryStream ms = new MemoryStream(50); 


// El objeto se llama ms, pero puede tener cualquier nombre válido de C#. El tamaño
// inicial que le asignamos es 50 bytes.

// Cómo obtener información sobre el stream
// Nosotros podemos obtener ciertos datos sobre el stream. Estos datos nos pueden
// servir en la lógica de nuestro programa y resulta útil poder conocerlos. Los datos
// que podemos obtener son: la capacidad, la longitud y la posición

// Figura 3. En este diagrama podemos observar las tres propiedades del stream.
// La capacidad nos indica cuántos bytes puede almacenar el stream. En el ejemplo anterior es de 50, ya que le hemos colocado ese tamaño en su instanciación. El valor
// de la capacidad se guarda en la propiedad Capacity y ésta es de tipo entero. Si deseamos obtener la capacidad lo podemos hacer de la siguiente forma:

||
    int capacidad = 0;
    ...
    ...
    capacidad = ms.Capacity;

// Notas : CUIDADO CON EL TAMAÑO
// Los streams en memoria que se inicializan con un arreglo de bytes sin signo no pueden
// modificar su tamaño. Esto hace importante que seleccionemos adecuadamente el tamaño a
// utilizar. Podemos hacer una estimación del tamaño máximo y colocarla en el constructor.

⭕ Paginas 355
  
// El siguiente dato que podemos obtener es la longitud. Ésta nos indica el tamaño
// de la información actual que tiene el stream. El tamaño está dado en bytes. La propiedad relacionada con esta información es Length. Esta propiedad es de tipo long.
// A continuación veamos un ejemplo de cómo podemos obtener este dato:

||
    long longitud = 0;
    ...
    ...
    longitud = ms.Length;


// Por último tenemos la posición. Este dato es sumamente importante ya que nos indica el lugar donde se encuentra el byte actual, es decir el siguiente a ser procesado.
// Esta posición está referenciada con relación al inicio del stream. La propiedad para
// este dato se llama Position y al igual que la anterior también es de tipo long. La forma de obtener estos datos es similar a las anteriores

||
    long posicion = 0;
    ...
    ...
    posicion = ms.Position;

// Cómo colocar la posición en el stream
// Una de las actividades más importantes y frecuentes que realizaremos con los streams es colocar la posición actual en un sitio determinado. Para esto hacemos uso de
// un método conocido como Seek(). Éste necesita dos parámetros. El primero es la
// distancia desde el punto de referencia donde quedará la nueva posición actual en el
// stream. El segundo indica el punto de referencia que utilizaremos.
// El punto de referencia tiene que ser de tipo SeekOrigin. Este tipo tiene tres valores posibles: Begin, Current y End. El valor Begin es usado para indicar que estamos referenciados con relación al origen del stream. Cuando se utiliza el valor
// Current nuestra posición actual será usada como punto de referencia. Si usamos
// End, la parte final del stream será el punto de referencia para encontrar nuestra
// nueva posición. Por ejemplo, si deseamos colocarnos en el inicio del stream, podemos hacerlo de la siguiente manera:

⭕ Paginas 356

||
    ms.Seek(0 , SeekOrigin.Begin); // nos colocamos a 0 distacia desde el inicio

// En este caso, indicamos que nos encontramos a 0 distancia desde el inicio del stream. Si lo que deseamos es encontrarnos a 10 bytes de distancia desde el inicio, la
// forma de usar Seek() es la siguiente:

|| 
    ms.Seek(10 , SeekOrigin.Begin);

// Pero también podemos colocarnos desde otro punto de referencia. Por ejemplo, para colocarnos a 10 bytes de distancia desde el final del stream usarem

||  
    ms.Seek(-10 , SeekOrigin.End);
    
// Hay que observar que el valor usado es -10, ya que, como vimos anteriormente,
// en la plaqueta de la página 251, las distancias que se miden hacia la izquierda del
// punto de referencia son negativas.
// Por último, si lo que deseamos es movernos con relación a nuestra posición actual,
// por ejemplo avanzar 5 bytes, lo que usaremos es:

||
    ms.Seek(5 , SeekOrigin.Current);

// Y si lo que deseamos es retroceder 10 bytes desde nuestra posición actual, usaremos
// el código que veremos a continuación:

||
    ms.Seek(-10 , SeekOrigin.Current);


// PROBLEMAS CON EL USO DE SEEK()
// Si no utilizamos correctamente el método Seek(), tendremos problemas con nuestro programa.
// Un problema común es tratar de colocar una posición actual que está antes del punto de inicio o
// después del final del stream. Debemos tener lógica para evitar estas acciones, y para lograrlo,
// tenemos que hacer uso de las propiedades del stream como posición, longitud y capacidad


⭕ Paginas 357


// Cómo leer datos del stream
// Ahora que ya nos hemos posicionado en algún lugar en particular del stream, podemos proceder a leer información, que se lee byte por byte. Cuando hacemos una
// lectura, el byte que se lee es el que se encuentra en la posición actual. Inmediatamente después de leer, la posición actual se actualiza y nuestra nueva posición actual será
// la del byte consecutivo al que acabamos de leer. Esta lectura se lleva a cabo de forma
// automática y nosotros no la controlamos.
// Para realizar la lectura podemos usar el método Read(). Este método necesita tres
// parámetros. El primero es un arreglo de bytes. Este arreglo es necesario porque será el lugar donde se guarde la información leída por el stream. El segundo nos da la
// capacidad de colocar un offset para el arreglo de bytes. Generalmente usaremos el
// valor cero en este parámetro, ya que queremos que la información leída se coloque
// desde el inicio en el arreglo. El tercero es la cantidad de bytes a leer.
// El arreglo de bytes para guardar la información es colocado de la siguiente manera:

||
    byte[] buffer = new byte[50];

// En este caso lo llamamos búfer y tendrá capacidad para 50 bytes.
// Supongamos que deseamos leer cinco bytes a partir de la posición actual donde nos
// encontramos. Para ello hacemos uso de Read() de la siguiente manera:

||
    ms.Read(buffer , 0 , 5);

// Después de ejecutarse esta línea, buffer contendrá los cinco bytes leídos y los podemos encontrar al inicio de buffer.
// Cómo escribir información el stream
// No solamente es posible leer información del stream, también podemos agregarla o
// escribirla. Para esto tendremos un método especializado que se llama Write(). Para


// EVITAR ERRORES CON LA LECTURA
// Es posible tener problemas con la lectura de un stream, como el olvidar crear el búfer. Otro
// problema es tratar de leer de un stream que ya se cerró o no ha sido abierto. Un error menos
// frecuente es dar un valor negativo en el segundo o tercer parámetro. Si los valores se controlan por
// variables debemos colocar una lógica que impida poner valores inválidos en los parámetros.

⭕ Paginas 358

// el uso de este método utilizaremos tres parámetros. En el primer parámetro tenemos que colocar el búfer o el arreglo de bytes desde el que tomaremos la información para colocarla en el stream. El segundo parámetro es la posición en el stream
// desde donde empezaremos a escribir. Generalmente utilizaremos el valor de cero, y
// de esta forma empezará a escribirse desde el inicio del stream. El último parámetro
// es la cantidad máxima de bytes que se escribirán.
// Un ejemplo práctico de esto es el siguiente:

||
    //Escribimos los datos en la cadena
    ms.Write(miBuffer ,0 ,15);

// Cómo cerrar el stream
// Algo que no debemos olvidar hacer es cerrar el stream. Cuando éste está cerrado,
// los recursos que se hayan necesitado se liberan. Si el stream está cerrado no es posible llevar a cabo ningún tipo de operación sobre él. El cierre del stream se lleva a
// cabo por medio del método Close(), que no necesita ningún parámetro. La forma
// de utilizar el método se muestra a continuación:

||
    ms.Close();

// Programa de ejemplo
// Ahora podemos crear un pequeño programa de ejemplo que utilice lo que hemos
// realizado con los streams. El programa será sencillo, ya que únicamente nos interesa conocer y experimentar con el código. Nuestro programa le pedirá al usuario una
// cadena que será colocada en el stream y luego podremos leer diferentes partes del
// stream con los métodos que hemos aprendido.
// Como siempre, tenemos que empezar por definir las variables que son necesarias.

||
    // Creamos el Stream En memory
    // La Iniciamos con una capacidad de 50 bytes
    MemoryStream ms = new MemoryStream(50);
    // Cadena Con Informacion 
    String informacion = "";
    // Variables Necesarias
    int capacidad = 0;

⭕ Paginas 359

||
    long longitud = 0;
    long posicion = 0;
    byte buffer = new byte[50];

// En primer lugar tenemos un objeto llamado ms que es de tipo MemoryStream y que
// puede guardar hasta 50 bytes en su interior. Luego creamos la cadena que utilizaremos para guardar la frase escrita por el usuario. Como experimentaremos con el
// stream creamos tres variables. Cada una de ellas se usa para guardar la capacidad,
// la longitud y la posición, respectivamente. Al final creamos un arreglo de bytes llamado buffer y de tamaño 50.
// Pedir los datos será de la forma usual y no necesitamos explicarlo en este momento.

||
    // El usuarios de los datos
    Console.WriteLine("Dame la cadena para el flujo");
    informacion = Console.ReadLine();

// Ahora que ya tenemos una cadena, podemos escribirla adentro del stream.

||
    ms.Write(ASCIIEncoding.ASCII.GetBytes(informacion),0,informacion.Length);

// Lo primero que hacemos es obtener los bytes de la cadena, pero éstos estarán codificados como ASCII. Luego indicamos que escribiremos en el stream desde su
// inicio. Por último, indicamos la cantidad de bytes a escribir, que lo obtenemos
// por medio de la longitud de la cadena. Ahora mostraremos la información que
// podemos obtener sobre el stream.

||
    //Obtenemos la informacion de la cadena
    capacidad = ms.Capacity;
    Longitud  = ms.Length;
    posicion  = ms.Position;

    // Mostramos la informacion 
    Console.WriteLine("Capacidad {0} , Longitud {1} , Posicion {2}" , capacidad , longitud , posicion);

// Después de obtener la información, simplemente la mostramos en la consola.


⭕ Paginas 360 

// Figura 4. El programa ya tiene el stream y hemos obtenido su información

// Ahora podemos empezar a experimentar con stream. Nos colocaremos en diferentes posiciones y leeremos información desde ahí. Empecemos por lo más sencillo.
// Leeremos los primeros cinco bytes que se encuentran en el stream.

||
    // Colocamos y leemos datos basandonos en el inicio
    ms.Seek(0 , SeekOrigin.Begin); // nos colocamos a 0 distancia desde el inicio
    ms.Read(buffer , 0 , 5); // Desde donde nos encontramos , 5 caracteres    
    // Mostramos la informacion 
    Console.WriteLine(ASCIIEncoding.ASCII.GetString(buffer));


// Lo primero que hacemos es usar el método Seek(). Con este método decimos que
// queremos encontrarnos a distancia cero desde el inicio del stream. Evidentemente
// ésta es la primera posición disponible. Como nuestra posición actual ya está definida, procedemos a hacer uso del método Read(). En este caso leemos cinco bytes desde donde nos encontramos. Los bytes leídos desde el stream ahora se encuentran
// guardados en el arreglo de bytes que llamamos búfer.

⭕ Paginas 361

// Para mostrar lo que acabamos de obtener usamos el método WriteLine(), y como
// solamente tenemos una colección de bytes, debemos codificarlas adecuadamente con
// GetString(). La codificación que deseamos es ASCII. En la consola aparecen los primeros cinco caracteres de la frase que escribimos.

// Figura 5. Podemos observar que los primeros cinco caracteres son mostrados.

// En el código que veremos a continuación, haremos una prueba, realizando otra
// lectura en una posición diferente.

||
    ms.Seek(0 , SeekOrigin.Begin); 
    ms.Read(buffer , 0 , 5);  
    Console.WriteLine(ASCIIEncoding.ASCII.GetString(buffer));

// En este caso, por medio del método Seek() nos posicionamos a 10 bytes de distancia desde que es iniciado el stream. Nuevamente procedemos a leer cinco bytes desde esa posición que serán colocados en el buffer. Para poder comprobar que esto es
// óptimo y que funciona en forma adecuada lo mostramos en la consola.


⭕ Paginas 362

// Figura 6. En este caso podemos observar
// los bytes leídos desde la posición donde nos encontramos.

// Pero sabemos que no solamente podemos utilizar el inicio del stream como referencia para indicar la posición actual. Ahora realizaremos otra prueba con el final
// del stream como punto de referencia.

// Lectura Relativa al final del flujo
ms.Seek(-10, SeekOrigin.End) // Nos Colocamos a 10 de distancia desde el final
ms.Read(buffer , 0 , 5); Desde nos encontramos a 5 caracteres
Console.WriteLine(ASCIIEncoding.ASCII.GetString(buffer));


// Para este ejemplo usamos nuevamente el método Seek(), pero con la diferencia que
// ahora indicaremos que el punto de referencia es el final del stream. Nuestra nueva
// posición actual se encontrará a una distancia de diez bytes desde el final del stream.
// Por esta razón, vamos a colocar el valor -10 en el primer parámetro. Ya colocados
// en esta distancia simplemente procedemos a leer sólo cinco bytes. Al final de la lectura mostramos lo que hemos obtenido en la consola


⭕ Paginas 363


// Figura 7. Ahora observamos los bytes
// leídos con referencia al punto final del stream

// Debemos recordar que cuando se lleva a cabo una lectura o escritura en el stream, la posición actual se modifica. La última posición colocada explícitamente
// se encontraba a diez bytes del final del stream, pero después de la lectura se ha
// modificado en cinco bytes.
// Comprobemos esto de forma sencilla:

||
    //Obtenemos nuestra Posicion Actual 
    posicion = ms.Position;
    Console.WriteLine("la Posicion Es {0}" , posicion);

// PARA EVITAR PROBLEMAS CON LOS STREAM
// Un problema con el que nos podemos encontrar cuando empezamos a utilizar los streams es
// olvidar indicar el namespace necesario. Coloquemos la siguiente línea en la parte superior de
// nuestro código: using System.IO;. Si no lo hacemos, el programa no podrá reconocer las clases
// y los métodos relacionados con los stream y tendremos problemas de compilación.


⭕ Paginas 364

// Simplemente obtenemos nuestra posición actual y la mostramos en la consola. Esto lo podemos hacer en cada operación y verificar cómo se altera la posición actual.
// Desde nuestra nueva posición actual podemos continuar leyendo.

|| 
//Lectura relativa desde la posicion actual
ms.Read(buffer , 0 , 5 ); // Desde nos encontramos , 5 Caracteres
Console.WriteLine(ASCIIEncoding.ASCII.GetString(buffer));
   
// Ahora no hemos utilizado el método Seek() ya que deseamos continuar leyendo desde donde nos encontramos.
// Por último, no debemos olvidar cerrar el stream.

// Cerremos el Flujo no Olvidar
   ms.Close();

// A continuación, ejecutemos el programa para ver su funcionamiento:

// Figura 8. Esta figura nos muestra la ejecución completa del programa.


⭕ Paginas 365

// El uso de archivos
// Como hemos aprendido, los streams no solamente funcionan en la memoria, sino
// que también nos pueden servir para mover información de la memoria a un dispositivo de almacenamiento masivo. Este dispositivo generalmente será el disco duro. 
// Nosotros podemos crear, escribir y leer archivos en el disco duro apoyándonos en
// los streams. En esta sección del libro haremos dos programas, uno que escriba datos en el disco, y otro que los lea y los presente en la consola.
// Todas las operaciones que hemos aprendido para los streams serán válidas y veremos que es sencillo llevar esto a cabo

// Cómo crear un stream a archivo
// Lo primero que tenemos que hacer es crear un stream a archivo. En lugar de crear
// el stream en la memoria, éste utilizará un medio de almacenamiento masivo. Para
// poder llevar a cabo esto, necesitamos utilizar la clase FileStream. Esta clase nos provee de toda la funcionalidad que necesitamos.
// El constructor de esta clase necesita dos parámetros. El primero tiene que ser una
// cadena que contenga el nombre del archivo con el que trabajaremos. Es útil que el
// nombre del archivo también tenga su extensión.
// El segundo parámetro es más interesante. En este parámetro colocaremos el modo
// del archivo, que indica cómo funcionará y se manipulará el archivo. El valor colocado debe ser del tipo de la enumeración FileMode. Los valores posibles son: Append,
// Create, CreateNew, Open, OpenOrCreate, Truncate.
// Es importante conocer lo que significa cada uno de estos modos, por lo que lo comentaremos aquí. El modo Create nos permite crear un nuevo archivo. En caso de
// que el archivo ya existiera, simplemente se sobrescribe. El modo CreateNew también
// nos permite crear un archivo, pero si el archivo ya existe, se produce una excepción.
// Las excepciones y su manejo lo veremos en un capítulo posterior.
// El modo Open nos permite abrir un archivo. Si el archivo que intentamos abrir no
// existe, entonces se produce una excepción. En el modo OpenOrCreate si el archivo
// existe, se abre, pero en el caso de que el archivo no exista, se crea. 
// En el modo Append, si el archivo existe será abiero, y la posición actual será colocada al final del archivo, de forma tal que cualquier información escrita, sea

// COLOCAR EL NOMBRE DEL ARCHIVO
// El nombre del archivo no necesariamente necesita ser colocado explícitamente. Podemos usar
// una variable de tipo cadena para contenerlo. También es posible colocar toda la ruta al archivo
// en este nombre. Si no colocamos la ruta del archivo, éste será creado en el mismo directorio que
// el ejecutable de nuestra aplicación.
// 



⭕ Paginas 366

// agregada al archivo sin modificar lo anterior. En el caso de que el archivo no exista, será creado un nuevo archivo.
// El modo Truncate es especial y debemos tener cuidado con él ya que abre el archivo. Entonces, los contenidos se eliminan hasta que el archivo tenga una longitud de
// 0 bytes. Por ejemplo, podemos crear un stream a disco en modo de creación, como
// podemos ver en el código a continuación: 

|| 
    FileStream fs = new FileStream("MiTexto.txt" , FileMode.Create);

// El archivo a crear se llama miTexto.txt y será creado en el mismo directorio que el
// ejecutable de nuestra aplicación. El nombre del stream es fs y ya podemos llevar a
// cabo las operaciones necesarias sobre él.

// Cómo escribir información en el archivo
// Ya que tenemos el stream, es posible empezar a trabajar con él, y al igual que con
// los streams de la memoria, podemos llevar a cabo diferentes operaciones, entre
// ellas la de escritura. Para escribir el archivo usaremos el método Write(), que pertenece al stream. Por ejemplo, si deseamos escribir una cadena al archivo, podemos hacerlo de la siguiente forma

||
    // Escribimos al Stream la cadena Capturada.
       fs.Write(ASCIIEncoding.ASCII.GetBytes(cadena) , 0 , cadena.Length): 

// El método necesita tres parámetros, el primer parámetro es el arreglo de bytes que
// escribiremos, el segundo es la posición a partir de donde empezaremos a escribir con
// respecto a nuestra posición actual, y el último parámetro nos sirve para indicar la
// cantidad de bytes que colocaremos. Es importante no olvidar que esta posición se
// actualiza después de hacer uso del método Write().
// En nuestro ejemplo a realizar vamos a suponer que una cadena será escrita al archivo. A esta cadena la tenemos que colocar como un arreglo de bytes, pero éstos
// deben estar codificados como ASCII, para lo cual usaremos la clase ASCIIEncoding.
// Para poder obtener los bytes de la cadena deberemos hacer uso del método GetBytes()
// por el que se pasa la cadena escrita como parámetro.
// La cantidad de bytes que deseamos colocar será la longitud de la cadena, que obtenemos al hacer uso de la propiedad Length.

// Cómo cerrar el archivo
// El cierre del archivo es muy sencillo ya que únicamente debemos cerrar el stream.
// Sabemos que esto lo realizamos por medio del método Close().


⭕ Paginas 367

|| 
    // Cerramos el Stream
       fs.Close();

// Ejemplo de un programa para escribir cadenas a disco
// Ahora que ya conocemos los elementos necesarios para utilizar los streams a disco,
// podemos hacer un ejemplo sencillo. Haremos un programa que le preguntará al
// usuario cadenas, y cada una de éstas serán escritas a disco. Cuando el usuario dé
// una cadena vacía, es decir un return, el archivo se cerrará y se terminará la aplicación. Luego podremos utilizar un programa, como el Bloc de Notas, para poder
// leer el archivo que creamos.
// Empecemos por definir las variables necesarias y crear el archivo:

||
    // Variables Necesarias
       String cadena = "";
       // Creamos el stream al archivo
       // Experimentar con append y create 
       FileStream fs = new FileStream("MiTexto.txt" , FileMode.Create); 

// Luego, podemos hacer uso de un ciclo do while, que se repetirá constantemente hasta que el usuario dé una cadena vacía. En el interior del ciclo llevaremos a cabo la
// petición de la cadena y la escritura de ésta a disco.

||
   // Capturamos cadenas
      do{
       // Leemos la cadena del usuario
       cadena = Console.ReadLine();
       // Escribimos al stream la cadena capturada 
        fs.Write(ASCIIEncoding.ASCII.GetBytes(cadena) , 0 , cadena.Length);
      }while(cadena !=""); 


⭕ Paginas 368

    // Cerramos el stream
       fs.Close(); 
    // Para finalizar simplemente cerramos el archivo
    // El programa completo queda de la siguiente manera:

    static void Main(string[]args)
    {
        // Variables necesarias
        String cadena = "";
        // Creamos el stream al archivo
        // Experimentar con append y create
        FileStream fs = new FileStream("MiTexto.txt" , FileMode.Create);
        // Capturamos cadenas
       do{
       // Leemos la cadena del usuario
        cadena = Console.ReadLine();
       // Escribimos al stream la cadena capturada 
        fs.Write(ASCIIEncoding.ASCII.GetBytes(cadena) , 0 , cadena.Length);
      } while(cadena !=""); 
       // Cerramos el stream
       fs.Close();  
    }

⭕ Paginas 369

// Una vez escrito el programa, sólo nos queda compilar a ambos y ejecutarlos.
// Es posible escribir varias cadenas y luego simplemente presionar la tecla ENTER
// para finalizar. Toda la información que se ha escrito en el programa será almacenada en el archivo. Luego con el Bloc de Notas podemos abrir el archivo y ver que
// efectivamente se encuentra la información que escribimos. 

// Figura 9. En el programa hemos escrito
// las frases y se han guardado en el archivo.

// CÓMO ENCONTRAR NUESTRO ARCHIVO
// Dentro de la carpeta que contiene nuestro proyecto o solución creado, debemos buscar otra
// carpeta con el mismo nombre. En su interior ésta última debe haber otra carpeta con el nombre
// bin. En ésta se encuentran dos carpetas, Debug y Release. En el interior de alguna de ellas estará
// el archivo creado por nuestro programa.

⭕ Paginas 370

// Figura 10. Con el bloc de notas podemos
// verificar que la información ha sido escrita.

// Cómo hacer una aplicación que lee archivos
// Como ya tenemos el código para escribir información a un archivo, ahora sería bueno poder tener una aplicación que lea esa información. El proceso es sencillo ya que
// conocemos los streams. Básicamente, lo que tenemos que llevar a cabo es la apertura
// de un stream a archivo y luego proceder a leer los contenidos. Debemos recordar que
// estamos leyendo bytes, por lo que es necesario procesarlos o convertirlos a un tipo adecuado para nuestro programa. En el programa anterior usamos cadenas ya que ahora
// los bytes leídos serán colocados en una cadena. Desde luego, cuando hemos finalizado con la lectura debemos cerrar el stream del archivo. Para crear esta aplicación empecemos por definir un arreglo de bytes. La finalidad de este arreglo de bytes es recibir la información que proviene del archivo vía el stream. El tamaño del arreglo debe
// ser lo suficientemente grande para contener la cantidad de información. Otra opción
// es leer el stream en grupos de bytes del mismo tamaño que nuestro arreglo, pero esto
// requiere de lógica extra que controle el proceso. Con fines de experimentación, colocaremos el tamaño del arreglo en 100 bytes ya que en nuestro programa anterior no
// hemos colocado cadenas muy grandes. El arreglo queda de la siguiente forma:

// Variables necesarias

⭕ Paginas 371

||
    byte[] infoArchivo = new byte[100];

// Luego podemos proceder a abrir nuestro stream:

||
    FileStream fs = new FileStream("MiTexto.Txt" , FileMode.Open); 

// Para esto creamos una instancia de la clase FileStream y la nombramos fs. En el
// constructor indicamos que nuestro archivo es miTexto.txt. Debemos notar que el
// modo del stream en este caso es Open ya que consideramos que el archivo existe y
// lo abriremos para trabajar con él. Como el archivo fue creado por el programa anterior, deberemos copiarlo de la carpeta donde se encuentra a la carpeta correspondiente de este proyecto. La ruta es similar, solamente que está referenciada a
// nuestro proyecto actual. Si no existe la carpeta Debug o Release, deberemos compilar nuestra aplicación para que sean creadas. Hay que copiar el archivo antes de
// ejecutar el programa. Otra solución es colocar el nombre del archivo a abrir con
// su ruta completa. Si el archivo que queremos abrir no existe o no está donde indicamos, el programa generará una excepción.
// El siguiente paso consiste en leer los contenidos del archivo:

||
    fs.Read(infoArchivo , 0 , (int)fs.Length);


// El método que utilizamos para la lectura es Read(). Este método pertenece al stream. El primer parámetro que colocamos es el arreglo de bytes donde se guardarán los bytes leídos. En el segundo parámetro indicamos que leeremos desde el
// inicio del stream y por último indicamos la cantidad de bytes a leer. En este caso
// leemos la totalidad de los bytes en el archivo, por eso indicamos como valor la
// longitud del stream.
// Con esto, ahora nuestro arreglo contiene una copia de los bytes del stream y desplegaremos la información en la consola como cadena

||
   Console.WriteLine(ASCIIEncoding.ASCII.GetString(infoArchivo));


⭕ Paginas 372

// Para mostrar la información tenemos que colocar los bytes como cadena y esta cade
// el método GetString(), y pasamos nuestro arreglo de bytes como parámetro. La escritura en consola es como siempre, por medio de WriteLine(). Para finalizar, debemos
// cerrar el stream de la forma habitual con el uso del método Close().

||
    
    // Cerramos el Stream
       fs.Close();

// Nuestro programa completo queda de la siguiente manera:


||
    Static void Main(String[]args)
    {
        // Variables necesarias
        byte[100] infoArchivo = new Byt[100];

        // Creamos el Stream De lectura
        FileStream fs = new FileStream("miTexto.txt" , FileMode.Open);
        fs.Read(infoArchivo , 0 , (int)fs.Length);
        // Mostramos la informacion
        Console.WriteLine(ASCIIEncoding.ASCII.GetString(infoArchivo));
        // Cerramos el Stream
       fs.Close();
    }


⭕ Paginas 373

// Ahora ya podemos compilar y ejecutar la aplicación. En la consola podemos leer las
// cadenas que guardamos con el otro programa.

// Figura 11. Podemos observar que nuestro

// programa efectivamente ha leído la información del archivo.
// Con esto hemos aprendido el trabajo básico de los flujos y los archivos en C#. También hemos llevado a cabo una serie de manipulaciones sobre los archivos.

// RESUMEN

// Los flujos o streams permiten mover información de un lugar a otro. Puede moverse entre
// diferentes partes de la memoria o entre la memoria y los dispositivos de almacenamiento. Para
// ello necesitamos el namespace System.IO para poder utilizarlo. Para trabajar correctamente
// con el stream podemos colocarnos en cualquier parte de éste referente al inicio, fin o posición
// actual. Una vez en la posición adecuada podemos llevar a cabo la lectura de los bytes en el
// stream. Una vez abierto el stream, y después de trabajar con él, es necesario cerrarlo para
// liberar cualquier recurso utilizado. Los streams también se pueden utilizar para el acceso al
// disco con los archivos, podemos abrir el archivo de diferentes formas y llevar a cabo
// manipulaciones de los archivos como borrarlos, renombrarlos, copiarlos o moverlos.


⭕ Paginas 375

Depuración
Hemos llegado al último capítulo del libro
y en este capítulo aprenderemos
las técnicas básicas de depuración.
La depuración es utilizada para corregir
problemas en el programa. Algunas veces
los programas tienen errores de sintaxis,
pero principalmente de lógica.
Al depurarlos podemos observar
su comportamiento de mejor forma
y detectar el comportamiento que está
dando problemas

⭕ Paginas 376


// CÓMO EMPEZAR A DEPURAR UN PROGRAMA
// Para depurar un programa nosotros tenemos varias herramientas, pero es importante en primer lugar conocer los posibles errores que podemos tener. Básicamente
// podemos tener dos clases de errores bien diferenciados: por un lado los errores de
// compilación y por otro los errores en tiempo de ejecución.
// Los errores de compilación son aquellos que impiden que el programa logre compilarse y generalmente son más fáciles de resolver. Muchos de estos errores se deben
// a problemas de sintaxis, es decir, son responsabilidad del usuario.
// Los errores en tiempo de ejecución son aquellos que suceden cuando el programa
// se está ejecutando. Estos errores pueden deberse a problemas de lógica, es decir, que
// el algoritmo no fue diseñado correctamente. Pero también pueden ocurrir debido a
// un mal control de la información, por ejemplo, podemos tratar de leer más allá de
// los límites correspondientes a un arreglo determinado.



// Para corregir los errores de compilación
// La mejor forma de poder aprender a depurar programas es con la práctica. Para esto crearemos un pequeño programa de ejemplo. El siguiente programa tiene varios
// errores para poder identificar y corregir. En el siguiente bloque de código, los errores han sido colocados en forma deliberada.


// LOS PROBLEMAS DE SINTAXIS
// Los problemas de sintaxis son sencillos de corregir, se deben a que se ha escrito algo de forma incorrecta. Algunas veces los nombres de variables se han escrito erróneamente, o hemos
// olvidado colocar ; al final de la sentencia. Una revisión rápida de la línea donde está el error nos
// permite encontrarlo, con la práctica también se reduce la incidencia de estos errores.

||
    static void Main(string[]args)
    {
        // Variables nesarias
        int a = 5;
        int b = 10; 
        int c = 0;
        int r = 0;

        // Hacemos la Division 
        r = b / c;
        // Mostramos el resultado 
        Console.WriteLine("El resultado es {} , r);

        // Mostramos el resultado 5 veces
        for(int n = 0 ; n < 5 ; n++)
        {
            Console.WriteLine("El resultado es {0}", r);
        }

        // Invocamos la funcion
        MuestraValor();
    }

    static void MuestraValor(int n)
    {
        Console.WriteLine("El resultado es {0} ", n);
    }

// PARA EVITAR ERRORES CON LOS BLOQUES DE CÓDIGO
// Cuando trabajamos con bloques de código un error común es olvidar cerrarlo. Para evitar esto,
// es buena costumbre cerrar el bloque de código inmediatamente después de abrirlo y luego colocar el código que va a llevar en su interior. Si abrimos y colocamos el código, puede suceder
// que olvidemos cerrarlo.


⭕ Paginas 378

// El programa tiene varios errores, algunos de ellos muy comunes, por lo que es importante aprender a reconocerlos y resolverlos.
// Para comenzar, lo primero que hacemos es llevar a cabo una compilación. Si hay
// un error de compilación, inmediatamente aparece una ventana. Esta ventana se conoce como lista de errores. Podemos observar esta ventana en la siguiente figura.

// Figura 1. Después de compilar el programa,
// podemos encontrar fácilmente la lista de errores.

// La ventana de la lista de errores contiene información importante que nos permite
// encontrar el error rápidamente. La lista tiene varias columnas. La primera columna
// nos indica si el elemento listado es un error o una advertencia. Esto depende del
// icono mostrado. Un icono con señal amarilla es una advertencia y el icono rojo un
// error. En la segunda columna tenemos el número secuencial de error.
// La tercera línea es muy importante, ya que es una descripción del error. Esta descripción nos da pistas sobre la posible causa del error. La siguiente columna indica
// el documento en el cual ocurrió el error. Esto es útil cuando tenemos programas
// que se constituyen en varios documentos. Las dos siguientes líneas nos dicen el lugar donde está el posible error indicando la línea y la columna. Un punto importante a tomar en cuenta es que la posición es solamente un indicador. Nuestra última columna indica el proyecto en el cual ocurrió el error, esto llega a ser útil cuan


⭕ Paginas 379

// Si observamos el editor, veremos que hay texto que aparece con un subrayado rojo. Esto indica el texto que está relacionado con la lista de errores y facilita su localización.
// Empecemos a corregir los errores. La depuración es un proceso iterativo, por lo
// que tenemos que ir corrigiendo errores hasta que no quede ninguno. En algunas
// ocasiones, cuando corrijamos un error aparecerán listados nuevos errores. No debemos preocuparnos por esto y tenemos que continuar corrigiendo los errores
// listados hasta que no quede ninguno.
// Cuando corregimos los problemas de nuestro programa, debemos referirnos a la lista de errores. Siempre tenemos que empezar con el primer problema. Esto se debe
// a que a veces un error en la parte superior del programa puede ocasionar que líneas que sean correctas parezcan que tienen problemas.
// En la lista debemos dar doble clic al primer error. Esto nos lleva automáticamente
// al código y señala la parte con el problema. Esto lo podemos observar en el ejemplo que se muestra en la siguiente figura.

// Figura 2. Podemos observar que la línea
// donde se encuentra el problema ha sido señalada.

// El problema señalado indica que se tiene una nueva línea en una constante. Esto
// generalmente ocurre cuando usamos una cadena y olvidamos cerrarla. Si observamos la línea veremos que efectivamente la cadena de formato no se ha cerrado. Procedamos a cerrar la cadena. De tal forma que la línea quede de la siguiente forma:


⭕ Paginas 380

// Mostramos el resultado
    Console.WriteLine("El resultado es {}" , r);


// Siempre que corregimos un problema, es bueno realizar una compilación. Esto actualizará la lista de errores y podemos proceder con el siguiente. Después de la compilación nuestra lista de errores se ha reducido a únicamente dos. 
// El siguiente error que corregiremos es muy común. Si vemos la descripción nos indica que se estaba esperando }. Este error ocurre cuando hemos olvidado cerrar un
// bloque de código. Puede ser a nivel de namespace, clase, método, ciclo, etc. La mejor forma de resolverlo es verificar nuestros bloques de código y adicionar el cierre
// donde corresponde. En muchas ocasiones el cierre no necesariamente es donde lo
// señala el editor, por lo que se necesita revisar correctamente dónde colocar el cierre.
// En nuestro caso es muy sencillo y lo adicionamos al final.
// Ya cerrado el bloque de código, podemos compilar y ver la lista de errores. Ahora
// únicamente nos aparece un error en la lista. Inicialmente teníamos cinco, hemos corregido dos y solo queda uno. Estos cambios en la cantidad de errores son muy comunes. Esto se debe a que los errores pueden suceder en cascada, como comentábamos, un error en la parte superior puede crear errores fantasma en otras partes. 
// El error que tenemos que corregir en este momento es muy sencillo y ocurre
// cuando olvidamos terminar la sentencia con ;. Simplemente lo adicionamos en
// la línea que corresponde. Al parecer ya hemos terminado de corregir los problemas. Compilemos y veamos qué sucede.
// Después de corregir el último error, han aparecido dos errores más. Como mencionábamos la depuración es iterativa y podemos pensar que el compilador hace varias pasadas. En este caso se nos presentan dos problemas en los métodos. 
// El primer error que tenemos nos indica que no se tiene una definición para WrteLine.
// Este tipo de error ocurre generalmente en dos casos. El primero es cuando estamos intentando usar algo, ya sea método, variable, objeto, etc. que no hemos definido. Para
// corregirlo simplemente definimos lo que necesitamos usar. El segundo caso es más común y se relaciona a un error de escritura, es decir que hemos escrito mal el nombre
// de lo que queremos utilizar y al no reconocerlo el compilador nos marca este error. 


// PARA EVITAR ERRORES DE ESCRITURA
// Una forma de evitar errores de escritura para variables y métodos es apoyarnos en la función de
// auto completar del editor. Esta función nos muestra el elemento que podemos colocar cuando
// escribimos las primeras letras del nombre. Al dar la tecla de ENTER, lo escribe por nosotros. Hacer una buena selección de nombres también ayuda a reducir los errores de escritura.


⭕ Paginas 381

// En nuestro ejemplo, el error está referenciado a un problema de escritura. Simplemente debemos ir al código y escribir WriteLine de la forma correcta. Compilemos
// y continuamos con el siguiente error
// Nuevamente nos queda un error. Este error nos dice que no hay un método sobrecargado. Este error suele pasar cuando tenemos una función o método y estamos
// pasando una cantidad errónea de parámetros o los parámetros son de un tipo no
// correcto. En nuestro programa vemos que el método MuestraValor() necesita de un
// parámetro, pero en la invocación no se está pasando ningún valor y esto genera el
// problema. Para resolverlo simplemente debemos colocar el valor a pasar. Por ejemplo podemos colocar la línea de la siguiente forma:

// Invocamos la funcion
MuestraValor(a); 

// Ahora podemos compilar nuevamente. La ventana de salida nos indica que se ha
// compilado exitosamente la aplicación. Esto significa que ya no tenemos errores de
// compilación, pero aún es posible tener errores en tiempo de ejecución.
// Cómo corregir los errores en tiempo de ejecución
// Los errores en tiempo de ejecución se hacen notar cuando el programa está corriendo. El error puede provocar que el programa deje de funcionar o se termine repentinamente. En otros casos el programa no da resultados correctos.
// Cuando el programa no da resultados correctos, esto puede deberse a que nuestro
// algoritmo no está adecuadamente implementado. En este caso, lo mejor es primero revisar el análisis y tratar de encontrar el error a nivel de algoritmo. Si encontramos el error en el algoritmo, simplemente debemos corregirlo y luego modificar el
// programa para que se ejecute de acuerdo con el algoritmo correcto.
// En el caso de que nuestro algoritmo esté correcto y el programa nos provee con resultados erróneos entonces es posible que la implementación, es decir la forma como pasamos el algoritmo a programa, este equivocada. La mejor forma de corregir
// esto es ir depurando paso a paso el programa, viendo cómo cambian los valores y
// de esta forma encontrar dónde falló la implementación. Las técnicas para llevar a
// cabo esto las veremos un poco más adelante.
// Ahora podemos ver los errores en tiempo de ejecución que provocan la finalización
// inesperada del programa. Muchos de estos errores se deben a que hemos realizado
// una operación indebida con nuestro programa. A los errores de este tipo se les llama excepciones y cuando ocurren se dice que se han levantado o aventado.
// Veamos cómo ocurren estos errores. Simplemente ejecutemos el programa anterior.
// El programa está listo para levantar una excepción.

⭕ Paginas 382

// Figura 3. En cuanto el programa levanta una excepción, finaliza
// su ejecución de forma inesperada y nos presenta un diálogo con información.

// Como vemos el programa ha levantado una excepción. Para poder depurar el programa debemos ejecutarlo en modo de depuración. Para esto seleccionamos el menú de Debug o Depurar y presionamos Start Debugging. 

// Figura 4. Aquí podemos seleccionar dónde llevar a cabo la depuración.

⭕ Paginas 383

// Ya que nos encontramos en el depurador, el lugar donde se generó la excepción aparece marcado en forma muy clara, y junto a él tendremos un cuadro de diálogo que
// contiene la información correspondiente

// Figura 5. El cuadro de dialogo nos indica el tipo de excepción que se levantó

// Si observamos el cuadro de diálogo veremos que la excepción, es decir el error,
// fue provocado por un intento de dividir entre cero. La división entre cero no está definida y por eso es una operación inválida. Ahora que ya sabemos qué provoca el problema, simplemente podemos corregir el código. 
// Podemos pensar que la corrección es sencilla y simplemente dividir entre la variable que tiene un valor de cero, puede ser algo como lo que se muestra en el siguiente bloque de código, a modo de ejemplo:

// LA DESCRIPCIÓN DEL ERROR

// Debemos acostumbrarnos a leer la descripción del error, es un punto muy importante. Con el
// tiempo nos acostumbraremos a la descripción y sabremos inmediatamente qué hacer para resolver el problema. Muchos programadores con malos hábitos solamente van a la línea del error,
// pero no leen la descripción del error. Esto los lleva a tiempos más largos para resolverlo.


___________________________________________________________________________________________________

⭕ Paginas 
//🛑 Paginas 
