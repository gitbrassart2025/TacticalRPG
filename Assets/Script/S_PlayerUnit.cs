using UnityEngine;
using System.Collections.Generic;
using System;
using System.Linq.Expressions;

public class PlayerUnit : MonoBehaviour
{
    public int maxActionPoints = 5;
    public int currentActionPoints;

    /*public Array<S_AttackData> attacks = New Array<S_AttackData>;*/
    public S_AttackData attackData;

    void Start()
    {
        currentActionPoints = maxActionPoints;
    }
    
    public void SpendActionPoints(int cost)
    {
        currentActionPoints -= cost;
        if (currentActionPoints < 0)
            currentActionPoints = 0;
    }
}