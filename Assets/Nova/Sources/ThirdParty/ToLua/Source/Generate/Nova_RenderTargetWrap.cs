﻿// This source code was auto-generated by ToLua#, do not modify it
using System;
using LuaInterface;

public class Nova_RenderTargetWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Nova.RenderTarget), typeof(System.Object));
		L.RegFunction("Awake", Awake);
		L.RegFunction("Update", Update);
		L.RegFunction("OnDestroy", OnDestroy);
		L.RegFunction("Bind", Bind);
		L.RegFunction("Unbind", Unbind);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("SUFFIX", get_SUFFIX, null);
		L.RegVar("textureName", get_textureName, null);
		L.RegVar("textureFormat", get_textureFormat, null);
		L.RegVar("isFinal", get_isFinal, null);
		L.RegVar("needUpdate", get_needUpdate, null);
		L.RegVar("isActive", get_isActive, null);
		L.RegVar("targetTexture", get_targetTexture, set_targetTexture);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Awake(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Nova.RenderTarget obj = (Nova.RenderTarget)ToLua.CheckObject<Nova.RenderTarget>(L, 1);
			obj.Awake();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Update(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Nova.RenderTarget obj = (Nova.RenderTarget)ToLua.CheckObject<Nova.RenderTarget>(L, 1);
			obj.Update();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnDestroy(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Nova.RenderTarget obj = (Nova.RenderTarget)ToLua.CheckObject<Nova.RenderTarget>(L, 1);
			obj.OnDestroy();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Bind(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				Nova.RenderTarget obj = (Nova.RenderTarget)ToLua.CheckObject<Nova.RenderTarget>(L, 1);
				Nova.ITextureReceiver arg0 = (Nova.ITextureReceiver)ToLua.CheckObject<Nova.ITextureReceiver>(L, 2);
				obj.Bind(arg0);
				return 0;
			}
			else if (count == 3)
			{
				Nova.RenderTarget obj = (Nova.RenderTarget)ToLua.CheckObject<Nova.RenderTarget>(L, 1);
				UnityEngine.Material arg0 = (UnityEngine.Material)ToLua.CheckObject<UnityEngine.Material>(L, 2);
				string arg1 = ToLua.CheckString(L, 3);
				obj.Bind(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: Nova.RenderTarget.Bind");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Unbind(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				Nova.RenderTarget obj = (Nova.RenderTarget)ToLua.CheckObject<Nova.RenderTarget>(L, 1);
				Nova.ITextureReceiver arg0 = (Nova.ITextureReceiver)ToLua.CheckObject<Nova.ITextureReceiver>(L, 2);
				obj.Unbind(arg0);
				return 0;
			}
			else if (count == 3)
			{
				Nova.RenderTarget obj = (Nova.RenderTarget)ToLua.CheckObject<Nova.RenderTarget>(L, 1);
				UnityEngine.Material arg0 = (UnityEngine.Material)ToLua.CheckObject<UnityEngine.Material>(L, 2);
				string arg1 = ToLua.CheckString(L, 3);
				obj.Unbind(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: Nova.RenderTarget.Unbind");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_SUFFIX(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, Nova.RenderTarget.SUFFIX);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_textureName(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Nova.RenderTarget obj = (Nova.RenderTarget)o;
			string ret = obj.textureName;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index textureName on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_textureFormat(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Nova.RenderTarget obj = (Nova.RenderTarget)o;
			UnityEngine.RenderTextureFormat ret = obj.textureFormat;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index textureFormat on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isFinal(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Nova.RenderTarget obj = (Nova.RenderTarget)o;
			bool ret = obj.isFinal;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index isFinal on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_needUpdate(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Nova.RenderTarget obj = (Nova.RenderTarget)o;
			bool ret = obj.needUpdate;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index needUpdate on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isActive(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Nova.RenderTarget obj = (Nova.RenderTarget)o;
			bool ret = obj.isActive;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index isActive on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_targetTexture(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Nova.RenderTarget obj = (Nova.RenderTarget)o;
			UnityEngine.RenderTexture ret = obj.targetTexture;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index targetTexture on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_targetTexture(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Nova.RenderTarget obj = (Nova.RenderTarget)o;
			UnityEngine.RenderTexture arg0 = (UnityEngine.RenderTexture)ToLua.CheckObject<UnityEngine.RenderTexture>(L, 2);
			obj.targetTexture = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index targetTexture on a nil value");
		}
	}
}
