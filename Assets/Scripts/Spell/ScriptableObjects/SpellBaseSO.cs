using System;
using UnityEngine;

public class SpellBaseSO : ScriptableObject
{
    [HideInInspector] public int id;
    public string spellName;
    public string description;
    public float range;
    public float power;
    public bool isUltime;

    public virtual void CastSpell(GameObject caster, GameObject target)
    {
        throw new NotImplementedException();
    }
}
