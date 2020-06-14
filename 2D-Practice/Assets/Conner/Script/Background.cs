using UnityEngine;

namespace conner
{
    public class Background : MonoBehaviour
    {

        public Camera main_camera;
        public GameObject background;


        // Update is called once per frame
        void Update()
        {
            Vector3 camera_loc = main_camera.transform.position;
            background.transform.position = new Vector3(camera_loc.x, camera_loc.y, 0);
        }
    }
}
