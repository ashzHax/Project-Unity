﻿using UnityEngine;
using UnityEngine.UI;

namespace ashz {
    public class Score : MonoBehaviour
    {
        public Transform player;
        public Text scoreText;

        void Update()
        {
            //Debug.Log(player.position.z);
            scoreText.text = player.position.z.ToString("0");
        }
    }
}
