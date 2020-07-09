using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int lebensEnergie = 100;
    public double power = 0.40;
    public float hunger = 0.6F;
    public string spielername = "Schorsch";
    public char kurzzeichen = 's';
    public bool lebt = true;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Die Lebensenergie ist " + lebensEnergie);
        Debug.Log("Die Power ist " + power);
        Debug.Log("Der Hunger ist " + hunger);
        Debug.Log("Der Name ist " + spielername);
        Debug.Log("Sein Zeichen ist " + kurzzeichen);
        if (lebt == true)
        {
            Debug.Log("Er lebt noch");
        }
        else
        {
            Debug.Log("Er ist tot");
        }

        // Die Methode addition aufrufen und das Ergebnis ausgeben
        Debug.Log(" Die Gesamtenergie ist " + addition(lebensEnergie, lebensEnergie));

        //Array erstellen
        int[] primZahl = new int[5] { 2, 3, 5, 7, 11 };
        //Array ausgeben 1te Methode
        Debug.Log("Erste Primzahl: " + primZahl[0]);
        Debug.Log("ZweitePrimzahl: " + primZahl[1]);
        Debug.Log("Dritte Primzahl: " + primZahl[2]);
        Debug.Log("Vierte Primzahl: " + primZahl[3]);
        Debug.Log("Fünfte Primzahl: " + primZahl[4]);
        //Array ausgeben 2te Methode
        int ersteZahl = primZahl[0];
        Debug.Log("1te Primzahl: " + ersteZahl);


        //Wert in Array überschreiben
        primZahl[0] = 13;
        Debug.Log("Erste Primzahl: " + primZahl[0]);

        //String in Array
        string[] name = new string[2] { "Joe ", "Muster" };
        Debug.Log(name[0] +name[1]);


        // For Schleife (Kopfgesteuert)
        for (int i = 0; i < 5; i++)
        {
            Debug.Log("Die For-Zahl i ist " + i);
        }


        //Die while Schleife (Kopfgesteuert)
        //Es wird erst die Bedingung geprüft, dann wird der Code ausgeführt
        int a = 0;
        while (a < 5)
        {
            Debug.Log(" Die while-Zahl a ist " + a);
            a++;
        }


        // Die do-while Schleife (Fussgesteuert)
        // Erst wird der Code ausgeführt, dann wird die Bedingung geprüft
        int b = 10;
        do
        {
            Debug.Log("Die do-while-Zahl b ist " + b);
            
        }
        while (b < 5); // Bedingung nicht erfüllt, da b=10


        // foreach Schleife
        // Hier Abfrage des Arrays PrimZahlen
        foreach (int number in primZahl)
        {
            Debug.Log("Die Primzahl ist " + number); 
            // number enthält den Wert des Arrays
        }


        //Instanzen der Klasse Mensch erstellen 
        Mensch mensch1 = new Mensch(12, "Karl", "Schueler");
        Mensch mensch2 = new Mensch(18, "Sascha", "AzuBi");
        Mensch mensch3 = new Mensch(30, "Uwe", "Astronaut");

        //Aufruf der Methode innerhalb der Klasse Mensch 
        //für eine bestimmte Instanz der Klasse Mensch
        mensch1.ausgabeMensch();
        mensch2.ausgabeMensch();
        mensch3.ausgabeMensch();
    }

    // Update is called once per frame
    void Update()
    {
             
    }

   


    // Methode addition
    int addition(int zahl1, int zahl2)
    {
        int ergebnis = zahl1 + zahl2;
        return ergebnis;
    }

    

    //Klasse Mensch anlegen
    public class Mensch
    {
        int alter;
        string name;
        string beruf;

        public Mensch ( int dasAlter, string derName, string derBeruf)
        {
            alter = dasAlter;
            name = derName;
            beruf = derBeruf;
        }

        // Methode innerhalb der Klasse anlegen
        public void ausgabeMensch()
        {
            Debug.Log("Ich bin " + alter + " Jahre alt. Mein Name ist " + name +
                ". Mein Beruf ist " + beruf);

        }
    }
}
