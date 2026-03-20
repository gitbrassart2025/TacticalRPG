using System.Collections.Generic;
using UnityEngine;

public class GérerTour : MonoBehaviour
{
    public List<CharacterStats> turnOrder = new List<CharacterStats>();

    private int currentTurnIndex = 0;

    private void Start()
    {
        StartTurn();
    }

    public CharacterStats CurrentCharacter()
    {
        return turnOrder[currentTurnIndex];
    }

    public void EndTurn()
    {
        currentTurnIndex++;

        if (currentTurnIndex >= turnOrder.Count)
            currentTurnIndex = 0;

        StartTurn();
    }

    void StartTurn()
    {
        CharacterStats character = CurrentCharacter();
        character.ResetActionPoints();
        Debug.Log("Tour de : " + character.characterName);
    }
}