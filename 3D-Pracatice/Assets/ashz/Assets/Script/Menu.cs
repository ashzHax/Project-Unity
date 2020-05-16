using UnityEngine;
using UnityEngine.SceneManagement;

namespace ashz
{
    public class Menu : MonoBehaviour
    {
        public void StartGame()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
