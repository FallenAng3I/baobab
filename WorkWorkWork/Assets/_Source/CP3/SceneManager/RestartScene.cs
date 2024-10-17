using UnityEngine;

namespace CP3.SceneManager
{
    public class RestartScene : MonoBehaviour
    {
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                Debug.Log("Scene was reload!");
                UnityEngine.SceneManagement.SceneManager.LoadScene("Singleton");
            }
        }
    }
}
