using System;

namespace Learn.EFCore.Core.Exceptions;

public class StructEmptyCtorNotAllowedException<T> : Exception
	where T: struct
{
	private StructEmptyCtorNotAllowedException(string message) 
		: base(message)
	{
		
    }

	public static StructEmptyCtorNotAllowedException<T> Create() 
	{
		var msg = 
			$"Пустой конструктор для структуры с типом {typeof(T).FullName} не поддерживается";

		var instance = new StructEmptyCtorNotAllowedException<T>(msg);
		return instance;
	}
}

