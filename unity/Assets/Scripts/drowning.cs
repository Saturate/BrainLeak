using UnityEngine;
using System.Collections;
using System.Diagnostics;

public class drowning : MonoBehaviour {

  public float MaxWaterLevel;
  public float SecondUntilDrowning;

  private bool isCountingDown;
  private Stopwatch stopWatch;
		
  void Start() {
    isCountingDown = false;
  }
	// Update is called once per frame
	void Update () {
    UnityEngine.Debug.Log(transform.position.y);
    if (transform.position.y < MaxWaterLevel)
      return;

    if (!isCountingDown) {
      stopWatch = Stopwatch.StartNew();
      isCountingDown = true;
    } else if (stopWatch.ElapsedMilliseconds > SecondUntilDrowning * 1000)
      Application.LoadLevel("EndGame");

    if(stopWatch != null)
      UnityEngine.Debug.Log(stopWatch.ElapsedMilliseconds - SecondUntilDrowning * 1000);
  }
}
