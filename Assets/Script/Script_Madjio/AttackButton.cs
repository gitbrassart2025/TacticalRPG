using UnityEngine;

public class AttackButton : MonoBehaviour
{
    public Systeme_de_joueur__Attaques__Point_action player;
    public int attackIndex;

    public void OnClick()
    {
        player.UseAttack(attackIndex);
    }
}