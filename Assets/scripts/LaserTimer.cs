using UnityEngine;

public class LaserTimer : MonoBehaviour
{
    [SerializeField] private float timerTurnOff;
    [SerializeField] private float timerTurnOn;
    [SerializeField] private float xPosition;
    [SerializeField] private float cooldownTimer;

    private void Update()
    {
        cooldownTimer += Time.deltaTime;

        if (cooldownTimer >= timerTurnOn)
        {
            transform.position = new Vector2(xPosition, 0f);
            cooldownTimer = 0;
        } else if (cooldownTimer >= timerTurnOff)
        {
            transform.position = new Vector2(50f, 0f);
        }
    }
}
