/*
 * This file is auto-generated, do not modify directly.
 */

using System.Collections.Generic;
using Jurassic;

namespace Jurassic.Library
{

	public partial class FirebugConsole
	{
		private List<PropertyNameAndValue> GetDeclarativeProperties()
		{
			return new List<PropertyNameAndValue>(16)
			{
				new PropertyNameAndValue("log", new ClrStubFunction(Engine.FunctionInstancePrototype, "log", 1, __STUB__log), PropertyAttributes.NonEnumerable),
				new PropertyNameAndValue("debug", new ClrStubFunction(Engine.FunctionInstancePrototype, "debug", 1, __STUB__debug), PropertyAttributes.NonEnumerable),
				new PropertyNameAndValue("info", new ClrStubFunction(Engine.FunctionInstancePrototype, "info", 1, __STUB__info), PropertyAttributes.NonEnumerable),
				new PropertyNameAndValue("warn", new ClrStubFunction(Engine.FunctionInstancePrototype, "warn", 1, __STUB__warn), PropertyAttributes.NonEnumerable),
				new PropertyNameAndValue("error", new ClrStubFunction(Engine.FunctionInstancePrototype, "error", 1, __STUB__error), PropertyAttributes.NonEnumerable),
				new PropertyNameAndValue("assert", new ClrStubFunction(Engine.FunctionInstancePrototype, "assert", 2, __STUB__assert), PropertyAttributes.NonEnumerable),
				new PropertyNameAndValue("clear", new ClrStubFunction(Engine.FunctionInstancePrototype, "clear", 1, __STUB__clear), PropertyAttributes.NonEnumerable),
				new PropertyNameAndValue("group", new ClrStubFunction(Engine.FunctionInstancePrototype, "group", 1, __STUB__group), PropertyAttributes.NonEnumerable),
				new PropertyNameAndValue("groupCollapsed", new ClrStubFunction(Engine.FunctionInstancePrototype, "groupCollapsed", 1, __STUB__groupCollapsed), PropertyAttributes.NonEnumerable),
				new PropertyNameAndValue("groupEnd", new ClrStubFunction(Engine.FunctionInstancePrototype, "groupEnd", 0, __STUB__groupEnd), PropertyAttributes.NonEnumerable),
				new PropertyNameAndValue("time", new ClrStubFunction(Engine.FunctionInstancePrototype, "time", 1, __STUB__time), PropertyAttributes.NonEnumerable),
				new PropertyNameAndValue("timeEnd", new ClrStubFunction(Engine.FunctionInstancePrototype, "timeEnd", 1, __STUB__timeEnd), PropertyAttributes.NonEnumerable),
			};
		}

		private static object __STUB__log(ScriptEngine engine, object thisObj, object[] args)
		{
			thisObj = TypeConverter.ToObject(engine, thisObj);
			if (!(thisObj is FirebugConsole))
				throw new JavaScriptException(engine, "TypeError", "The method 'log' is not generic.");
			switch (args.Length)
			{
				case 0:
					((FirebugConsole)thisObj).Log(new object[0]); return Undefined.Value;
				default:
					((FirebugConsole)thisObj).Log(args); return Undefined.Value;
			}
		}

		private static object __STUB__debug(ScriptEngine engine, object thisObj, object[] args)
		{
			thisObj = TypeConverter.ToObject(engine, thisObj);
			if (!(thisObj is FirebugConsole))
				throw new JavaScriptException(engine, "TypeError", "The method 'debug' is not generic.");
			switch (args.Length)
			{
				case 0:
					((FirebugConsole)thisObj).Debug(new object[0]); return Undefined.Value;
				default:
					((FirebugConsole)thisObj).Debug(args); return Undefined.Value;
			}
		}

		private static object __STUB__info(ScriptEngine engine, object thisObj, object[] args)
		{
			thisObj = TypeConverter.ToObject(engine, thisObj);
			if (!(thisObj is FirebugConsole))
				throw new JavaScriptException(engine, "TypeError", "The method 'info' is not generic.");
			switch (args.Length)
			{
				case 0:
					((FirebugConsole)thisObj).Info(new object[0]); return Undefined.Value;
				default:
					((FirebugConsole)thisObj).Info(args); return Undefined.Value;
			}
		}

		private static object __STUB__warn(ScriptEngine engine, object thisObj, object[] args)
		{
			thisObj = TypeConverter.ToObject(engine, thisObj);
			if (!(thisObj is FirebugConsole))
				throw new JavaScriptException(engine, "TypeError", "The method 'warn' is not generic.");
			switch (args.Length)
			{
				case 0:
					((FirebugConsole)thisObj).Warn(new object[0]); return Undefined.Value;
				default:
					((FirebugConsole)thisObj).Warn(args); return Undefined.Value;
			}
		}

		private static object __STUB__error(ScriptEngine engine, object thisObj, object[] args)
		{
			thisObj = TypeConverter.ToObject(engine, thisObj);
			if (!(thisObj is FirebugConsole))
				throw new JavaScriptException(engine, "TypeError", "The method 'error' is not generic.");
			switch (args.Length)
			{
				case 0:
					((FirebugConsole)thisObj).Error(new object[0]); return Undefined.Value;
				default:
					((FirebugConsole)thisObj).Error(args); return Undefined.Value;
			}
		}

		private static object __STUB__assert(ScriptEngine engine, object thisObj, object[] args)
		{
			thisObj = TypeConverter.ToObject(engine, thisObj);
			if (!(thisObj is FirebugConsole))
				throw new JavaScriptException(engine, "TypeError", "The method 'assert' is not generic.");
			switch (args.Length)
			{
				case 0:
					((FirebugConsole)thisObj).Assert(false, new object[0]); return Undefined.Value;
				case 1:
					((FirebugConsole)thisObj).Assert(TypeConverter.ToBoolean(args[0]), new object[0]); return Undefined.Value;
				default:
					((FirebugConsole)thisObj).Assert(TypeConverter.ToBoolean(args[0]), TypeUtilities.SliceArray(args, 1)); return Undefined.Value;
			}
		}

		private static object __STUB__clear(ScriptEngine engine, object thisObj, object[] args)
		{
			thisObj = TypeConverter.ToObject(engine, thisObj);
			if (!(thisObj is FirebugConsole))
				throw new JavaScriptException(engine, "TypeError", "The method 'clear' is not generic.");
			switch (args.Length)
			{
				case 0:
					((FirebugConsole)thisObj).Clear(new object[0]); return Undefined.Value;
				default:
					((FirebugConsole)thisObj).Clear(args); return Undefined.Value;
			}
		}

		private static object __STUB__group(ScriptEngine engine, object thisObj, object[] args)
		{
			thisObj = TypeConverter.ToObject(engine, thisObj);
			if (!(thisObj is FirebugConsole))
				throw new JavaScriptException(engine, "TypeError", "The method 'group' is not generic.");
			switch (args.Length)
			{
				case 0:
					((FirebugConsole)thisObj).Group(new object[0]); return Undefined.Value;
				default:
					((FirebugConsole)thisObj).Group(args); return Undefined.Value;
			}
		}

		private static object __STUB__groupCollapsed(ScriptEngine engine, object thisObj, object[] args)
		{
			thisObj = TypeConverter.ToObject(engine, thisObj);
			if (!(thisObj is FirebugConsole))
				throw new JavaScriptException(engine, "TypeError", "The method 'groupCollapsed' is not generic.");
			switch (args.Length)
			{
				case 0:
					((FirebugConsole)thisObj).GroupCollapsed(new object[0]); return Undefined.Value;
				default:
					((FirebugConsole)thisObj).GroupCollapsed(args); return Undefined.Value;
			}
		}

		private static object __STUB__groupEnd(ScriptEngine engine, object thisObj, object[] args)
		{
			thisObj = TypeConverter.ToObject(engine, thisObj);
			if (!(thisObj is FirebugConsole))
				throw new JavaScriptException(engine, "TypeError", "The method 'groupEnd' is not generic.");
			((FirebugConsole)thisObj).GroupEnd(); return Undefined.Value;
		}

		private static object __STUB__time(ScriptEngine engine, object thisObj, object[] args)
		{
			thisObj = TypeConverter.ToObject(engine, thisObj);
			if (!(thisObj is FirebugConsole))
				throw new JavaScriptException(engine, "TypeError", "The method 'time' is not generic.");
			switch (args.Length)
			{
				case 0:
					((FirebugConsole)thisObj).Time(""); return Undefined.Value;
				default:
					((FirebugConsole)thisObj).Time(TypeConverter.ToString(args[0], "")); return Undefined.Value;
			}
		}

		private static object __STUB__timeEnd(ScriptEngine engine, object thisObj, object[] args)
		{
			thisObj = TypeConverter.ToObject(engine, thisObj);
			if (!(thisObj is FirebugConsole))
				throw new JavaScriptException(engine, "TypeError", "The method 'timeEnd' is not generic.");
			switch (args.Length)
			{
				case 0:
					((FirebugConsole)thisObj).TimeEnd(""); return Undefined.Value;
				default:
					((FirebugConsole)thisObj).TimeEnd(TypeConverter.ToString(args[0], "")); return Undefined.Value;
			}
		}
	}

}