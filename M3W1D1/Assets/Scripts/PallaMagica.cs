using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PallaMagica : Proiettile
{
    public int maxRimbalzi;
    public int random;
    public override void Lancia()
    {
        random = Random.Range(0, maxRimbalzi + 1);
        Debug.Log("Palla Magica lanciata");
        Debug.Log("Palla Magica ha rimbalzato " + random + "volte");
        Debug.Log("Palla Magica è stata lanciata alla velocità : " + velocità);
        Debug.Log("Ed all'altezza di : " + gittata);
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
