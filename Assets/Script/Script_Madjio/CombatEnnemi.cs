using UnityEngine;
using System.Collections.Generic;

public class CombatEnnemi : MonoBehaviour
{
    public List<Classe_Attack> attacks = new List<Classe_Attack>();

    public int maxActionPoints = 5;
    private int currentActionPoints;

    public Système_de_sante playerTarget;

    void Start()
    {
        currentActionPoints = maxActionPoints;
    }

    public void EnemyTurn()
    {
        currentActionPoints = maxActionPoints;

        Debug.Log("Tour de l'ennemi");

        while (currentActionPoints > 0)
        {
            Classe_Attack attack = ChooseAttack();

            if (attack == null)
                break;

            ExecuteAttack(attack);
        }
    }

    Classe_Attack ChooseAttack()
    {
        foreach (Classe_Attack atk in attacks)
        {
            if (atk.actionCost <= currentActionPoints)
                return atk;
        }

        return null;
    }

    void ExecuteAttack(Classe_Attack attack)
    {
        currentActionPoints -= attack.actionCost;

        Debug.Log("L'ennemi utilise : " + attack.attackName);

        if (playerTarget != null)
        {
            playerTarget.TakeDamage(attack.damage);
        }
    }
}