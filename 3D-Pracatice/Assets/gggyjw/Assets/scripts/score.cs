using UnityEngine;
using UnityEngine.UI;

namespace gggyjw
{
    public class score : MonoBehaviour
    {
        public Transform player;
        public Text scoreText;

        void Update()
        {
            scoreText.text  = player.position.z.ToString("0");  
        }
    }
}