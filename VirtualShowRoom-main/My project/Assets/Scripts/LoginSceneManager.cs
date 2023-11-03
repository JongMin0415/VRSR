using UnityEngine;
using UnityEngine.SceneManagement;

public class LoginSceneManager : MonoBehaviour
{
    public void OnLoginButtonClick()
    {
        // 1번 씬으로 이동
        SceneManager.LoadScene(1); 
    }
}