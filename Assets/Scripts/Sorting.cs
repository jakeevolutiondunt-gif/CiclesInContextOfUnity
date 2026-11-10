using UnityEngine;

public class Sorting : MonoBehaviour
{
    public GameObject[] cubes = new GameObject[5];
    public float spacing = 2f;

    public Vector3 startPosition = Vector3.zero;

    public GameObject[] BubbleSort()
    {
        for (int i = 0; i < cubes.Length - 1; i++)
        {
            for (int j = 0; j < cubes.Length - i - 1; j++)
            {
                if (cubes[j].transform.localScale.magnitude < cubes[j + 1].transform.localScale.magnitude)
                {
                    var temp = cubes[j];
                    cubes[j] = cubes[j + 1];
                    cubes[j + 1] = temp;
                }
            }
        }
        return cubes;
    }

    public void Sorted()
    {
        Sort(BubbleSort());
    }

    public void Sort(GameObject[] cubes)
    {
        for (int i = 0; i < cubes.Length; i++)
        {
            float newX = startPosition.x + (i * spacing);
            cubes[i].transform.position = new Vector3(newX, startPosition.y, startPosition.z);
        }
    }
}
