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














// ⏲

