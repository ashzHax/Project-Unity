using UnityEngine;
using UnityEngine.SceneManagement;

namespace ashz
{
    public class LevelComplete : MonoBehaviour
    {
        public void LoadNextLevel()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
