using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;
    private AudioSource _audioSource;
    [SerializeField] BGM[] _bgms;
    [SerializeField] SE[] _ses;
    [SerializeField] string _firstPlayBGMName;
    [System.Serializable]
    public struct BGM
    {
        public string Name;
        public AudioClip Clip;
    }
    [System.Serializable]
    public struct SE
    {
        public string Name;
        public AudioClip Clip;
    }
    private void Start()
    {
        Instance = this;
        _audioSource = GetComponent<AudioSource>();
        PlayBGM(_firstPlayBGMName);
    }
    public void PlaySE(string SEName)
    {
        foreach (var SE in _ses)
        {
            if(SE.Name == SEName)
            {
                _audioSource.PlayOneShot(SE.Clip);
                return;
            }
        }
        Debug.LogWarning("�Đ�����SE��������܂���ł���");
    }
    public void PlayBGM(string BGMName)
    {
        foreach (var BGM in _bgms)
        {
            if (BGM.Name == BGMName)
            {
                _audioSource.clip = BGM.Clip;
                _audioSource.Play();
                return;
            }
        }
        Debug.LogWarning("�Đ�����BGM��������܂���ł���");
    }
}
