using System;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class nameTag : MonoBehaviour
{
    public Transform player;
    public TMP_Text tmp;
    public CanvasGroup canvasGroup;
    public float showDistance = 3f;
    public float fadeSpeed = 2f;

    private bool isVisible = false;

    void Start()
    {
        npc npc = GetComponent<npc>();
        tmp.text = npc.name;
    }

    void Update()
    {
        float distanse = Vector2.Distance(player.position, transform.position);
        bool shouldVisible = distanse < showDistance;

        if (shouldVisible != isVisible)
        {
            isVisible = shouldVisible;
        }

        float Alpha = isVisible ? 1 : 0;
        canvasGroup.alpha = Mathf.MoveTowards(canvasGroup.alpha, Alpha, fadeSpeed * Time.deltaTime);
    }
}
