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
}
