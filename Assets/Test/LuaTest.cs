using System;
using Sirenix.OdinInspector;
using UnityEngine;
using XLua;

namespace Script
{
     [ExecuteAlways]
    public class LuaTest:MonoBehaviour
    {
        LuaEnv luaenv= null;

        private void OnEnable()
        {
            // luaenv??= new LuaEnv();
        }

        [Button("Lua DoString")]
        void Test()
        {
            luaenv.DoString("CS.UnityEngine.Debug.Log('hello world')");
        }
        
        [Button("Lua Require")]
        void Require()
        {
            luaenv = new LuaEnv();
            luaenv.DoString("require 'LuaTest'");
            // luaenv.DoString("require 'A'");
            luaenv.Dispose();
        }
        
      

        void OnDestroy()
        {
            luaenv.Dispose();
        }
        
    }
}