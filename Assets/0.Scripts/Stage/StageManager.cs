using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageManager : MonoBehaviour
{
    //각 스테이지의 정보를 담고 있는 스크립터블 오브젝트 리스트
    [SerializeField] private StageList stageList;
    //스테이지를 차례로 넣어 index로 해당 스테이지 정보를 불러옴
    [SerializeField] private int currentStageIndex;

    //테스트용 오브젝트 배치 위치(스크립터블 오브젝트에서 가져와서 만드는게 편할듯 싶음)
    [SerializeField] private Transform[] TestPositions;

    [SerializeField] private List<GameObject> spawnObjects = new List<GameObject>();

    public int CurrentStageIndex { get => currentStageIndex; set => currentStageIndex = value; }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if(stageList.List.Count > CurrentStageIndex)
                CurrentStageIndex++;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (CurrentStageIndex > 0)
                CurrentStageIndex--;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            //SetStage();
            Debug.Log("오브젝트 배치");
        }
    }

    public void SetStage()
    {
        //랜덤으로 인덱스를 뽑아 각 스테이지의 오브젝트를 배치
        // 생각한 문제점
        // 1. 각 오브젝트들의 리스트가 다르므로 다르게 랜덤한 인덱스를 뽑아서 처리하느냐
        // 2. 오브젝트의 리스트의 크기를 맞춰서 하나의 랜덤한 인덱스로 오브젝트를 처리하느냐

        // 1번은 각 오브젝트의 랜덤한 수를 뽑아서 처리하므로 리스트의 길이가 상관없음
        // 하지만 오브젝트마다 지역변수를 생성해서 처리해야하므로 코드가 복잡해짐
        // 장점은 배치가 다양해진다는 점

        // 2번은 각 오브젝트의 리스트의 길이를 맞춰 리스트의 크기가 같으므로 지역변수를
        // 하나만 사용하면 되므로 코드가 간결해지고 효율적이라고 생각함
        // 단점은 스테이지의 패턴이 단조로워질 수 있다는 점(리스트의 길이만큼 패턴만 나옴)

        if (spawnObjects.Count > 0)
        {
            for (int i = 0; i < spawnObjects.Count; i++)
            {
                Destroy(spawnObjects[i]);
            }
            spawnObjects.Clear();
            Debug.Log("이전 스테이지 오브젝트 삭제");
        }

        for (int i = 0; i < stageList.List[currentStageIndex].StageObejcts.Count; i++) 
        {
            GameObject obj = Instantiate(stageList.List[currentStageIndex].StageObejcts[i], TestPositions[i].position, Quaternion.identity);
            spawnObjects.Add(obj);
        }
    }

    public void NextStage()
    {
        currentStageIndex++;
    }
}
