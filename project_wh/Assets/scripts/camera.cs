using UnityEngine;

public class camera : MonoBehaviour
{
    GameObject player;
    void Start()
    {
        player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -10);
    }
}
