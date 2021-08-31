using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasicData
{
    class Program
    {
        enum CHAR_STATE
        {
            IDLE, //1
            WALK, //2
            RUN, //3
            JUMP, //4
            DIE, //5
        }
        enum CLICK_STATE
        {
            NONE, //0
            CLICK = 100, //100
            DOUBLE_CLICK = 200, //200
            UP, //201
        }
        static void Lecture3(string[] args)
        {
            CHAR_STATE charState = CHAR_STATE.IDLE;
            Console.WriteLine("state of character: {0} {1}", charState, (int)charState);
            CLICK_STATE clickState = CLICK_STATE.DOUBLE_CLICK;
            Console.WriteLine("state of click: {0} {1}", clickState, (int)clickState);

            bool? isFlag = true;

            if (isFlag.HasValue) Console.WriteLine("isFlag HasValue: {0}", isFlag.HasValue);

            var a = 100;

        }
    }
}