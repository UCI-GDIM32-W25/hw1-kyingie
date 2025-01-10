using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 3.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft;
    private int _numSeedsPlanted;

    private void Start ()
    {
        _numSeedsLeft = _numSeeds;
        _numSeedsPlanted = 0;
        _playerTransform.position = Vector3.zero;
    }

    private void Update()
    {
        // Moving Up with Key W
        if (Input.GetKey(KeyCode.W))
        {
            _playerTransform.Translate(Vector3.up * _speed * Time.deltaTime);
        }
        // Moving Left with Key A
        if (Input.GetKey(KeyCode.A))
        {
            _playerTransform.Translate(Vector3.left * _speed * Time.deltaTime);
        }
        // Moving Down with Key S
        if (Input.GetKey(KeyCode.S))
        {
            _playerTransform.Translate(Vector3.down * _speed * Time.deltaTime);
        }
        // Moving Right with Key D
        if (Input.GetKey(KeyCode.D))
        {
            _playerTransform.Translate(Vector3.right * _speed * Time.deltaTime);
        }
      
        // Update Plant Count UI
        _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);

        // Press space to plant seed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (_numSeedsPlanted < 5)
            {
                PlantSeed();
                _numSeedsLeft -= 1;
                _numSeedsPlanted += 1;
            }
        }
    }

    public void PlantSeed ()
    {
        GameObject plantPrefab = Instantiate(_plantPrefab) as GameObject;
        plantPrefab.transform.position = new Vector3(_playerTransform.position.x, _playerTransform.position.y, _playerTransform.position.z);
    }
}
