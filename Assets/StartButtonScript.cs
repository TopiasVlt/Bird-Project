using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtonScript : MonoBehaviour
{
    
        public void OnStartClick()
        {
            SceneManager.LoadScene("GameplayScene");
            AudioManager.Instance.PlaySFX("MenuClick");

        }

        public void OnExitClick()
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#endif
            Application.Quit();

            AudioManager.Instance.PlaySFX("MenuClick");
        }
    
}
