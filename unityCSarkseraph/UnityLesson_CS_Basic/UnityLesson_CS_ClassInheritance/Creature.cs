using System;
using System.Collections.Generic;
using System.Text;

namespace UnityLesson_CS_ClassInheritance
{
    class Creature
    {
        public string DNA;
        public int lifeTime;
        public float weight;
        // 함수 오버라이딩(override)
        // 함수를 재정의 하는 기능
        // virtual 키워드 : 해당 함수를 오버라이딩 가능하도록 해준다.
        // 부모 클래스 함수라고 해서 전부 virtual 붙이는게 아니라,
        // 자식 클래스가 해당 함수를 재정의 해야할때만 virtual을 붙여준다.

        // 크리쳐 클래스에서 사람클래스로 사람클래스에서 인종클래스로 상속해준다.
        virtual public void Breath() //선언
        {
            lifeTime++; //정의
        }

    }
}
