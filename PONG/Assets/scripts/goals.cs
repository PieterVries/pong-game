using UnityEngine;

public class goals : MonoBehaviour
{
    public int playerscored;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D coldide)
    {
        if (!coldide.CompareTag("Pong") || GameManager.Instance == null)
        {
            return;
        }

        int scoringPlayer;
        if (transform.position.x < 0f)
        {
            scoringPlayer = 2;
        }
        else
        {
            scoringPlayer = 1;
        }
        GameManager.Instance.Goalmade(scoringPlayer);
    }
}
