using Ch06.Sub2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/13
 * 이름 : 안지훈
 * 내용 : 인터페이스 실습 교재 p425
 * 
 * 인터페이스(Interface)
 *  - 클래스간의 공통의 통일된 표준 규격을 통해 클래스 구조를 설계하는 문법
 *  - 인터페이스를 활용해서 다중 상속을 구현한다.
 *  - 인터페이스를 활용해서 객채간 결합도를 "완화"하는 효과를 얻는다.(다형성)
 */
namespace Ch06
{
    internal class _2_Interface
    {
        static void Main02(string[] args)
        {
            // 인터페이스로 공통 클래스 구조설계
            IRemoteControl lg      = new LGRemocon();
            IRemoteControl samsung = new SamsungRemocon();

            lg.PowerOn();
            lg.ChDown();
            lg.SoundUp();
            lg.PowerOff();

            samsung.PowerOn();
            samsung.ChDown();
            samsung.SoundUp();
            samsung.PowerOff();

            // 인터페이스를 활용한 다중 상속
            // 다형성을 적용할 수 없음. 참조타입이 2가지 이상이기 때문
            TV tv = new TV();
            tv.PowerOn();
            tv.Booting();
            tv.Access();

            // 인터페이스를 활용한 결합도 완화(다형성)
            Bulb bulb = new Bulb();
            ISocket socket = new Cable(bulb);

            socket.SwitchOn();
            socket.SwitchOff();
        }
    }
}
