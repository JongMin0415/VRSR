using UnityEngine;
using UnityEngine.SceneManagement;

public class LoginSceneManager : MonoBehaviour
{
    public void OnLoginButtonClick()
    {
        // 1�� ������ �̵�
        SceneManager.LoadScene(1); 
    }
}