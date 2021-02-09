using UnityEngine;

[CreateAssetMenu(menuName = "Spells/Teleport")]
public class TeleportSpellSO : SpellBaseSO
{
    public override void CastSpell(GUnit caster, GUnit target)
    {
        Vector3 pos = new Vector3(caster.transform.position.x, caster.transform.position.y, caster.transform.position.z);
        pos.x += 2;
        pos.z += 2;
        caster.GetComponent<CharacterController>().Move(caster.transform.TransformDirection(new Vector3(0f, 0f, range)));
        base.CastSpell(caster, target);
    }
}
