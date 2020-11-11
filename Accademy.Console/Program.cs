
using Accademy.GeometryAbstract;
using Accademy.Helper;
using HumanResources;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Accademy.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestSplit();
            //TestReadFile();
            //TestHR();
            //TestGeometry();
            //TestGeometryAbstract();
            //TestLoops();
            //TestRandom();
            // TestGeneric();
            //TestUni_001();
            //TestUni_002();
            Test_Tris();

        }

        private static void Test_Tris()
        {
            //creare casualmente una matrice 3x3 che contengono 1 o 0 e vedere se c'è una soluzione del tris
            //ciclo while finchè non vince qaulcuno: giocatore A->1 e gioatore B->2 limitato ad un contatore di 9 mosse
            //giocatoreA mette 1 in una posizione qualsiasi, giocatoreB mette 2 in una posizione non occupato
            //Ogni volta che un giocatore fa una mossa devo verificare se ha vinto
            int[,] Tris = new int[3, 3];

            initTris(Tris);

            bool ThereIsaWinner = false;
            bool NoMoreMoves = false;
            bool A_isWinner = false;
            bool B_isWinner = false;

            while (!ThereIsaWinner && !NoMoreMoves)
            {
                Move(1, Tris); //A è il mio 1, B è il mio 2

                A_isWinner = IsWinner(1, Tris);

                if (A_isWinner)                
                    ThereIsaWinner = true;             
                else
                {
                    if (!ThereAreMoves(Tris))                   
                        NoMoreMoves = true;                   
                    else
                    {
                        Move(2, Tris);
                        B_isWinner = IsWinner(2, Tris);

                        if (B_isWinner)                        
                            ThereIsaWinner = true;
                        else
                        {
                            if (!ThereAreMoves(Tris))
                                NoMoreMoves = true;
                        }
                    }
                }
            }

            /*Per muovere: pesco e poi calcolo i numeri modulo 9, ciclando se la casella pescata è vuota,
            Altrimenti pesco ogni volta tra un numero minore di elementi e occupo la k-esima casella vuota.           
            ThereAreMoves basta inizializzare a 0 tutto e controllare se ci sono degli zeri...
            IsWinner facciamo 3 funzioni che controllino righe, colonne e diagonali, e ogni volta che dobbiamo controllare
            se x ha vinto, vedere dove stanno i suoi simboli e controllare solo per quelli... faremo al più 27 controlli quindi okay... */

            PrintTris(Tris);
            System.Console.WriteLine("'A is Winner' is {0}; 'B is Winner' is {1}", A_isWinner.ToString(), B_isWinner.ToString());
            System.Console.ReadLine();
        }

        private static bool IsWinner(int v, int[,] matrix)
        {
            bool result = false;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == v)
                    {
                        result = RowControl(v, i, matrix);
                        if (result == true) 
                            break;
                        result = ColumnControl(v, j, matrix);
                        if (result == true) 
                            break;
                        if ((i + j) % 2 == 0) 
                            result = DiagonalControl(v, i, j, matrix);
                        if (result == true) 
                            break;
                    }
                }

                if (result == true) 
                    break;
            }
            return result;
        }

        private static bool DiagonalControl(int v, int i, int j, int[,] matrix)
        {
            bool diagonal = false;
            bool antidiagonal = false;

            if (i == j)
            {
                diagonal = true;

                for (int k = 0; k < matrix.GetLength(0); k++)
                {
                    if (matrix[k, k] == v) 
                        diagonal = diagonal && true;
                    else 
                        diagonal = diagonal && false;
                }
            }
            if (i + j == 2)
            {
                antidiagonal = true;

                for (int k = 0; k < matrix.GetLength(0); k++)
                {
                    if (matrix[k, matrix.GetLength(0) - 1 - k] == v) 
                        antidiagonal = antidiagonal && true;
                    else 
                        antidiagonal = antidiagonal && false;
                }
            }
            return (diagonal || antidiagonal);
        }

        private static bool ColumnControl(int v, int j, int[,] matrix)
        {
            bool isEqual = true;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, j] == v) 
                    isEqual = isEqual && true;
                else 
                    isEqual = isEqual && false;
            }
            return isEqual;
        }

        private static bool RowControl(int v, int i, int[,] matrix)
        { //restituisce true se v è vincitore lungo la riga i

            bool isEqual = true;

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == v) 
                    isEqual = isEqual && true;
                else 
                    isEqual = isEqual && false;
            }
            return isEqual;
        }

        private static bool ThereAreMoves(int[,] matrix)
        {
            bool result = false;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        result = true;
                        break;
                    }
                }
                if (result == true) 
                    break;
            }
            return result;
        }

        private static void Move(int v, int[,] matrix)
        {
            int position = Accademy.Helper.Helper.GetRandomInt(0, 9);

            while (!isAvailable(position, matrix))
                position = (position + 1) % 9;
            
            matrix[position / 3, position % 3] = v;
        }

        private static bool isAvailable(int position, int[,] matrix)
        {
            bool result = false;

            if (matrix[position / 3, position % 3] == 0) 
                result = true;

            return result;
        }

        private static void PrintTris(int[,] matrix)
        {
            char[,] temp = new char[matrix.GetLength(0), matrix.GetLength(1)];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 0) 
                        temp[i, j] = ' ';
                    if (matrix[i, j] == 1) 
                        temp[i, j] = 'X';
                    if (matrix[i, j] == 2) 
                        temp[i, j] = 'O';
                }
            }

            System.Console.WriteLine("{0}\t{1}\t{2}", temp[0, 0], temp[0, 1], temp[0, 2]);
            System.Console.WriteLine("{0}\t{1}\t{2}", temp[1, 0], temp[1, 1], temp[1, 2]);
            System.Console.WriteLine("{0}\t{1}\t{2}", temp[2, 0], temp[2, 1], temp[2, 2]);
        }

        private static void initTris(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)               
                    matrix[i, j] = 0;               
            }
        }

        private static void TestUni_002()
        {
            string b = "11011001";
            int converted_binary = Accademy.Helper.Helper.ConvertBinaryToint(b);
            System.Console.WriteLine(converted_binary);
            System.Console.ReadLine();
        }

        private static void TestUni_001()
        {
            /// <summary>
            /// Scrivere un programma "Tutti uguali" che prevede un array di 10 numeri interi 
            /// contenente valori a piacere (senza bisogno di chiederli all’utente) e stampa "tutti uguali" se i valori
            /// dell’array sono tutti uguali, oppure stampa "non tutti uguali" altrimenti. (Il programma deve essere
            /// scritto facendo finta di non sapere quali siano i valori inseriti nell’array). Per riempire l'array utilizare
            /// la classe Helper in due casi:
            /// 1-Restituisce valori casuali;
            /// 2-Restituisce valori uguali
            /// </summary>
            /// 

            int[] array = new int[10];
            int[] array_cas = new int[10];

            for (int i = 0; i < 10; i++)
            {
                array_cas[i] = Accademy.Helper.Helper.GetRandomInt(1, 10);
                array[i] = Accademy.Helper.Helper.GetSameInt(100);
            }

            bool tuttiUguali = PrintArray(array);
            bool tuttiUguali_2 = PrintArray(array_cas);

            if (tuttiUguali)
                System.Console.WriteLine("array uguali result: Tutti uguali");
            else
                System.Console.WriteLine("array uguali result: non Tutti uguali");

            if (tuttiUguali_2)
                System.Console.WriteLine("array diversi result: Tutti uguali");
            else
                System.Console.WriteLine("array diversi result: non Tutti uguali");

            bool tuttiDiversi = ArrayIsComposedofAllDifferentNumber(array_cas);

            if (tuttiDiversi)
                System.Console.WriteLine("Gli elementi dell'array sono tutti diversi");
            else
                System.Console.WriteLine("Ci sono elementi nell'array uguali");

            System.Console.ReadLine();
        }

        private static bool ArrayIsComposedofAllDifferentNumber(int[] array_of_int)
        {
            bool diff = true;

            for (int i = 0; i < array_of_int.Length; i++)
            {
                for (int j = i + 1; j < array_of_int.Length; j++)
                {
                    if (array_of_int[i] == array_of_int[j])
                    {
                        diff = false;
                        break;
                    }
                }
                if (diff == false)
                    break;
            }
            return diff;
        }

        private static bool PrintArray(int[] array_int)
        {
            bool tuttiUguali = true;
            int first = array_int[0];
            for (int i = 1; i < array_int.Length; i++)
            {
                if (array_int[i] != first)
                {
                    tuttiUguali = false;                   
                    break;
                }
            }
            return tuttiUguali;
           

        }

        private static void TestGeneric()
        {
            List<int> lst_int = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }; //inserimento manuale a priori

            if (lst_int.Contains(3))
                System.Console.WriteLine("3 is in List");

            List<Persona> lst_persona = new List<Persona>();
            Persona mario = new Persona("Mario", "Rossi");
            Persona maria = new Persona("Maria", "Bianchi");
            Persona gianni = new Persona("Gianni", "Giallo");


            lst_persona.Add(mario);
            lst_persona.Add(maria);
            lst_persona.Add(gianni);

            Persona p = new Persona("Mario", "Rossi");

            if (lst_persona.Contains(p))
                System.Console.WriteLine("Persona is in List");
            else
                System.Console.WriteLine("Persona is NOT in List");

            System.Console.WriteLine(p.Equals(mario));   //p e mario sono la stessa persona?-->mi dà true-> verifico con l'hashcode
            System.Console.WriteLine(p.GetHashCode());
            System.Console.WriteLine(mario.GetHashCode());

            Persona sosia_mario = mario;
         

            //System.Console.WriteLine(sosia_mario.GetHashCode());
            //System.Console.WriteLine(mario.GetHashCode());
            System.Console.ReadLine();

        }

        private static void TestRandom()
        {
          //apertura file di testo in scrittura
            String dir = @"C:\temp";
            String filename = "accademy_random.txt";
            String path = System.IO.Path.Combine(dir, filename);
         
          System.IO.StreamWriter accademy_randomFile = new System.IO.StreamWriter(path);

            int min = 1;
            int max = 1000;

            for (int i = 0; i < 100; i++)
            {
                //scrittura su file di 100 numeri casuali
                //int r = Accademy.Helper.Helper.GetRandomInt(min, max);
                //accademy_randomFile.WriteLine(r);
                try
                {
                    int r = Accademy.Helper.Helper.GetRandomInt(min, max);
                    accademy_randomFile.WriteLine(r);
                }
                catch (RandomArgumentsException excp)
                {
                    System.Console.WriteLine(excp.Message);
                    break;
                }
                finally
                {
                    //................
                }
            }

            accademy_randomFile.Close();
  
            //apertura del file di testo in lettura
            System.IO.StreamReader file = new System.IO.StreamReader(path);

            string line;

            while ((line = file.ReadLine()) != null)
            {
                int randomInt = 0;
                try
                {
                    randomInt = Int32.Parse(line); //converte stringa in intero
                }
                catch (FormatException excp)
                {
                    System.Console.WriteLine(excp.Message);
                }
                System.Console.WriteLine(randomInt+1000);
            }
            file.Close();
            System.Console.ReadLine();
        }
        private static void TestLoops()
        {
            //-------------------------ESERCIZIO 1-----------------------------------------
            /*   //declare string
               string s = "0123456789";
               System.Console.WriteLine(s + "\r\n");

               // trasformarla in array di caratteri
               char[] c = s.ToCharArray();
               int len = c.Length;
               char[] new_Array = new char[len];

               //usare il for per invertire l'ordine dei caratteri
               for (int i = 0; i < len; i++)
               {
                   new_Array[i]=c[len -1-i]; 
               }

               // trasformare il nuovo array in string: concatenzaione dei singoli caratteri alla stringa (fare un for). NO ToString
               // e stamapre a video
               string[] new_s= new string[len];

               for (int i = 0; i < len; i++)
               {
                   new_s[i] += new_Array[i];
                   System.Console.Write(new_s[i]);
               }
               System.Console.ReadLine();
            */
            //----------------------------------------ESERCIZIO 2----------------------------------------
            // METODO LISTE: GENERICS
            List<char> charList = new List<char>();

            // ciclo for di 10 iterazioni per inserire nella lista una serie di caratteri
            for (int i = 64; i < 74; i++)
            {
                charList.Add(Convert.ToChar(i)); //aggiunge i caratteri in lista
            }
            foreach (char l in charList)
            {
                System.Console.Write(l);
            }
            System.Console.WriteLine("\r\n");

            //dichiarare un array di char della stessa lunghezza della lista
            char[] charArray = new char[charList.Count];

            //ciclo foreach sulla lista e inserimento inverso nell'array
            int j = charList.Count - 1;
            foreach (char c1 in charList)
            {
                charArray[j] = c1;
                j--;
            }

            //trasformare l'array in una lista
            List<char> newList = charArray.ToList();

            //ciclo foreach sulla seconda lista (con la stringa in ordine inverso) per stampare i char
            foreach (char c2 in newList)
            {
                System.Console.Write(c2);
            }
            System.Console.ReadLine();
        }
        private static void TestGeometryAbstract()
        {
            GeometryAbstract.Quadrato q1 = new GeometryAbstract.Quadrato(11.009);
            GeometryAbstract.Cerchio c1 = new GeometryAbstract.Cerchio(9.25);

            /*Siccome tutte le figure devono essere stampate con area e perimetro (hanno lo stesso comportamento->polimorfismo), 
            piuttosto che creare un metodo di stampa per ognuna, fare sempre lo stesso metodo PrintFigura tramite 
            l'implementazione di una classe astratta FiguraGeometrica che contiene (nel nostro caso) 2 metodi astratti.*/
            PrintFiguraAbstract(q1);
            PrintFiguraAbstract(c1);

        }
        private static void PrintFiguraAbstract(GeometryAbstract.FiguraGeometrica f)
        {
            string s = f.GetDescription();
            System.Console.WriteLine(s);
        }
        private static void TestGeometry()
        {
            Accademy.Geometry.Quadrato q1 = new Accademy.Geometry.Quadrato(12.98);  //metto tutto il percorso perchè in GeometryAbstract ci sono gli stessi nomi: anche lo using servirebbe a poco. Faccio così per non fare confusioni
            Accademy.Geometry.Cerchio c1 = new Accademy.Geometry.Cerchio(11.75);
            Accademy.Geometry.Rettangolo r1 = new Accademy.Geometry.Rettangolo(11.77, 33.99);
            Accademy.Geometry.Triangolo t1 = new Accademy.Geometry.Triangolo(3, 4, 5);

            //System.Console.WriteLine("Area {0}, Perimetro {1}", q1.GetArea(), q1.GetPerimetro());
            //System.Console.WriteLine("Area {0}, Perimetro {1}", c1.GetArea(), c1.GetPerimetro());

            //quello di sopra e sotto sono la stessa cosa: cambia il fatto che la stampa l'ho fatta come metodo

            //PrintQuadrato(q1);
            //PrintCerchio(c1);

            /*Siccome tutte le figure devono essere stampate con area e perimetro (hanno lo stesso comportamento->polimorfismo), 
            piuttosto che creare un metodo di stampa per ognuna, fare sempre lo stesso metodo PrintFigura tramite 
            l'implementazione di un'interfacia.*/
            PrintFigura(q1);
            PrintFigura(c1);
            PrintFigura(r1);
            PrintFigura(t1);
        }
        private static void PrintFigura(Accademy.Geometry.IFiguraGeometrica f)
        {
            System.Console.WriteLine("Area {0}, Perimetro {1}", f.GetArea(), f.GetPerimetro());
        }
        private static void PrintCerchio(Accademy.Geometry.Cerchio c1)
        {
            System.Console.WriteLine("Area {0}, Perimetro {1}", c1.GetArea(), c1.GetPerimetro());
        }
        private static void PrintQuadrato(Accademy.Geometry.Quadrato q1)
        {
            System.Console.WriteLine("Area {0}, Perimetro {1}", q1.GetArea(), q1.GetPerimetro());
        }
        private static void TestHR()
        {

            Persona mario = new Persona("Mario", "Rossi"); //istanza di perosna
            
           
            Impiegato imp = new Impiegato();

            //System.Console.WriteLine(mario.ToString());

            String s1 = "";
            s1 = String.Empty;
            
            String s2 = "aaaa";
            String s3 = String.Concat(s1, s2);

            System.Console.WriteLine(s3.Length);
            

            //System.Console.WriteLine("Istanza mario: {0}, {1}", mario.Nome, mario.Cognome);
            System.Console.ReadLine();
        }
        private static void TestSplit()
        {
            // using String[] Split(char[] separator, StringSplitOptions options);
            string s = "25.67\t998.41"; //ho un file formattato in tal modo: tipo pressione.txt
            char[] chararray = new char[1]; 
            chararray[0] = '\t'; // ascii code  0x09 

            char carriageReturn = '\r'; // ascii code 0x13

            char lineFeed = '\n';  // ascii code 0x10

            char a = 'a'; // ascii code 0x61 -> 00100101
            char b = 'b'; // ascii code 0x62
            char c = 'c'; // ascii code 0x63

            String[] resultArray = s.Split(chararray); //splitto secondo il caratattere tab

            string temperature = resultArray[0];
            string pressure = resultArray[1];

            float temp_float = float.Parse(temperature, CultureInfo.InvariantCulture); //converte la stringa in intero, cultureInfo serve per riconoscere il formato della virgola
            float press_float = float.Parse(pressure, CultureInfo.InvariantCulture);

            System.Console.WriteLine("Temperatura {0} Pressione {1}", temp_float, press_float);
            System.Console.ReadLine();
        }
        private static void TestReadFile()
        {
            String dir = @"C:\temp";
            String filename = "pressione.txt";
            String path = dir + @"\" + filename;

            String out_temp = "temperature.txt";
            String out_press = "pressure.txt";

            System.IO.StreamWriter tempOutputFile = new System.IO.StreamWriter(
                                    System.IO.Path.Combine(dir, out_temp));

            System.IO.StreamWriter pressOutputFile = new System.IO.StreamWriter(
                                    System.IO.Path.Combine(dir, out_press));

            int counter = 0;
            string line;

            // Read the file and display it line by line.  
            System.IO.StreamReader file = new System.IO.StreamReader(path);

            float max_float = float.MaxValue; //MaxValue è un valore predefinito
            float min_float = float.MinValue;

            float min_temp = max_float;
            float min_press = max_float;

            float max_temp = min_float;
            float max_press = min_float;

            float sum_temp = 0;
            float sum_press = 0;

            char[] chararray = new char[1];
            chararray[0] = '\t'; // ascii code  0x09 

            while ((line = file.ReadLine()) != null)
            {
                if (counter > 0)
                {
                    String[] resultArray = line.Split(chararray);

                    tempOutputFile.WriteLine(resultArray[0]);
                    pressOutputFile.WriteLine(resultArray[1]);

                    float temp_float = float.Parse(resultArray[0], CultureInfo.InvariantCulture);
                    float press_float = float.Parse(resultArray[1], CultureInfo.InvariantCulture);

                    if (temp_float > max_temp)
                        max_temp = temp_float;                       
                    if (temp_float < min_temp)
                        min_temp = temp_float;

                    if (press_float > max_press)
                        max_press = press_float;
                    if (press_float < min_press)
                        min_press = press_float;

                    sum_temp = sum_temp + temp_float;
                    sum_press += press_float;

                }
                counter++;
            }
            file.Close();
            tempOutputFile.Close();
            pressOutputFile.Close();

            float media_temp = sum_temp / (counter - 1);
            float media_press = sum_press / (counter - 1);

            System.Console.WriteLine(media_temp);
            System.Console.WriteLine(media_press);

            System.Console.WriteLine("There were {0} lines.", counter);
            System.Console.WriteLine("Max temperature {0}, Min Temperature {1}", max_temp, min_temp);
            System.Console.WriteLine("Max pressure {0}, Min pressure {1}", max_press, min_press);
            System.Console.ReadLine();
        }
    }
}
