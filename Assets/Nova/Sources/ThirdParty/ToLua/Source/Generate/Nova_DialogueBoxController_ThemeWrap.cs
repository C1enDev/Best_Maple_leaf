﻿// This source code was auto-generated by ToLua#, do not modify it
using System;
using LuaInterface;

public class Nova_DialogueBoxController_ThemeWrap
{
	public static void Register(LuaState L)
	{
		L.BeginEnum(typeof(Nova.DialogueBoxController.Theme));
		L.RegVar("Default", get_Default, null);
		L.RegVar("Basic", get_Basic, null);
		L.RegFunction("IntToEnum", IntToEnum);
		L.EndEnum();
		TypeTraits<Nova.DialogueBoxController.Theme>.Check = CheckType;
		StackTraits<Nova.DialogueBoxController.Theme>.Push = Push;
	}

	static void Push(IntPtr L, Nova.DialogueBoxController.Theme arg)
	{
		ToLua.Push(L, arg);
	}

	static bool CheckType(IntPtr L, int pos)
	{
		return TypeChecker.CheckEnumType(typeof(Nova.DialogueBoxController.Theme), L, pos);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Default(IntPtr L)
	{
		ToLua.Push(L, Nova.DialogueBoxController.Theme.Default);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Basic(IntPtr L)
	{
		ToLua.Push(L, Nova.DialogueBoxController.Theme.Basic);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		Nova.DialogueBoxController.Theme o = (Nova.DialogueBoxController.Theme)arg0;
		ToLua.Push(L, o);
		return 1;
	}
}

