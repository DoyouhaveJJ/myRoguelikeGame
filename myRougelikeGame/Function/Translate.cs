using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myRougelikeGame.Function
{
    class Translate
    {
      /*  public string InjuredLevelToString(int a) {
            switch (a) {
                case 1: return "正常";
                case 2: return "";
            }
        }
        */




        public string SexToString(int a){
            switch (a) {
                case 1: return "男";
                case 2: return "女";
            }
            return "";
        }

        public string JobToString(int a) {
            switch (a) {
                case 1: return "无职业";
                case 2: return "程序员";
                case 3: return "会计";
                case 4: return "建筑工";
                case 5: return "厨师";
                case 6: return "警察";
                case 7: return "教师";
                case 8: return "科学家";
                case 9: return "语言学家";
                case 10: return "律师";
                case 11: return "军人";
                case 12: return "格斗家";
            }
            return "";
        }

        public string BloodTypeToString(int a) {
            switch (a) {
                case 1: return "A型";
                case 2: return "B型";
                case 3: return "O型";
                case 4: return "AB型";
                case 5: return "RH型";
            }
            return "";
        }

        public string GroupToString(int a) {
            switch (a) {
                case 1: return "人类";
                case 2: return "兽人";
                case 3: return "恶魔";
                case 4: return "精灵";
                case 5: return "不死族";
                case 6: return "龙人";
                case 7: return "未来人";
                case 8: return "灵魂";
            }
            return "";
        }

        public string ItemTypeToString(int a) {
            switch (a) {
                case 1: return "食物";
            }
            return "";
        }
    }
}
