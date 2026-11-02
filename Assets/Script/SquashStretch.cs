using UnityEngine;
using System.Collections;

public class SquashStretch : MonoBehaviour
{
    public void PopText()
    {
        StopAllCoroutines();
        StartCoroutine(PopAnim());
    }

    IEnumerator PopAnim()
    {
        Vector3 originalScale = Vector3.one;
        Vector3 originalRot = Vector3.zero;

        float duration = 0.4f;
        float elapsed = 0f;

        while(elapsed < duration)
        {
            elapsed += Time.deltaTime;

            float percent = elapsed/duration;
            Debug.Log(elapsed);

            float bounce = Mathf.Sin(percent * Mathf.PI * 4) * (1 - percent);

            transform.localScale = originalScale + new Vector3(bounce * 0.3f, bounce * 0.3f, 0);
            transform.localRotation = Quaternion.Euler(0, 0, bounce * 10f);

            yield return null;
        }

        transform.localScale = originalScale;
        transform.localRotation = Quaternion.Euler(originalRot);
    }
}
