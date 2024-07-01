using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class VideoSwitcher : MonoBehaviour
{
    public VideoPlayer videoPlayer; // El VideoPlayer en el que se reproducen los videos
    public Button[] videoButtons;   // Los botones que se usan para cambiar videos
    public VideoClip[] videoClips;  // Los clips de video disponibles

    void Start()
    {
        // Asegúrate de que haya el mismo número de botones y clips de video
        if (videoButtons.Length != videoClips.Length)
        {
            Debug.LogError("El número de botones y clips de video no coincide");
            return;
        }

        // Asigna una función a cada botón para cambiar el video
        for (int i = 0; i < videoButtons.Length; i++)
        {
            int index = i; // Necesario para evitar problemas con la clausura en los lambdas
            videoButtons[i].onClick.AddListener(() => ChangeVideo(index));
        }
    }

    void ChangeVideo(int index)
    {
        videoPlayer.clip = videoClips[index];
        videoPlayer.Play();
    }
}
