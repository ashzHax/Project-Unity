using UnityEngine;
using UnityEngine.SceneManagement;

namespace gggyjw
{
    public class Menu : MonoBehaviour
    {
        public void StartGame()
        {
            Debug.Log("dkabf");
            SceneManager.LoadScene( SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
