using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    public string characterName;

    public int maxHP = 100;
    public int currentHP;

    public int maxActionPoints = 5;
    public int currentActionPoints;

    public List<ListeAttaque> attacks = new List<ListeAttaque>();

    private void Start()
    {
        currentHP = maxHP;
        currentActionPoints = maxActionPoints;
    }

    public void TakeDamage(int damage)
    {
        currentHP -= damage;
        if (currentHP <= 0)
        {
            currentHP = 0;
            Debug.Log(characterName + " est mort !");
        }
    }

    public bool CanUseAttack(ListeAttaque attack)
    {
        return currentActionPoints >= attack.actionCost;
    }

    public void UseAttack(int attackIndex, CharacterStats target)
    {
        if (attackIndex < 0 || attackIndex >= attacks.Count)
            return;

        ListeAttaque selectedAttack = attacks[attackIndex];

        if (!CanUseAttack(selectedAttack))
        {
            Debug.Log("Pas assez de points d'action !");
            return;
        }

        currentActionPoints -= selectedAttack.actionCost;
        selectedAttack.Execute(this, target);
    }

    public void ResetActionPoints()
    {
        currentActionPoints = maxActionPoints;
    }
}