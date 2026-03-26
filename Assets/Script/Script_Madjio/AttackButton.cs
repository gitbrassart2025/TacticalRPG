using UnityEngine;

public class AttackButton : MonoBehaviour
{
    public PA player;
    public int attackIndex;

    public void OnClick()
    {
        player.UseAttack(attackIndex);
    }
}