using UnityEngine;
using System.Collections;

public class print_HealthBar : MonoBehaviour {

    private float Health = 1f;    // 체력바
    private float diff = 0f;  // 받은 데미지와 밭은 힐의 합의 비율
    public float maxHealth = 1000f;    // 총 체력 
    public float takeDamage = 0f;  // 받은 데미지
    public float takeHealth = 0f;  // 받은 힐
    public bool die = true;

    // Update is called once per frame
    void Update()
    {
        

        if (takeDamage > 0 || takeHealth > 0)
        {
            diff += takeDamage / maxHealth;
            diff -= takeHealth / maxHealth;
            Health -= diff;

            if (Health > 1)       // 초과한 힐은 안받음
                Health = 1;
            else if (Health == 0)   // 뒤짐
            {
                while (true)
                {
                    this.GetComponent<UISlider>().value = 0f;
                    die = false;
                }
            }

            this.GetComponent<UISlider>().value = Health;   // Health를 표시


            // 초기화
            diff = 0;
            takeDamage = 0;
            takeHealth = 0;
        }
    }
}
