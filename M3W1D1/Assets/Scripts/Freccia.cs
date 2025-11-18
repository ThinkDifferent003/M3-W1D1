using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freccia : Proiettile
{
    public int numeroFrecceSimultanee;

    public override void Lancia()
    {
        Debug.Log("Feccia scoccata");
        Debug.Log("Numero di frecce : " +  numeroFrecceSimultanee);
        Debug.Log("Velocità : " + velocità);
        Debug.Log("Gittata : " + gittata);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
