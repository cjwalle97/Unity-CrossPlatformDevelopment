using UnityEngine.Events;

[System.Serializable]
public class PlayerHealthChange : UnityEvent {

}

[System.Serializable]
public class PlayerHealthChangeWithInt : UnityEvent<int> { }
[System.Serializable]
public class PlayerChange : UnityEvent<TestPlayerBehaviour.PlayerInfo> { }