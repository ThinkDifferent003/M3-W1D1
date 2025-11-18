using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class Character 
{
    public string _nome;
    public int _vita;

    public Character(string nome , int vita)
    {
        _nome = nome;
        _vita = vita;
    }
        
    public string nome
    {
        get {  return _nome; }
        set {  _nome = value; }

    }
    public int vita
    {
        get { return _vita; }
        set
        {
            if (_vita < 0)
            {
                _vita = 0;
            }
            
        }
    }

    public virtual void Attack(Character target)
    {
        target.TakeDamage(1);
        Debug.Log("Ha " + _vita );
    }
    public void TakeDamage(int  damage)
    {
        _vita = _vita - damage;
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
