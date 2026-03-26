using UnityEngine;
using UnityEngine.UI;
public class Bar_de_vie : MonoBehaviour

{
    public int maxHealth = 100;
    private int currentHealth;

    public Slider healthBar; // barre de vie

    void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthBar();
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);

        Debug.Log(gameObject.name + " prend " + damage + " dégâts");

        UpdateHealthBar();

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void UpdateHealthBar()
    {
        if (healthBar != null)
        {
            healthBar.maxValue = maxHealth;
            healthBar.value = currentHealth;
        }
    }

    void Die()
    {
        Debug.Log(gameObject.name + " est mort");
        Destroy(gameObject);
    }
}