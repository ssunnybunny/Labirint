using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class KillPlayer : MonoBehaviour
{
    public Transform killarea;
    [SerializeField] public int numberofdeaths;
    [SerializeField] public float playerSpawny;
    [SerializeField] public float playerSpawnx;

    public void Start()
    {
        playerSpawnx = -14f;
        playerSpawny = -8;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.transform.position = new Vector2(playerSpawnx, playerSpawny);
            numberofdeaths++;
        }
    }
}
