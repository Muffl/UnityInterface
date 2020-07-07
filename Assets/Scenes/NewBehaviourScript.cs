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
