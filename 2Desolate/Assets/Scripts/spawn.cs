using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spawn : MonoBehaviour
{
    public GameObject go;
    public GameObject player;
    List<GameObject> tl;
    GameObject tile;
    int sx;
    int sy;
    Transform pt;
    Transform tt;
    Color[] col;
    public static float score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        col = new Color[8];
        col[0] = Color.white;
        col[1] = Color.yellow;
        col[2] = Color.green;
        col[3] = Color.blue;
        col[4] = Color.red;
        col[5] = Color.magenta;
        col[6] = Color.cyan;
        col[7] = Color.grey;
        tt = go.GetComponent<Transform>();
        pt = player.GetComponent<Transform>();
        tl = new List<GameObject>();
        sx = 0;
        sy = 0;
        for(int i=0;i<3;i++)
            SpawnT(Random.Range(3, 11), Random.Range(10, 15), Random.Range(-4, 5), col[Random.Range(0,8)]);
    }
    void Update()
    {
        Debug.Log(tt.position.x);
        if(sx-pt.position.x<17.0f)
        {
            SpawnT(Random.Range(3, 11), Random.Range(10, 15), Random.Range(-4, 5), col[Random.Range(0, 8)]);
            Delete();
        }
        if (pt.position.y < sy - 12)
            SceneManager.LoadScene(2);
        if (pt.position.x > score)
            score = pt.position.x;
    }
    void SpawnT(int x,int spawnx,int spawny,Color col)
    {
        tile = Instantiate(go) as GameObject;
        tile.transform.SetParent(transform);
        sx += spawnx;
        sy += spawny;
        tile.GetComponent<SpriteRenderer>().color = col;
        tile.transform.position = new Vector3(sx, sy, 0);
        tile.transform.localScale = new Vector3(x, 1, 1);
        tl.Add(tile);
    }
    void Delete()
    {
        Destroy(tl[0]);
        tl.RemoveAt(0);
    }
}
