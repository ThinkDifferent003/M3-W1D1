using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : Character
{
    public Archer(string name , int vita)  : base(name , vita) { }

    public override void Attack(Character target)
    {
        for (int i = 1 ; i <= 2 ; i++)
        {
            target.TakeDamage(7);
            Debug.Log($"{nome} scaglia freccia {i}");

        }
    }
}
