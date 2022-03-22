using UnityEngine;
using UnityEngine.SceneManagement;

public class FinDeNiveau : MonoBehaviour
{
    public int scene;

    public start()
    {
        scene = SceneManager.GetActiveScene().buildIndex + 1;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Félicitation, le niveau est terminé.");
            GameManager.Instance.SaveData();
            SceneManager.LoadScene(scene);

            if(SceneManager.GetActiveScene().buildIndex == 3)
            {
                SceneManager.LoadScene("MainMenu");
            } else
            {
                Debug.Log("Félicitation, le niveau est terminé.");
                GameManager.Instance.SaveData();
                SceneManager.LoadScene(scene);
                if (scene > PlayerPrefs.GetInt("niveauActuelle"))
                {
                    PlayerPrefs.SetInt("niveauActuelle", scene);
                }
            }
        }
    }
}
