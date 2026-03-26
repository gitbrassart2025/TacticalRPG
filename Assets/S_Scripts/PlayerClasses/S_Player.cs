using Unity.Collections;
using UnityEngine;

public class S_Player : MonoBehaviour
{
    public int health = 300;
    public int actionPoint = 100;
    public int damage = 175;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void TakeDamage(int dmg)
    {
        health = health - dmg;
    }

    public virtual void Move(int costPA)
    {
        if (actionPoint > costPA)
        {
            // le déplacement
            actionPoint = actionPoint - costPA;
        }
    }
}
