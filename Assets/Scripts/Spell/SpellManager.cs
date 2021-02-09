using System.Collections.Generic;
using UnityEngine;

public class SpellManager : MonoBehaviour
{
    #region Serialized fields
    [SerializeField] InputReader _inputReader;
    [SerializeField] CastSpellChannelSO castSpellEvent;
    [SerializeField] private List<SpellBaseSO> spells;
    #endregion

    #region Private attributes
    private List<SpellBaseSO> _selectedSpells = new List<SpellBaseSO>();
    #endregion

    #region Public attributes
    public static SpellManager instance
    {
        get;
        private set;
    }
    #endregion

    #region Monobehaviour callbacks
    private void OnEnable()
    {
        if (castSpellEvent)
        {
            castSpellEvent.OnCastSpell += OnCastSpell;
        }
    }

    private void OnDisable()
    {
        if (castSpellEvent)
        {
            castSpellEvent.OnCastSpell -= OnCastSpell;
        }
    }

    private void Awake()
    {
        if (!instance)
        {
            instance = this;
        }
        InitSpellIds();
        InitSelectedSpells(5); // Only fortesting. Remove for production since the selected spells will be filled in Menu
    }
    #endregion

    #region Private Methods
    private void OnCastSpell(GUnit caster, GUnit target, int buttonNumber)
    {
        if (buttonNumber < 1 || buttonNumber > _selectedSpells.Count)
        {
            Debug.LogError("Cannot access to spell number: " + buttonNumber);
            return;
        }
        _selectedSpells[buttonNumber - 1].CastSpell(caster, target);
    }

    private void InitSpellIds()
    {
        for(int i = 0; i < spells.Count; ++i)
        {
            spells[i].id = i;
        }
    }

    private void InitSelectedSpells(int n)
    {
        for (int i = 0; i < spells.Count && i < n; ++i)
        {
            _selectedSpells.Add(spells[i]);
        }
    }
    #endregion
}
