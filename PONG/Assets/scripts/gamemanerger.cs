using UnityEngine;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private int scoreLeft = 0;
    private int scoreRight = 0;
    private Label scoreleft;
    private Label scoreright;
    public GameObject Pong;
    private Vector3 PongStart;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UIDocument uiDocument = FindFirstObjectByType<UIDocument>();
        if (uiDocument != null)
        {
            scoreleft = uiDocument.rootVisualElement?.Q<Label>("left");
            scoreright = uiDocument.rootVisualElement?.Q<Label>("right");
        }

        if (Pong != null)
        {
            PongStart = Pong.transform.position;
        }

        UpdateScore();
    }

    private void Awake()
    {
        Instance = this;
    }

    // Update is called once per frame
    void ResetPong()
    {
        Pong.transform.position = PongStart;
        Rigidbody2D rb = Pong.GetComponent<Rigidbody2D>();

        rb.AddForce(new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized * 10);
    }
    public void Goalmade(int player)
    {
        if (player == 1)
        {
            scoreLeft++;
        }
        else
        {
            scoreRight++;
        }
        UpdateScore();
        ResetPong();
    }

    private void UpdateScore()
    {
        if (scoreleft != null)
        {
            scoreleft.text = scoreLeft.ToString();
        }

        if (scoreright != null)
        {
            scoreright.text = scoreRight.ToString();
        }
    }
}

