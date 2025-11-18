using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mage : Character
{
    public Mage(string nome, int vita) : base(nome, vita) { }

    public override void Attack(Character target)
    {
        target.TakeDamage(12);
        Debug.Log($"{nome} lancia una magia");
    }
}