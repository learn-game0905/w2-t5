using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Spin : MonoBehaviour
{
    [SerializeField] private int giftWheel = 9;

    [SerializeField] private AudioClip wheelRound;

    [SerializeField] private AudioSource audioSource;

    public int numberOfGift = 9;
    public float timeRotate;
    public float numRound;

    public TextMeshPro colorGift;

    private const float CIRCLE = 360.0f;
    private float angleOneGift;

    public Transform parrent;
    private float currentTime;

    public AnimationCurve curve;
    private bool isCoroutine;

    public void Start()
    {
        isCoroutine = true;
        angleOneGift = CIRCLE / numberOfGift;
        setData();
        // if (GameObject.Find("Wheel Round"))
        // {
        //     Destroy(GameObject.Find("Wheel Round").gameObject);
        // }
        // DontDestroyOnLoad(this.gameObject);
    }

    private IEnumerator RotateWheel()
    {
        audioSource.Stop();
        isCoroutine = false;
        float startAngel = transform.eulerAngles.z;
        currentTime = 0;

        //int indexGiftRandom = UnityEngine.Random.Range(1, numberOfGift);
        Debug.Log(giftWheel + " Tim và Vàng");

        float angleWant = (numRound * CIRCLE) + angleOneGift * giftWheel - startAngel;

        while (currentTime < timeRotate)
        {
            yield return new WaitForEndOfFrame();
            currentTime += Time.deltaTime;

            float angleCurrent = angleWant * curve.Evaluate(currentTime / timeRotate);
            this.transform.eulerAngles = new Vector3(0, 0, angleCurrent + startAngel);
        }

        isCoroutine = true;

        switch (giftWheel)
        {
            case 1:
                colorGift = GameObject.Find("/Wheel Round/List Data/Gilf/Text (TMP)").GetComponent<TextMeshPro>();
                colorGift.color = new Color(255, 0, 0, 255);

                SceneManager.LoadSceneAsync("Level_1");
                break;
            case 2:
                colorGift = GameObject.Find("/Wheel Round/List Data/Gilf1/Text (TMP)").GetComponent<TextMeshPro>();
                colorGift.color = new Color(255, 0, 0, 255);
                
                SceneManager.LoadSceneAsync("Level_2");
                break;
            case 3:
                colorGift = GameObject.Find("/Wheel Round/List Data/Gilf2/Text (TMP)").GetComponent<TextMeshPro>();
                colorGift.color = new Color(255, 0, 0, 255);
                
                SceneManager.LoadSceneAsync("Level_3");
                break;
            case 4:
                colorGift = GameObject.Find("/Wheel Round/List Data/Gilf3/Text (TMP)").GetComponent<TextMeshPro>();
                colorGift.color = new Color(255, 0, 0, 255);
                
                SceneManager.LoadSceneAsync("Level_4");
                break;
            case 5:
                colorGift = GameObject.Find("/Wheel Round/List Data/Gilf4/Text (TMP)").GetComponent<TextMeshPro>();
                colorGift.color = new Color(255, 0, 0, 255);
                
                SceneManager.LoadSceneAsync("Level_5");
                break;
            case 6:
                colorGift = GameObject.Find("/Wheel Round/List Data/Gilf5/Text (TMP)").GetComponent<TextMeshPro>();
                colorGift.color = new Color(255, 0, 0, 255);
                
                SceneManager.LoadSceneAsync("Level_6");
                break;
            case 7:
                colorGift = GameObject.Find("/Wheel Round/List Data/Gilf6/Text (TMP)").GetComponent<TextMeshPro>();
                colorGift.color = new Color(255, 0, 0, 255);
                
                SceneManager.LoadSceneAsync("Level_7");
                break;
            case 8:
                colorGift = GameObject.Find("/Wheel Round/List Data/Gilf7/Text (TMP)").GetComponent<TextMeshPro>();
                colorGift.color = new Color(255, 0, 0, 255);
                
                SceneManager.LoadSceneAsync("Level_8");
                break;
            case 9:
                colorGift = GameObject.Find("/Wheel Round/List Data/Gilf8/Text (TMP)").GetComponent<TextMeshPro>();
                colorGift.color = new Color(255, 0, 0, 255);
                
                SceneManager.LoadSceneAsync("Level_9");
                break;
            case 10:
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                break;
        }
    }

    private void Update()
    {
        if (Input.GetMouseButton(0) && isCoroutine)
        {
            RotateNow();
            audioSource.PlayOneShot(wheelRound);
            
        }

        if (Input.GetKeyDown(KeyCode.R) && isCoroutine)
        {
            for (int i = 0; i < parrent.childCount; i++)
            {
                parrent.GetChild(i).GetChild(0).GetComponent<TextMeshPro>().color = new Color(255, 255, 255, 255);
            }
        }

        if (Input.GetKeyDown(KeyCode.Keypad1) && isCoroutine)
        {
            giftWheel = 1;
            RotateNow();
            audioSource.PlayOneShot(wheelRound);
        }

        if (Input.GetKeyDown(KeyCode.Keypad2) && isCoroutine)
        {
            giftWheel = 2;
            RotateNow();
            audioSource.PlayOneShot(wheelRound);
        }

        if (Input.GetKeyDown(KeyCode.Keypad3) && isCoroutine)
        {
            giftWheel = 3;
            RotateNow();
            audioSource.PlayOneShot(wheelRound);
        }

        if (Input.GetKeyDown(KeyCode.Keypad4) && isCoroutine)
        {
            giftWheel = 4;
            RotateNow();
            audioSource.PlayOneShot(wheelRound);
        }

        if (Input.GetKeyDown(KeyCode.Keypad5) && isCoroutine)
        {
            giftWheel = 5;
            RotateNow();
            audioSource.PlayOneShot(wheelRound);
        }

        if (Input.GetKeyDown(KeyCode.Keypad6) && isCoroutine)
        {
            giftWheel = 6;
            RotateNow();
            audioSource.PlayOneShot(wheelRound);
        }

        if (Input.GetKeyDown(KeyCode.Keypad7) && isCoroutine)
        {
            giftWheel = 7;
            RotateNow();
            audioSource.PlayOneShot(wheelRound);
        }

        if (Input.GetKeyDown(KeyCode.Keypad8) && isCoroutine)
        {
            giftWheel = 8;
            RotateNow();
            audioSource.PlayOneShot(wheelRound);
        }

        if (Input.GetKeyDown(KeyCode.Keypad9) && isCoroutine)
        {
            giftWheel = 9;
            RotateNow();
            audioSource.PlayOneShot(wheelRound);
        }
    }

    void RotateNow()
    {
        StartCoroutine(RotateWheel());
    }

    void setData()
    {
        for (int i = 0; i < parrent.childCount; i++)
        {
            parrent.GetChild(i).eulerAngles = new Vector3(0, 0, -CIRCLE / numberOfGift * i);
            parrent.GetChild(i).GetChild(0).GetComponent<TextMeshPro>().text = (i + 1).ToString();
        }
    }
}