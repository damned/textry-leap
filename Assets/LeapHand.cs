
using UnityEngine;

using Leap;
public class LeapHand
{
  private readonly LeapHands hands;
  private readonly LiveDebug debug;

  public LeapHand(LeapHands hands, LiveDebug debug)
  {
    this.debug = debug;
    this.hands = hands;
  }

  public Vector3 Centre()
  {

    Vector stabilizedPalmPosition = GetHand().StabilizedPalmPosition;
    Vector3 grabPosition = hands.ToUnityWorldSpace(stabilizedPalmPosition);

    // debug.Log("grab pos (rel to hand controller): " + localGrabPosition);
    debug.Log("grab pos (world space): " + grabPosition);
    return grabPosition;
  }

  public double GrabStrength()
  {
    return GetHand().GrabStrength;
  }

  private Hand GetHand()
  {
    return hands.GetHand();
  }
}
