using UnityEngine;

public class Agent : MonoBehaviour
{
    public float fitness = 0f;

    void Update()
    {
        fitness += Time.deltaTime; // Чем дольше агент живёт, тем выше фитнес
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            fitness -= 5f; // Штраф за столкновение
            Destroy(gameObject);
        }
    }
}
