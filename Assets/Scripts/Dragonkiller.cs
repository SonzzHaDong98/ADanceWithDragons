
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dragonkiller : MonoBehaviour
{
    GameManager gm;

    private void Start()
    {
        gm = FindObjectOfType<GameManager>();

    }
    // Update is called once per frame
    private void Update()
    {
        if (transform.position.y > 7 || transform.position.y < -7)
        {
            gm.SetGameOverState(true);
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gm.SetGameOverState(true);
        Destroy(gameObject);
    }
}
