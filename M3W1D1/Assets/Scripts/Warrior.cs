using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class Warrior : Character
{
    public Warrior(string nome, int vita) : base(nome, vita) { }
   

    public override void Attack( Character target)
    {
        target.TakeDamage(10);
        Debug.Log($"{nome} ha attaccato con la spada");
    }
}
