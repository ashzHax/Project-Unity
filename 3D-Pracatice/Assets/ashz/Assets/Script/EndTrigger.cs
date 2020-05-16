using UnityEngine;

namespace ashz {

    public class EndTrigger : MonoBehaviour
    {
        public GameManager gameManager;

        void OnTriggerEnter()
        {
            gameManager.CompleteLevel();
        }
    }
}
