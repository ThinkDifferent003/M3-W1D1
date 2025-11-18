using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lista : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        List<Proiettile> listP = new List<Proiettile>();
        listP.Add(new Freccia());
        listP.Add(new PallaMagica());

        foreach (Proiettile itemVar in listP)
        {
            itemVar.Lancia();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
