using UnityEngine;

public class TrainingDummyHealth2 : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    void OnCollisionEnter(Collision collision)
    {
        // 여기서 태그나 다른 방식으로 공격을 구분
        if (collision.gameObject.CompareTag("Projectile"))
        {
            Debug.Log("Hit detected!");
            TakeDamage(10); // 피격 시 10의 데미지 예시

        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        // 오브젝트가 사라지거나 상태 변화
        Destroy(gameObject);
    }
}