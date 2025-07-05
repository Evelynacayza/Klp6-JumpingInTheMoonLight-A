using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckpointAkhir : MonoBehaviour
{
    // Masukkan nama scene kemenangan yang akan kamu buat
    public string namaSceneMenang = "SceneMenang";

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Cek apakah yang menyentuh adalah objek dengan tag "Player"
        if (other.CompareTag("Player"))
        {
            // Ambil komponen skrip 'elara' dari player
            elara player = other.GetComponent<elara>();

            if (player != null)
            {
                // Panggil fungsi baru untuk menyelesaikan level
                player.SelesaikanLevel(namaSceneMenang);
            }
        }
    }
}