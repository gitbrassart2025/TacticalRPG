using UnityEngine;

public class Système_de_sante : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log(gameObject.name + " prend " + damage + " dégâts.");

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log(gameObject.name + " est mort !");
        Destroy(gameObject);
    }

    public int GetHealth()
    {
        return currentHealth;
    }
}