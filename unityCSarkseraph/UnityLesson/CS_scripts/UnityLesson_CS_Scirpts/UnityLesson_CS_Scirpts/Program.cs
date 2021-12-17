using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityLesson_CS_Scirpts
{ 
    class 검사
    {
        int HP = 100;
        int ATK = 80;

        
        public void HACK1(object monster)//몬스터라는 오브젝트를 불러와서 ATK수치로 때리겠다
        {
            monster.HP = monster.HP - ATK;
        }
        public void HACK2(object monster)//몬스터라는 오브젝트를 불러와서 ATK수치로 때리겠다
        {
            monster.HP = monster.HP - ATK * 1.5; ;
        }
    }
    
   class 캐릭터생성
    {
        public void 검사생성()
        {
            검사 검사1 = new 검사(); //캐릭터 생성에 대한 클래스
        }
    }
    
    /*{
        float HP = 100.00f; //우리가 표현하고 싶은 것으로 정수형으로 사용 할시 int 실수형은 float
    float MP = 50.00f;
    ATK 80
        EXP 0
        베기
        내려찍기
    }*/
}

