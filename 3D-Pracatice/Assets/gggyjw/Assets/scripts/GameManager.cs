using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace gggyjw
{
    public class GameManager : MonoBehaviour
    {
        bool gameHasEnded = false;

        public float restartDelay = 1f;

        public GameObject completeLevelUI;

        public void completeLevel1()
        {
            completeLevelUI.SetActive(true);
        }
        
        public void CompleteLevel1()
        {
            completeLevelUI.SetActive(true);
        }
        public void EndGame()
        {
            if(gameHasEnded == false)
            {
                gameHasEnded = true;
                Debug.Log("Game Over");
                Invoke("Restart", restartDelay);
            }
        }

        void Restart ()
        {
             SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
        }
    }
}
