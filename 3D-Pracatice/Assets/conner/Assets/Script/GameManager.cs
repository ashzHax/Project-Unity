using UnityEngine;
using UnityEngine.SceneManagement;

    public class GameManager : MonoBehaviour
    {

        bool gameEnded = false;
        public float restartDelay = 3f;

        public GameObject CompleteLevelUI;

        void Start()
        {
            CompleteLevelUI.SetActive(false);
        }

        public void CompleteLevel()
        {
            CompleteLevelUI.SetActive(true);
            Debug.Log("LEVEL COMPLETE");
        }

        public void GameOver()
        {
            if (gameEnded == false)
            {
                gameEnded = true;
                Debug.Log("Game Over");
                Invoke("Restart", restartDelay);
            }
        }

        void Restart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

