using UnityEngine;

namespace gggyjw
{
    public class EndTrigger : MonoBehaviour
    {
        public GameManager gameManager;

        void OnTriggerEnter()
        {
            gameManager.CompleteLevel();
        }
    }
}   