using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_sena {
	class Program {
		static void Main(string[] args) {
			Program menu = new Program();
			int opcion = 0;

			do {
				menu.Menu();
				Console.Write("Digita una opcion para ver la resolucion del ejercicio: ");
                opcion = int.Parse( Console.ReadLine() );
				
				Console.WriteLine();
				switch (opcion) {
                    case 0:
						menu.AsciiArt("pac_firma.txt");
						menu.Firma();
					break;

					case 1:
						menu.Ejercicio1();
						Console.ReadKey();
					break;

					case 2:
						menu.Ejercicio2();
						Console.ReadKey();
					break;

					case 3:
						menu.Ejercicio3();
						Console.ReadKey();
					break;

					case 4:
						menu.Ejercicio4();
						Console.ReadKey();
					break;

					case 5:
						menu.Ejercicio5();
						Console.ReadKey();
					break;

					case 6:
						menu.Ejercicio6();
						Console.ReadKey();
					break;

					case 7:
						menu.Ejercicio7();
						Console.ReadKey();
					break;

					case 8:
						menu.Ejercicio8();
						Console.ReadKey();
					break;

					case 9:
						menu.Ejercicio9();
						Console.ReadKey();
					break;

					case 10:
						menu.AsciiArt("logo_sena.txt");
						Console.ReadKey();
					break;

					default:
						Console.WriteLine("¡Opcion inválida!\n");
					break;
                }

				menu.cleanScreen();
			} while(opcion > 0);
			
		}

		private void Menu() {
			this.Centrar("Servicio Nacional de Aprendizaje SENA");
			this.Centrar("Centro Nacional");
			this.Centrar("Colombo Aleman");

			Console.WriteLine("1. Ejercicio 1");
			Console.WriteLine("2. Ejercicio 2");
			Console.WriteLine("3. Ejercicio 3");
			Console.WriteLine("4. Ejercicio 4");
			Console.WriteLine("5. Ejercicio 5");
			Console.WriteLine("6. Ejercicio 6");
			Console.WriteLine("7. Ejercicio 7");
			Console.WriteLine("8. Ejercicio 8");
			Console.WriteLine("9. Ejercicio 9");
			Console.WriteLine("10. Mostrar logo del sena en ASCII Art");
			Console.WriteLine("0. Salir");
		}

		private void Ejercicio1() {
			// Ejercicio 1
			Console.WriteLine("Ejercicio1");
			float num1 = 0, num2 = 0, num3 = 0, res = 0;
			Console.WriteLine("Digite el primer numero:");
			num1 = float.Parse(Console.ReadLine());

			Console.WriteLine("Digite el segundo numero:");
			num2 = float.Parse(Console.ReadLine());

			Console.WriteLine("Digite el tercer numero:");
			num3 = float.Parse(Console.ReadLine());

			res = num1 + num2 + num3;
			Console.WriteLine("La sumatoria de los tres numeros es: " + res);
		}

		private void Ejercicio2() {
			Console.WriteLine("Ejercicio2");
			float num1 = 0, num2 = 0;
			float suma = 0, resta = 0, multiplicacion = 0;
			double division = 0;
			Console.WriteLine("Digite el primer numero:");
			num1 = float.Parse(Console.ReadLine());

			Console.WriteLine("Digite el segundo numero:");
			num2 = float.Parse(Console.ReadLine());

			suma = num1 + num2;
			resta = num1 - num2;
			multiplicacion = num1 * num2;
			division = num1 / num2;

			Console.WriteLine("El resultado de la suma es: " + suma);
			Console.WriteLine("El resultado de la resta es: " + resta);
			Console.WriteLine("El resultado de la multiplicacion es: " + multiplicacion);
			Console.WriteLine("El resultado de la division es: " + division);
		}

		private void Ejercicio3() {
			Console.WriteLine("Ejercicio3");
			float distancia = 0, tiempo = 0;
			double velocidad = 0;
			Console.WriteLine("Digite la distancia(en Kilometros):");
			distancia = float.Parse(Console.ReadLine());

			Console.WriteLine("Digite digite el tiempo(horas):");
			tiempo = float.Parse(Console.ReadLine());

			// Velocidad en m/s
			// velocidad = (distancia * 1000) / (tiempo * 3600);

			// Velocidad en Km/h
			velocidad = distancia / tiempo;
			Console.WriteLine("La velocidad a la que se desplazaba el auto es: " + velocidad + "Km/h");
		}

		private void Ejercicio4() {
			Console.WriteLine("Ejercicio4");
			double total_compra = 0, descuento = 0, iva = 0, total = 0;
			Console.Write("Digite el valor de la compra: ");

			total_compra = double.Parse(Console.ReadLine());
			iva = total_compra * 0.16;
			descuento = total_compra * 0.1;
			total = (total_compra - descuento) + iva;

			Console.WriteLine("Valor de la compra:" + total_compra);
			Console.WriteLine("Descuento de 10%: " + descuento);
			Console.WriteLine("Iva: " + iva);
			Console.WriteLine("Valor total: " + total);
		}

		private void Ejercicio5() {
			Console.WriteLine("Ejercicio5");
			float horas = 0, minutos = 0, segundos = 0;
			double total_hora = 0;
			Console.WriteLine("Digite la hora:");

			Console.WriteLine("Hora:");
			horas = float.Parse(Console.ReadLine());

			Console.WriteLine("Minutos:");
			minutos = float.Parse(Console.ReadLine());

			Console.WriteLine("Segundos:");
			segundos = float.Parse(Console.ReadLine());

			total_hora = (horas * 3600) + (minutos * 60) + segundos;
			Console.WriteLine("La hora medida en segundos equivale a: " + total_hora);
		}

		private void Ejercicio6() {
			Console.WriteLine("Ejercicio6");
			float radio = 0, diametro = 0, area = 0, volumen = 0;
			Console.WriteLine("Digite el radio: ");
			radio = float.Parse(Console.ReadLine());
			diametro = 2 * radio;
			area = (float)(3.1416 * Math.Pow(radio, 2));
			volumen = (float)((4 / 3) * 3.1416 * Math.Pow(radio, 3));

			Console.WriteLine("El valor de diametro es: " + diametro);
			Console.WriteLine("El valor de area es: " + area);
			Console.WriteLine("El valor de volumen es: " + volumen);
		}

		private void Ejercicio7() {
			Console.WriteLine("Ejercicio7");
			double nota1 = 0, nota2 = 0, nota3 = 0, nota_final = 0;
			Console.WriteLine("Digite las notas:");

			Console.WriteLine("Primera nota:");
			nota1 = float.Parse(Console.ReadLine());

			Console.WriteLine("Segunda nota:");
			nota2 = float.Parse(Console.ReadLine());

			Console.WriteLine("Tercera nota:");
			nota3 = float.Parse(Console.ReadLine());

			nota_final = ((nota1 * 0.2) + (nota2 * 0.3) + (nota3 * 0.5));
			Console.WriteLine("La nota final es: " + nota_final);
			Console.ReadKey();
		}

		private void Ejercicio8() {
			Console.WriteLine("Ejercicio8");
			float vel_c1 = 0;
			float vel_c2 = 0;

			float distancia_ventaja = 0;

			float distancia_car1 = 0;
			float distancia_car2 = 0;

			float tiempo_car1 = 0;
			float tiempo_car2 = 0;

			float tiempo_win = 0;

			/**
			 * Formulas:
			 * velocidad = distancia / tiempo
			 * tiempo = distancia / velocidad
			 * distancia = velocidad * tiempo 
			*/

			Console.WriteLine("---Distancia recorrida---\n");

			Console.Write("Digita la velocidad del Carro1(Km/h): ");
			vel_c1 = float.Parse(Console.ReadLine());

			Console.Write("Digita la distancia de ventaja para el Carro1(Km): ");
			distancia_ventaja = float.Parse(Console.ReadLine());

			Console.WriteLine("\n*** Inicia recorrido de Carro2 ***\n");

			Console.Write("Digita la velocidad del Carro2(Km/h): ");
			vel_c2 = float.Parse(Console.ReadLine());

			// -------------- Operaciones --------------

			// Respuesta al problema
			tiempo_win = distancia_ventaja / (vel_c2 - vel_c1);

			// Distancia carro1
			distancia_car1 = (vel_c1 * tiempo_win) + distancia_ventaja;
			// Tiempo carro1
			tiempo_car1 = distancia_car1 / vel_c1;

			// Distancia carro2
			distancia_car2 = vel_c2 * tiempo_win;
			// Tiempo carro2
			tiempo_car2 = distancia_car2 / vel_c2;

			Console.WriteLine("\nEl tiempo que tarda el Carro2 en alcanzar al Carro1 es: " + tiempo_win + " Horas");
			Console.WriteLine("Al alcanzarlo el Carro1 llevará un tiempo en carretera de: " + tiempo_car1 + " Horas");
			Console.WriteLine("Y ambos llevaran una distancia recorrida de: " + distancia_car2 + "Km"); // Aqui puede ir tanto la variable de distancia del carro1 como la del carro2, ya que se encotraran en la via, la distancia recorrida va a ser la misma para ambos
		}

		private void Ejercicio9() {
			Console.WriteLine("Ejercicio9");
			// Ejercicio 9
			float radio = 0;
			float altura = 0;
			float velocidad = 0;

			float tiempo = 0;
			float volumen = 0;

			/**
			 * Formulas:
			 * tiempo = distancia / velocidad
			 * volumen = (PI * r^2) * h
			 */

			Console.WriteLine("---Tiempo de llenado---\n");

			Console.Write("Ingresa el radio del cilindro: ");
			radio = float.Parse(Console.ReadLine());

			Console.Write("Ingresa la altura del cilindro(cm): ");
			altura = float.Parse(Console.ReadLine());

			Console.Write("Ingresa la velocidad de llenado(cm/seg): ");
			velocidad = float.Parse(Console.ReadLine());

			tiempo = altura / velocidad;
			volumen = (float)((3.1416) * Math.Pow(radio, 2)) * altura;

			Console.WriteLine("El tiempo que tardará el cilindro en llenarse es: " + tiempo + "seg");
			Console.WriteLine("La cantidad de liquido que tendrá el cilindro es: " + volumen + "cm3");
		}

		private void AsciiArt(String nom_txt) {
			System.IO.StreamReader archivo = new System.IO.StreamReader(nom_txt);
			String linea = "";

			while( (linea = archivo.ReadLine()) != null ) {
				this.Centrar( linea );
			}

			archivo.Close();
		}

		private void Centrar(String cadena) {
			Console.SetCursorPosition((Console.WindowWidth - cadena.Length) / 2, Console.CursorTop);
			Console.WriteLine(cadena);
		}

		private void Firma() {
			this.Centrar("Programa realizado por:");
			this.Centrar("Fernando Florez");
			this.Centrar("Licencia Creative Commons - BY, SA");
			Console.ReadKey();
		}

		private void cleanScreen() {
			// this.RunCommandShell("cls");
			Console.Clear();
		}
	}
}
