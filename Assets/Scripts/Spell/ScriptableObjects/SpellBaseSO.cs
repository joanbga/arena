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

    public virtual void CastSpell(GUnit caster, GUnit target)
    {
        string casterName = string.Empty;
        string targetName = string.Empty;

        if (caster)
        {
            casterName = caster.name;
        }
        if (target)
        {
            targetName = target.name;
        }
        Debug.Log("Casting spell from" + casterName + " to: " + targetName);
    }
}
