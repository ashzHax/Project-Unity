using UnityEngine;
using UnityEngine.SceneManagement;

namespace ashz
{
    public class GameManager : MonoBehaviour
    {
        private bool gameOver = false;
        public float restartDelay = 1f;

        public GameObject completeLevelUI;

        public void EndGame()
        {
            if (!gameOver)
            {
                Debug.Log("Game Over");
                gameOver = true;
                Invoke("Restart"/*function name*/, restartDelay/*wait time*/);
            }
        }

        public void Restart()
        {
            //SceneManager.LoadScene("GameLevel1");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        public void CompleteLevel()
        {
            completeLevelUI.SetActive(true);
            //Debug.Log("Level 1 Complete");
        }

    }
}
