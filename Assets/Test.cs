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
int num = mp - 5;
Debug.Log("魔法攻撃を攻撃した。残りMPは" + num);
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
lastboss.Magic();
for(int i = 0;i < 10;i++)
{
Debug.Log("MPが足りないため、魔法攻撃が使えない。");
}
}

    // Update is called once per frame
    void Update()
    {
        
    }
}