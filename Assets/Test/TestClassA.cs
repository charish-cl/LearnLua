using UnityEngine;
using XLua;

namespace Script
{
    [LuaCallCSharp]
    public class TestClassA
    {
      //   public static void TestMethod()
	     // {
      //       Debug.Log("invoke TestClassA TestMethod");
      //   }

        public int a = 1;
        
        public static int b =2;
        
        public void TestFunc(string i)
        {
            Debug.Log("TestFunc(string i)");
        }
    }
}