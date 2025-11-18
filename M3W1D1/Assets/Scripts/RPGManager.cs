using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RPGManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       List <Character> list = new List <Character>();
        {
            new Warrior("Micio", 9);
            new Mage("Cane", 5);
            new Archer("Topo", 3);
        }
        int random = Random.Range(1, 21);
        foreach (Character c in list)
        {
            Debug.Log($"{c.nome} attacca , vita : {c.vita}");
            c.Attack(c);
            c.TakeDamage(random);
            Debug.Log($"{c.nome} ha {c.vita}");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
