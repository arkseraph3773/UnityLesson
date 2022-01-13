﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityLesson_CS_DiceGame
{
    internal class TileInfo_Star : TileInfo
    {
        public int starValue = 3; // 플레이어가 획득할수 있는 샛별 갯수 정보

        public override void TileEvent()
        {
            base.TileEvent();
            starValue++; //플레이어가 획득할수 있는 샛별 증가
        }
    }
}
