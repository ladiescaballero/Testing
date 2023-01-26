
Console.WriteLine({0},datos[2]);


impuesto = datos[1] * 0.15;


elementos = datos.Count();

// Para Actualizar o insertar elementos se necesita dos parametros indice y el elemento 

datos.Insert(1,10);
datos.Insert(2,50);

// para eliminar un elemento solo se necesita un parametro. que es el indice 

datos.RemoveAt(3);

// para saber si se encuentra un elemento dentro de este se usa el metodo solo requiere un parametro 

indice = datos.IndexOf(7);




