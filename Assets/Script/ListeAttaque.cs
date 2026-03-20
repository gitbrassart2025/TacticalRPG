using UnityEngine;

[System.Serializable]
public class ListeAttaque
{
    public string attackName;
    public int actionCost;
    public int damage;

    public void Execute(CharacterStats attacker, CharacterStats target)
    {
        target.TakeDamage(damage);
        Debug.Log(attacker.characterName + " utilise " + attackName +
                  " et inflige " + damage + " dégâts à " + target.characterName);
    }
}