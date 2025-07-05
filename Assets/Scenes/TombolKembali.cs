using UnityEngine;
using UnityEngine.SceneManagement;

public class TombolKembali : MonoBehaviour
{
    public void KembaliKeStartScene(string namaScene)
    {
        SceneManager.LoadScene(namaScene);
    }
}