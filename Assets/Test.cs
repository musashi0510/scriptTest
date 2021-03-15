using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
	private int mp = 53;

	public void Magic()
	{
		if(mp >= 5)
		{
			mp = mp - 5;
			Debug.Log("魔法攻撃を攻撃した。残りMPは" + mp);
		}
		else
		{
			Debug.Log("MPが足りないため、魔法攻撃が使えない。");
		}
	}
}

public class Test : MonoBehaviour
{
	void Start()
	{
		Boss lastboss = new Boss();

		for(int i = 0;i < 10;i++)
		{
			lastboss.Magic();
		}

		//以下にLesson4の課題を示す。
		int[] array ={1,2,3,4,5};

		for (int a = 0;a < array.Length;a++)
		{
			Debug.Log(array [a]);
		}
		for (int b = array.Length-1;b >= 0;b--)
		{
			Debug.Log(array [b]);
		}
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}