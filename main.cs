using System;

/*
La clase principal de la cual se tomara la herencia se denomina Superclase y las clases que toman la herencia se llaman subclases.
Una clase en donde no hay constructor se toma implicitamente el constructor por defecto. El cual es que no recibe parametro alguno y se encuentra vacío.
Las subclases llaman implicitamente al constructor de la superclase. el constructor de la subclase llama al constructor padre atraves de la :base.
Los constructores de las subclases le dicen a la clase padre inicia los objetos llamando al constructor padre a traves :base.
En caso programemos un constructor explicito, este constructor remplaza al constructor por defecto, y solo valdra el que hemos construido.
Repercute en la herencia por lo que la instruccion :base ya no sirve 
*/
class MainClass {
  public static void Main (string[] args) {
		//indicar error por lo que de acuerdo al constructor que recibe parametro debemos agregar el parametro en el objeto
    Caballo Babieca = new Caballo("Fugaz");
		Humano Juan = new Humano("Juan");
		Gorila Copito = new Gorila("Copito");
    Juan.getNombre();
    Copito.getNombre();
    Babieca.getNombre();
    Babieca.galope();
    Juan.pensar();
    Copito.trepar();
    Copito.respirar();
  }

	class Mamifero{
    //campo de clase para utilizar este dato desde constructor
    private string nombreSerVivo;

		public void respirar(){
			Console.WriteLine("Soy capaz de respirar");
		}
    public void cuidarCrias(){
      Console.WriteLine("Soy capaz de cuidar crías");
    }
    public void getNombre(){
      Console.WriteLine("El nombre del ser vivo es: " + nombreSerVivo);
    }
    //constructor por dfecto que deja de servir al crear un nuevo constructor explicito
    //public Mamiferos(){}

    //creamos el constructor explicito por lo tanto debemos crear un constructor para todas las sub clases
    public Mamifero(string nombre){
      nombreSerVivo = nombre;
    }

	}

  class Caballo:Mamifero{
    public Caballo(string nombreCaballo):base(nombreCaballo){}

    public void galope(){
      Console.WriteLine("Soy capaz de galopar");
    }
  }

  class Humano:Mamifero{
    //constructor creado con instruccion base debido al constructor explicito del padre
    public Humano(string nombreHumano):base(nombreHumano){}

    
    public void pensar(){
      Console.WriteLine("Soy capaz de pensar");
    }
  }

  class Gorila:Mamifero{
    //constructor creado con instruccion base debido al constructor explicito del padre
    public Gorila(string nombreGorila):base(nombreGorila){}
    
    public void trepar(){
      Console.WriteLine("Soy capaz de trepar");
    }
  }
}
  