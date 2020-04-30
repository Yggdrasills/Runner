using System.Collections;
using UnityEngine;

namespace BunnyHop.Controllers
{
    public class Spawner : MonoBehaviour
    {
        [SerializeField] private GameObject[] _prefab = null;
        [SerializeField] private float _minTimeSpawn = 0.8f;
        [SerializeField] private float _maxTimeSpawn = 2.5f;

        private void Start()
        {
            StartCoroutine(CreateObjectCoroutine());
        }

        private void CreateObject()
        {
            int random = Random.Range(0, _prefab.Length);

            Instantiate(_prefab[random], transform);
        }

        private IEnumerator CreateObjectCoroutine()
        {
            while(gameObject.activeInHierarchy)
            {
                CreateObject();

                var time = Random.Range(_minTimeSpawn, _maxTimeSpawn);
                yield return new WaitForSeconds(time);
            }
        }
    }
}