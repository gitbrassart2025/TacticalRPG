using UnityEngine;
using System.Collections.Generic;

public class Systeme_de_joueur__Attaques__Point_action : MonoBehaviour
{
    public List<Classe_Attack> attacks = new List<Classe_Attack>();
    public int maxActionPoints = 5;
    private int currentActionPoints;

    public Système_de_sante target; // ennemi ciblé

    void Start()
    {
        currentActionPoints = maxActionPoints;
    }

    public void UseAttack(int attackIndex)
    {
        if (attackIndex < 0 || attackIndex >= attacks.Count)
            return;

        Classe_Attack selectedAttack = attacks[attackIndex];

        if (currentActionPoints >= selectedAttack.actionCost)
        {
            currentActionPoints -= selectedAttack.actionCost;

            Debug.Log("Utilise : " + selectedAttack.attackName);

            if (target != null)
            {
                target.TakeDamage(selectedAttack.damage);
            }
        }
        else
        {
            Debug.Log("Pas assez de points d'action !");
        }
    }

    public void ResetActionPoints()
    {
        currentActionPoints = maxActionPoints;
    }
}