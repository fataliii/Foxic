﻿namespace Foxic.Business.Exeptions;

public class FileSizeException: Exception
{
	public FileSizeException(string message) : base(message)
	{ }
}
