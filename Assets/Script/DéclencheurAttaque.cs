/*using UnityEngine;

public class DéclencheurAttaque : MonoBehaviour
{
    public GérerTour turnManager;
    public CharacterStats target;
    public int attackIndex;

    public void OnAttackButtonPressed()
    {
        CharacterStats current = turnManager.CurrentCharacter();

        current.UseAttack(attackIndex, target);

        if (current.currentActionPoints <= 0)
        {
            turnManager.EndTurn();
        }
    }
}*/