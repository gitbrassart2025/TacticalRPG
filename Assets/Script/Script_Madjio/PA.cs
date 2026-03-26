using System.Collections.Generic;
using TMPro; // important
using UnityEngine;

public class PA : MonoBehaviour
{
    
    public List<Classe_Attack> attacks = new List<Classe_Attack>();

    public int maxActionPoints = 10
        ;
    private int currentActionPoints;

    public Système_de_sante target;

    public TextMeshProUGUI actionPointsText; // UI

    void Start()
    {
        currentActionPoints = maxActionPoints;
        UpdateUI();
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

            UpdateUI(); // mise à jour après attaque
        }
        else
        {
            Debug.Log("Pas assez de PA !");
        }
    }

    public void ResetActionPoints()
    {
        currentActionPoints = maxActionPoints;
        UpdateUI(); // mise à jour
    }

    void UpdateUI()
    {
        if (actionPointsText != null)
        {
            actionPointsText.text = "PA : " + currentActionPoints + " / " + maxActionPoints;
            Debug.Log("PA mis à jour : " + currentActionPoints + " / " + maxActionPoints);
        }
    }
}