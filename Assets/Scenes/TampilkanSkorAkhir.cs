using UnityEngine;
using TMPro; // Jangan lupa tambahkan ini jika menggunakan TextMeshPro

public class TampilkanSkorAkhir : MonoBehaviour
{
    [Header("UI Elemen")]
    public TextMeshProUGUI teksSkorAkhir;
    public TextMeshProUGUI teksNyawaSisa;

    void Start()
    {
        // Ambil data skor dari PlayerPrefs, jika tidak ada, defaultnya 0
        int skor = PlayerPrefs.GetInt("SkorAkhir", 0);
        
        // Ambil data nyawa dari PlayerPrefs, jika tidak ada, defaultnya 0
        int nyawa = PlayerPrefs.GetInt("NyawaSisa", 0);

        // Tampilkan ke UI Text
        if (teksSkorAkhir != null)
        {
            teksSkorAkhir.text = "Poinmu: " + skor;
        }

        if (teksNyawaSisa != null)
        {
            teksNyawaSisa.text = "Sisa Nyawa: " + nyawa;
        }
    }
}