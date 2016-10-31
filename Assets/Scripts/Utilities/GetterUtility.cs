using UnityEngine;

public class GetterUtility {

    public static Player GetPlayer() {
        return GameObject.Find("Player").GetComponent<Player>();
    }

    public static GameManager GetGameManager() {
        return GameObject.Find("GameManager").GetComponent<GameManager>();
    }

}
